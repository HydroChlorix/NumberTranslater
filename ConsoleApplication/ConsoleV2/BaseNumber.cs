using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleV2
{
    public class BaseNumber
    {
        public long TEN { get { return (long)10; } }
        public long ONE_HUNDRED { get { return (long)Math.Pow(10, 2); } }
        public long ONE_THOUSAND { get { return (long)Math.Pow(10, 3); } }
        public long ONE_MILLION { get { return (long)Math.Pow(10, 6); } }
        public long ONE_BILLION { get { return (long)Math.Pow(10, 9); } }
        public long ONE_TRILLION { get { return (long)Math.Pow(10, 12); } }
        public long ONE_QUADRILLION { get { return (long)Math.Pow(10, 15); } }

        protected long _number;
        public BaseNumber(long number)
        {
            this._number = number;
        }

        #region initial number
        protected Dictionary<long, string> numberList = new Dictionary<long, string>() {
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
            {1000000000000,"Trillion" },
            {1000000000000000,"Quadrillion" }
        };
        #endregion
    }
}
