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

            //var np = new NumberProcessor(inputResult);

            //long div = np.GetDivider();

            //var first = np.GetFirstPart(div);

            //var last = np.GetLastPart(first, div);


            var tr = new TranslaterManager(inputResult);



            Console.WriteLine(tr.GetSuffix());

            Console.Read();
        }
    }
}
