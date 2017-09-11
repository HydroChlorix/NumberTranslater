using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3
{
    public class Translater : Base
    {

        private long _number;

        public Translater(long number)
        {
            _number = number;
        }

        public string Translate()
        {
            List<string> words = new List<string>();


            return GetWord(_number);
        }

        private string GetWord(long _number, List<string> collections = null)
        {
            string word = string.Empty;
            long nextNumber = 0;

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

                word = numberList[(long)Math.Floor((double)_number / TEN) * TEN];

                if (nextNumber != 0)
                {
                    word += " " + numberList[nextNumber];
                    nextNumber = 0;
                }
            }
            else if (_number < ONE_THOUSAND)
            {
                nextNumber = _number % ONE_HUNDRED;
                if (nextNumber == 0)
                {
                    word = numberList[_number / ONE_HUNDRED];
                }
                else
                {
                    word = GetWord((long)Math.Floor((double)(_number / ONE_HUNDRED)));
                }
                word += " hundred";
            }
            else if (_number < ONE_MILLION)
            {
                nextNumber = _number % ONE_THOUSAND;
                if (nextNumber == 0)
                {
                    word = numberList[_number / ONE_THOUSAND];
                }
                else
                {
                    word = GetWord((long)Math.Floor((double)(_number / ONE_THOUSAND)));
                }
                word += " thousand";
            }
            else if (_number < ONE_BILLION)
            {
                nextNumber = _number % ONE_MILLION;
                if (nextNumber == 0)
                {
                    word = numberList[_number / ONE_MILLION];
                }
                else
                {
                    word = GetWord((long)Math.Floor((double)(_number / ONE_MILLION)));
                }
                word += " million";
            }
            else if (_number < ONE_TRILLION)
            {
                nextNumber = _number % ONE_BILLION;
                if (nextNumber == 0)
                {
                    word = numberList[_number / ONE_BILLION];
                }
                else
                {
                    word = GetWord((long)Math.Floor((double)(_number / ONE_BILLION)));
                }
                word += " billion";
            }
            else if (_number < ONE_QUADRILLION)
            {
                nextNumber = _number % ONE_TRILLION;
                if (nextNumber == 0)
                {
                    word = numberList[_number / ONE_TRILLION];
                }
                else
                {
                    word = GetWord((long)Math.Floor((double)(_number / ONE_TRILLION)));
                }

                word += " trillion";
            }
            else if (_number < long.MaxValue)
            {
                nextNumber = _number % ONE_QUADRILLION;

                var numberRatio = _number / ONE_QUADRILLION;

                if (nextNumber == 0)
                {
                    //word = numberList[numberRatio];
                    word = GetWord((long)Math.Floor((double)(numberRatio)));
                }
                else
                {
                    word = GetWord((long)Math.Floor((double)(numberRatio)));
                }
                word += " quadrillion";
            }

            collections.Add(word);

            return GetWord(nextNumber, collections);
        }
    }
}
