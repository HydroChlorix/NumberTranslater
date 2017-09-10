using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Billion : BaseTranslater, ITranslater
    {
        public Billion(int number, int digit) : base(number, digit)
        {
        }

        public string ConvertFirstGroupToString()
        {
            throw new NotImplementedException();
        }

        public string ConvertSecondGroupToString()
        {
            throw new NotImplementedException();
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
