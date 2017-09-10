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
            return string.Format("{0} {1}", base.numberList[this.FirstNumber], base.numberList[this._divider].ToLower());
        }

        public string ConvertSecondGroupToString()
        {
            string result = string.Empty;
            if (this.LastNumber != 0)
            {
                string value = numberList.TryGetValue(this.LastNumber, out value) ? value : TranslateFactory.Create(this.LastNumber).Translate();

                result = string.Format("and {0}", value);

            }
            return result;
        }

        public string Translate()
        {
            return string.Format("{0} {1}", this.ConvertFirstGroupToString(), this.ConvertSecondGroupToString().ToLower());
        }
    }
}
