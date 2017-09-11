using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTranslater
{
    public class Translater : BaseTranslater
    {
        private decimal _number;

        public Translater(decimal number)
        {
            _number = number;
        }

        public string Translate()
        {
            return GetWord(_number);
        }

        private string GetWord(decimal number, List<string> collections = null)
        {
            string word = string.Empty;
            decimal nextNumber = 0;

            if (number == 0)
            {
                return collections != null && collections.Any() ? string.Join(" ", collections) : numberList[0];
            }

            if (collections == null)
            {
                collections = new List<string>();
            }

            if (number < 0)
            {
                collections.Add("minus");
                number = Math.Abs(number);
            }

            if (number < 21)
            {
                nextNumber = 0;
                word = numberList[number];
            }
            else if (number < ONE_HUNDRED)
            {
                nextNumber = number % TEN;

                word = numberList[Math.Floor(number / TEN) * TEN];

                if (nextNumber != 0)
                {
                    word += " " + numberList[nextNumber];
                    nextNumber = 0;
                }
            }
            else if (number < ONE_THOUSAND)
            {
                nextNumber = number % ONE_HUNDRED;

                if (nextNumber == 0)
                {
                    word = numberList[number / ONE_HUNDRED];
                }
                else
                {
                    word = GetWord(Math.Floor(number / ONE_HUNDRED));
                }
                word += " hundred";
            }
            else if (number < ONE_MILLION)
            {
                nextNumber = number % ONE_THOUSAND;

                var numberRatio = number / ONE_THOUSAND;

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
            else if (number < ONE_BILLION)
            {
                nextNumber = number % ONE_MILLION;

                var numberRatio = number / ONE_MILLION;

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
            else if (number < ONE_TRILLION)
            {
                nextNumber = number % ONE_BILLION;

                var numberRatio = number / ONE_BILLION;

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
            else if (number < ONE_QUADRILLION)
            {
                nextNumber = number % ONE_TRILLION;

                var numberRatio = number / ONE_TRILLION;

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
            else if (number <= decimal.MaxValue)
            {
                nextNumber = number % ONE_QUADRILLION;

                word = GetWord(Math.Floor(number / ONE_QUADRILLION)) + " quadrillion";
            }

            collections.Add(word);

            return GetWord(nextNumber, collections);
        }
    }
}
