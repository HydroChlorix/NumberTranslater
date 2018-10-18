using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTranslater.Nunit.Test
{
    [TestFixture]
    public class NTranslaterTest
    {
        private static Dictionary<decimal, string> specs = new Dictionary<decimal, string>() {
            { -1                              , "minus one"},
            { -500                            , "minus five hundred"},
            { 0                               , "zero"},
            { 10                              , "ten"},
            { 100                             , "one hundred"},
            { 21                              , "twenty one" },
            { 101                             , "one hundred one"},
            { 121                             , "one hundred twenty one"},
            { 1001                            , "one thousand one" },
            { 1121                            , "one thousand one hundred twenty one" },
            { 10121                           , "ten thousand one hundred twenty one" },
            { 222222                          , "two hundred twenty two thousand two hundred twenty two" },
            { 3 *   (decimal)Math.Pow(10, 6)  , "three million"   },
            { 3333333                         , "three million three hundred thirty three thousand three hundred thirty three" },
            { 44444444                        , "fourty four million four hundred fourty four thousand four hundred fourty four" },
            { 555555555                       , "five hundred fifty five million five hundred fifty five thousand five hundred fifty five" },
            { 5 *   (decimal)Math.Pow(10, 9)  , "five billion" },
            { 6666666666                      , "six billion six hundred sixty six million six hundred sixty six thousand six hundred sixty six" },
            { 77777777777                     , "seventy seven billion seven hundred seventy seven million seven hundred seventy seven thousand seven hundred seventy seven" },
            { 17117117117                     , "seventeen billion one hundred seventeen million one hundred seventeen thousand one hundred seventeen"},
            { 888888888888                    , "eight hundred eighty eight billion eight hundred eighty eight million eight hundred eighty eight thousand eight hundred eighty eight" },
            {       (decimal)Math.Pow(10, 12) , "one trillion" },
            { 9999999999999                   , "nine trillion nine hundred ninety nine billion nine hundred ninety nine million nine hundred ninety nine thousand nine hundred ninety nine" },

            { 10110210310412                  , "ten trillion one hundred ten billion two hundred ten million three hundred ten thousand four hundred twelve" },
            { 515515515515515                 , "five hundred fifteen trillion five hundred fifteen billion five hundred fifteen million five hundred fifteen thousand five hundred fifteen" },
            { 6 *   (decimal)Math.Pow(10, 15) , "six quadrillion" },
            { 6214214214214214                , "six quadrillion two hundred fourteen trillion two hundred fourteen billion two hundred fourteen million two hundred fourteen thousand two hundred fourteen" },
            { 10 *  (decimal)Math.Pow(10, 15) , "ten quadrillion" },
            { 100 * (decimal)Math.Pow(10, 15) , "one hundred quadrillion" },
            {       (decimal)Math.Pow(10, 18) , "one thousand quadrillion" },
            { 2 *   (decimal)Math.Pow(10, 18) , "two thousand quadrillion" },
            { 30 *  (decimal)Math.Pow(10, 18) , "thirty thousand quadrillion" },
            { 400 * (decimal)Math.Pow(10, 18) , "four hundred thousand quadrillion" },
            { 5 *   (decimal)Math.Pow(10, 21) , "five million quadrillion" },
            { 60 *  (decimal)Math.Pow(10, 21) , "sixty million quadrillion" },
            { 700 * (decimal)Math.Pow(10, 21) , "seven hundred million quadrillion" },
            { 8 *   (decimal)Math.Pow(10, 24) , "eight billion quadrillion" },
            { 90 *  (decimal)Math.Pow(10, 24) , "ninety billion quadrillion" },
            { 100 * (decimal)Math.Pow(10, 24) , "one hundred billion quadrillion" },
            { 2 *   (decimal)Math.Pow(10, 27) , "two trillion quadrillion" },
            { 30 *  (decimal)Math.Pow(10, 27) , "thirty trillion quadrillion" },
            { decimal.MaxValue                , "seventy nine trillion two hundred twenty eight billion one hundred sixty two million five hundred fourteen thousand two hundred sixty four quadrillion three hundred thirty seven trillion five hundred ninety three billion five hundred fourty three million nine hundred fifty thousand three hundred thirty five" }// Max
        };
        
        [Test,TestCaseSource("specs")]
        public void Translate_Collection_Success(KeyValuePair<decimal, string> testCase)
        {
            //arange
            var expect = testCase.Value;
            Translater ts = new Translater(testCase.Key);

            //act
            var actual = ts.Translate();

            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}
