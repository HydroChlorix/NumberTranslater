using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3
{
    class Program
    {

        static void Main(string[] args)
        {
            Translater ts = new Translater(2000000000000000000);
            var actual = ts.Translate();

            Console.WriteLine(actual);
            //Run(Enumerable.Range(100, 201));

            var x = decimal.MaxValue;
            Console.ReadLine();
        }

        private static void Run(IEnumerable<int> enumerable)
        {
            foreach (var number in enumerable)
            {
                Translater ts = new Translater(number);
                Console.WriteLine(ts.Translate());
            }
        }
    }
}
