using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Unit : BaseTranslater, ITranslater
    {
        public Unit(int number, int digit) : base(number, digit)
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
            return numberList[_number];
        }
    }

}
