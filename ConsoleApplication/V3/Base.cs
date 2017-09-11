using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3
{
    public class Base
    {
        public static long TEN { get { return (long)10; } }
        public static long ONE_HUNDRED { get { return (long)Math.Pow(10, 2); } }
        public static long ONE_THOUSAND { get { return (long)Math.Pow(10, 3); } }
        public static long ONE_MILLION { get { return (long)Math.Pow(10, 6); } }
        public static long ONE_BILLION { get { return (long)Math.Pow(10, 9); } }
        public static long ONE_TRILLION { get { return (long)Math.Pow(10, 12); } }
        public static long ONE_QUADRILLION { get { return (long)Math.Pow(10, 15); } }

        public static Dictionary<long, string> numberList = new Dictionary<long, string>() {
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
            {100,"hundred" },
            {1000,"thousand" },
            {1000000,"million" },
            {1000000000,"billion" },
            {1000000000000,"trillion" },
            {1000000000000000,"quadrillion" }
        };

    }
}
