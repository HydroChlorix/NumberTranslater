using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTranslater
{
    public class BaseTranslater
    {
        public static decimal TEN { get { return 10; } }
        public static decimal ONE_HUNDRED { get { return (decimal)Math.Pow(10, 2); } }
        public static decimal ONE_THOUSAND { get { return (decimal)Math.Pow(10, 3); } }
        public static decimal ONE_MILLION { get { return (decimal)Math.Pow(10, 6); } }
        public static decimal ONE_BILLION { get { return (decimal)Math.Pow(10, 9); } }
        public static decimal ONE_TRILLION { get { return (decimal)Math.Pow(10, 12); } }
        public static decimal ONE_QUADRILLION { get { return (decimal)Math.Pow(10, 15); } }

        public static Dictionary<decimal, string> numberList = new Dictionary<decimal, string>() {
            {0 ,"zero" },
            {1 ,"one" },
            {2 ,"two" },
            {3 ,"three" },
            {4 ,"four" },
            {5 ,"five" },
            {6 ,"six" },
            {7 ,"seven" },
            {8 ,"eight" },
            {9 ,"nine" },
            {10,"ten" },
            {11,"eleven" },
            {12,"twelve" },
            {13,"thirteen" },
            {14,"fourteen" },
            {15,"fifteen" },
            {16,"sixteen" },
            {17,"seventeen" },
            {18,"eighteen" },
            {19,"nineteen" },
            {20,"twenty" },
            {30,"thirty" },
            {40,"fourty" },
            {50,"fifty" },
            {60,"sixty" },
            {70,"seventy" },
            {80,"eighty" },
            {90,"ninety" },
        };

    }
}
