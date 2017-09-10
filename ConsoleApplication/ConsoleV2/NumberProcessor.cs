using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleV2
{
    public class NumberProcessor : BaseNumber
    {
        public NumberProcessor(long number) : base(number)
        {
        }

        public long GetDivider()
        {
            long result = 0;
            if (0 <= _number && _number < ONE_HUNDRED)
            {
                //result = (int)_number;
                result = TEN;
            }
            else if (ONE_HUNDRED <= _number && _number < ONE_THOUSAND)
            {
                //result = (int)_number;
                result = ONE_HUNDRED;
            }
            else if (ONE_THOUSAND <= _number && _number < ONE_MILLION)
            {
                //result = GetFirstPart(ONE_THOUSAND);
                result = ONE_THOUSAND;
            }
            else if (ONE_MILLION <= _number && _number < ONE_BILLION)
            {
                //result = GetFirstPart(ONE_MILLION);
                result = ONE_MILLION;
            }
            else if (ONE_BILLION <= _number && _number < ONE_TRILLION)
            {
                //result = GetFirstPart(ONE_BILLION);
                result = ONE_BILLION;
            }
            else if (ONE_TRILLION <= _number && _number < ONE_QUADRILLION)
            {
                //result = GetFirstPart(ONE_TRILLION);
                result = ONE_TRILLION;
            }
            else if (ONE_QUADRILLION <= _number)
            {
                //result = GetFirstPart(ONE_QUADRILLION);
                result = ONE_QUADRILLION;
            }


            return result;
        }

        public int GetFirstPart(long divider)
        {
            return (int)Math.Truncate((decimal)((_number) / divider));
        }

        public long GetLastPart(int firstPart, long multiplier)
        {
            return _number - (firstPart * multiplier);
        }
    }

}
