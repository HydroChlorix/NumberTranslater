using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3
{
    public class Translater : Base
    {

        private decimal _number;

        public Translater(decimal number)
        {
            _number = number;
        }

        public string Translate()
        {
            List<string> words = new List<string>();


            return GetWord(_number);
        }

        private string GetWord(decimal _number, List<string> collections = null)
        {
            string word = string.Empty;
            decimal nextNumber = 0;

            if (_number == 0)
            {
                return collections != null && collections.Any() ? string.Join(" ", collections) : numberList[0];
            }

            if (collections == null)
            {
                collections = new List<string>();
            }

            if (_number < 21)
            {
                nextNumber = 0;
                word = numberList[_number];
                //return numberList[_number];
            }
            else if (_number < ONE_HUNDRED)
            {
                nextNumber = _number % TEN;

                word = numberList[Math.Floor(_number / TEN) * TEN];

                if (nextNumber != 0)
                {
                    word += " " + numberList[nextNumber];
                    nextNumber = 0;
                }
            }
            else if (_number < ONE_THOUSAND)
            {
                nextNumber = _number % ONE_HUNDRED;

                //var numberRatio = _number / ONE_QUADRILLION;

                if (nextNumber == 0)
                {
                    word = numberList[_number / ONE_HUNDRED];
                }
                else
                {
                    word = GetWord(Math.Floor(_number / ONE_HUNDRED));
                }
                word += " hundred";
            }
            else if (_number < ONE_MILLION)
            {
                nextNumber = _number % ONE_THOUSAND;

                var numberRatio = _number / ONE_THOUSAND;

                if (nextNumber == 0 && numberRatio < ONE_HUNDRED)
                {
                    word = numberList[numberRatio];
                }
                else
                {
                    word = GetWord(Math.Floor(numberRatio));
                }
                word += " thousand";
            }
            else if (_number < ONE_BILLION)
            {
                nextNumber = _number % ONE_MILLION;

                var numberRatio = _number / ONE_MILLION;

                if (nextNumber == 0 && numberRatio < ONE_HUNDRED)
                {
                    word = numberList[numberRatio];
                }
                else
                {
                    word = GetWord(Math.Floor(numberRatio));
                }
                word += " million";
            }
            else if (_number < ONE_TRILLION)
            {
                nextNumber = _number % ONE_BILLION;

                var numberRatio = _number / ONE_BILLION;

                if (nextNumber == 0 && numberRatio < ONE_HUNDRED)
                {
                    word = numberList[numberRatio];
                }
                else
                {
                    word = GetWord(Math.Floor(numberRatio));
                }
                word += " billion";
            }
            else if (_number < ONE_QUADRILLION)
            {
                nextNumber = _number % ONE_TRILLION;

                var numberRatio = _number / ONE_TRILLION;

                if (nextNumber == 0 && numberRatio < ONE_HUNDRED)
                {
                    word = numberList[numberRatio];
                }
                else
                {
                    word = GetWord(Math.Floor(numberRatio));
                }

                word += " trillion";
            }
            else if (_number < decimal.MaxValue)
            {
                nextNumber = _number % ONE_QUADRILLION;

                var numberRatio = _number / ONE_QUADRILLION;

                word = GetWord(Math.Floor((numberRatio)));

                word += " quadrillion";
            }

            collections.Add(word);

            return GetWord(nextNumber, collections);
        }
    }
}
