using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleV2
{
    public class TranslaterManager : BaseNumber
    {
        public TranslaterManager(long number) : base(number)
        {
            _number = number;
        }

        public string GetSuffix()
        {
            if (0 <= _number && _number < ONE_HUNDRED)
            {
                return "TEN";
            }
            else if (ONE_HUNDRED <= _number && _number < ONE_THOUSAND)
            {
                return "ONE_HUNDRED";
            }
            else if (ONE_THOUSAND <= _number && _number < ONE_MILLION)
            {
                return "ONE_THOUSAND";
            }
            else if (ONE_MILLION <= _number && _number < ONE_BILLION)
            {
                return "ONE_MILLION";
            }
            else if (ONE_BILLION <= _number && _number < ONE_TRILLION)
            {
                return "ONE_BILLION";
            }
            else if (ONE_TRILLION <= _number && _number < ONE_QUADRILLION)
            {
                return "ONE_TRILLION";
            }
            else if (ONE_QUADRILLION <= _number)
            {
                return "ONE_QUADRILLION";
            }
            else
            {
                return string.Empty;
            }
        }

        public string GetWords()
        {
            //if (0 <= _number && _number < ONE_HUNDRED)
            //{
            //    return numberList[_number];
            //}
            //else if (ONE_HUNDRED <= _number && _number < ONE_THOUSAND)
            //{
            //    return "ONE_HUNDRED";
            //}
            //else if (ONE_THOUSAND <= _number && _number < ONE_MILLION)
            //{
            //    return "ONE_THOUSAND";
            //}
            //else if (ONE_MILLION <= _number && _number < ONE_BILLION)
            //{
            //    return "ONE_MILLION";
            //}
            //else if (ONE_BILLION <= _number && _number < ONE_TRILLION)
            //{
            //    return "ONE_BILLION";
            //}
            //else if (ONE_TRILLION <= _number && _number < ONE_QUADRILLION)
            //{
            //    return "ONE_TRILLION";
            //}
            //else if (ONE_QUADRILLION <= _number)
            //{
            //    return "ONE_QUADRILLION";
            //}
            //else
            //{
            //    return string.Empty;
            //}

            return string.Empty;
        }

        public int GetNumberDigits(long number)
        {
            return (int)Math.Floor(Math.Log10(number) + 1);
        }

        //protected int _divider
        //{
        //    get { return (int)Math.Pow(10, this._digit - 1); }
        //}
        //public int FirstNumber { get { return this._number / _divider; } }
        //public int LastNumber { get { return this._number % _divider; } }

    }
}
