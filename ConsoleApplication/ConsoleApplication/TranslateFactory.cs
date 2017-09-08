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
            int numberDigit = GetNumberDigits(number);

            switch (numberDigit)
            {
                case 2: return new Ten(number, numberDigit);
                case 3: return new Hundred(number, numberDigit);
                case 4: return new Thousand(number, numberDigit);
                default: return new Unit(number, numberDigit);
            }
        }
        public static int GetNumberDigits(int number)
        {
            return (int)Math.Floor(Math.Log10(number) + 1);
        }
    }

}
