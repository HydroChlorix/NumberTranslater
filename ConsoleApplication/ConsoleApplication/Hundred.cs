using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Hundred : BaseTranslater, ITranslater
    {
        public Hundred(int number, int digit) : base(number, digit)
        {
        }

        public string Translate()
        {
            return string.Format("{0} {1}", this.ConvertFirstGroupToString(), this.ConvertSecondGroupToString());
        }

        private string ConvertFirstGroupToString()
        {
            string result = string.Empty;

            //if (this._firstGroup == 1)
            //{
            //    result = base.numberList[this._firstGroup];//Only 2 digit
            //}
            //else
            //{
            //    result = ;
            //}

            return string.Format("{0} {1}", this.FirstNumber, base.numberList[this._divider]);
        }
        private string ConvertSecondGroupToString()
        {
            string result = string.Empty;
            if (this.FirstNumber > 1 && this.LastNumber != 0)
            {
                result = numberList[this.LastNumber];
            }
            return result;
        }
    }
}
