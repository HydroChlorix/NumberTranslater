using ConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");

            var input = Console.ReadLine();
           
            long inputResult = long.TryParse(input.ToString(), out inputResult) ? inputResult : 0;

            var np = new NumberProcessor(inputResult);

            var tr = new Translater(inputResult);
            
            Console.WriteLine(tr.GetSuffix());

            Console.Read();
        }
    }


    public class NumberProcessor : BaseNumber
    {
        public NumberProcessor(long number) : base(number)
        {
        }

        public int GetEachPart()
        {
            int result = 0;
            if (0 <= _number && _number < ONE_HUNDRED)
            {
                result = (int)_number;
            }
            else if (ONE_HUNDRED <= _number && _number < ONE_THOUSAND)
            {
                result = (int)_number;
            }
            else if (ONE_THOUSAND <= _number && _number < ONE_MILLION)
            {
                result = GetNumberOfPart(ONE_THOUSAND);
            }
            else if (ONE_MILLION <= _number && _number < ONE_BILLION)
            {
                result = GetNumberOfPart(ONE_MILLION);
            }
            else if (ONE_BILLION <= _number && _number < ONE_TRILLION)
            {
                result = GetNumberOfPart(ONE_BILLION);
            }
            else if (ONE_TRILLION <= _number && _number < ONE_QUADRILLION)
            {
                result = GetNumberOfPart(ONE_TRILLION);
            }
            else if (ONE_QUADRILLION <= _number)
            {
                result = GetNumberOfPart(ONE_QUADRILLION);
            }

            //var firstPart = (int)Math.Truncate((decimal)((_number) / ONE_MILLION));
            //var lastPart = (_number) - (firstPart * ONE_THOUSAND);

            return result;
        }
        private int GetNumberOfPart(long numberPart)
        {
            return (int)Math.Truncate((decimal)((_number) / numberPart));
        }
    }
    public class Translater : BaseNumber
    {
        public Translater(long number) : base(number)
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

    }
}
