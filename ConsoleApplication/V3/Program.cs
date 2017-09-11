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
            //Translater ts = new Translater(100);
            //var actual = ts.Translate();

            //Console.WriteLine(actual);
            Run(Enumerable.Range(20, 10));
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
