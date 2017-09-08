using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Thousand : BaseTranslater, ITranslater
    {
        public Thousand(int number, int digit) : base(number, digit)
        {
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
