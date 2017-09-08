
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumerable.Range(0, 30).OrderByDescending(n => n);
            //Run(Enumerable.Range(0, 1));
            //Run(Enumerable.Range(0, 10));
            //Run(Enumerable.Range(10, 10));
            //Run(Enumerable.Range(20, 80));
            Run(Enumerable.Range(1000, 10));

            //Run(Enumerable.Range(200, 3));

            //Run(Enumerable.Range(300, 3));

            //Run(Enumerable.Range(400, 3));

            //Run(Enumerable.Range(40, 70));
            //Run(Enumerable.Range(0, 10));


            Console.ReadLine();
        }

        private static void Run(IEnumerable<int> enumerable)
        {
            //TranslateService ts = new TranslateService();
            foreach (var item in enumerable.OrderBy(n => n))
            {
                Console.WriteLine("{0} {1}", item, TranslateFactory.Create(item).Translate());
            }
            Console.WriteLine();
        }
    }
}
