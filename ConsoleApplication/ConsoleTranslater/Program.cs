using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTranslater
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input number : ");
                var input = Console.ReadLine();
                decimal number = 0;

                if (input == "q" || input == "Q")
                {
                    break;
                }
                else
                {
                    if (decimal.TryParse(input, out number))
                    {
                        Translater ts = new Translater(decimal.MaxValue);
                        Console.WriteLine(ts.Translate());
                    }
                    else
                    {
                        Console.WriteLine("incorrect number input. pleas try again. (Press q to exit.)");
                    }
                }
            }
        }
    }
}
