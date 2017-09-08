using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class BaseTranslater
    {
        #region initial number
        protected Dictionary<int, string> numberList = new Dictionary<int, string>() {
            {0 ,"Zero" },
            {1 ,"One" },
            {2 ,"Two" },
            {3 ,"Three" },
            {4 ,"Four" },
            {5 ,"Five" },
            {6 ,"Six" },
            {7 ,"Seven" },
            {8 ,"Eight" },
            {9 ,"Nine" },
            {10,"Ten" },
            {11,"Eleven" },
            {12,"Twelve" },
            {13,"Thirteen" },
            {14,"Fourteen" },
            {15,"Fiftteen" },
            {16,"Sixteen" },
            {17,"Seventeen" },
            {18,"Eighteen" },
            {19,"Nineteen" },
            {20,"Twenty" },
            {30,"Thirty" },
            {40,"Fourty" },
            {50,"Fifty" },
            {60,"Sixty" },
            {70,"Seventy" },
            {80,"Eithty" },
            {90,"Ninety" },
            {100,"Hundred" },
            {1000,"Thousand" },
            {1000000,"Million" },
            {1000000000,"Billion" },	
            //{1000000000000,"Trillion" },	
        };
        #endregion
        protected int _number;
        protected int _digit;

        public BaseTranslater(int number, int digit)
        {
            this._number = number;
            this._digit = digit;
        }

        protected int _divider
        {
            get { return (int)Math.Pow(10, this._digit - 1); }
        }
        public int FirstNumber { get { return this._number / _divider; } }
        public int LastNumber { get { return this._number % _divider; } }

    }
}
