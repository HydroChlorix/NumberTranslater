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
            return string.Format("{0} {1}", this.ConvertFirstGroupToString(), this.ConvertSecondGroupToString().ToLower());
        }
    }
}
