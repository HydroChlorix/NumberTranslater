using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public static class TranslateFactory
    {
        public static ITranslater Create(int number)
        {
            ITranslater result = null;
            int numberDigit = GetNumberDigits(number);

            //switch (numberDigit)
            //{
            //    case 2: return new Ten(number, numberDigit);
            //    case 3: return new Hundred(number, numberDigit);
            //    case 4: return new Thousand(number, numberDigit);
            //    default: return new Unit(number, numberDigit);
            //}

            double ONE_THOUSAND = Math.Pow(10, 3);
            double ONE_MILLION = Math.Pow(10, 6);
            double ONE_BILLION = Math.Pow(10, 9);
            double ONE_TRILLION = Math.Pow(10, 12);
            double ONE_QUADRILLION = (long)Math.Pow(10, 15);

            if (number < 20)
            {
                result = new Unit(number, numberDigit);
            }
            else if (number < 100)
            {
                result = new Ten(number, numberDigit);
            }
            else if (number < ONE_THOUSAND)
            {
                //int numberDivideByThousand = Math.Truncate(number / ONE_THOUSAND);

                //if (10 <= numberDivideByThousand)
                //{
                //    result = new Unit(numberDivideByThousand, GetNumberDigits(numberDivideByThousand));
                //}
                //else
                //{
                 
                //}
                result = new Hundred(number, numberDigit);
            }
            else if (number < ONE_MILLION)
            {
                result = new Thousand(number, numberDigit);
            }
            else if (number < 1000000000)
            {
                result = new Million(number, numberDigit);
            }
            else
            {
                throw new ArgumentException();
            }

            return result;

        }
        public static int GetNumberDigits(int number)
        {
            return (int)Math.Floor(Math.Log10(number) + 1);
        }
    }

}
