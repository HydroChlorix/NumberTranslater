using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Ten : BaseTranslater, ITranslater
    {
        public Ten(int number, int digit) : base(number, digit)
        {
        }

        public string Translate()
        {
            return string.Format("{0} {1}", this.ConvertFirstGroupToString(), this.ConvertSecondGroupToString());
            //return string.Format("{0} {1}", this._firstGroup, this._secondGroup);
        }

        private string ConvertFirstGroupToString()
        {
            string result = string.Empty;

            if (this.FirstNumber > 1)
            {
                result = base.numberList[this.FirstNumber * this._divider];
            }
            else
            {
                result = base.numberList[this._number];
            }

            return result;
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
