using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleV2
{
    public class BaseNumber
    {
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

    }
}
