using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace V3.Test
{
    [TestClass]
    public class TranslateTest
    {

        public TranslateTest()
        {

        }
        [TestMethod]
        public void Translate_Zero_Success()
        {
            Translater ts = new Translater(0);
            var actual = ts.Translate();
            var expect = "zero";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_Ten_Success()
        {
            Translater ts = new Translater(10);
            var actual = ts.Translate();
            var expect = "ten";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_Hundred_Success()
        {
            Translater ts = new Translater(100);
            var actual = ts.Translate();
            var expect = "one hundred";

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Translate_Thousand_Success()
        {
            Translater ts = new Translater(1000);
            var actual = ts.Translate();
            var expect = "one thousand";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenThousand_Success()
        {
            Translater ts = new Translater(10 * 1000);
            var actual = ts.Translate();
            var expect = "ten thousand";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneMillion_Success()
        {
            Translater ts = new Translater(1000 * 1000);
            var actual = ts.Translate();
            var expect = "one million";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenMillion_Success()
        {
            Translater ts = new Translater(10 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "ten million";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneBillion_Success()
        {
            Translater ts = new Translater(1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "one billion";

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void Translate_TenBillion_Success()
        {
            Translater ts = new Translater((decimal)10 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "ten billion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneTrillion_Success()
        {
            Translater ts = new Translater((decimal)1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "one trillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenTrillion_Success()
        {
            Translater ts = new Translater((decimal)10 * 1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "ten trillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneQuadrillion_Success()
        {
            Translater ts = new Translater((decimal)1000 * 1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "one quadrillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenQuadrillion_Success()
        {
            Translater ts = new Translater((decimal)10 * 1000 * 1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "ten quadrillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TWO_THOUSAND_QUADRILLION_Success()
        {
            foreach (var item in spec)
            {
                Translater ts = new Translater(2 * (decimal)Math.Pow(10, 18));
                var actual = ts.Translate();
                var expect = "two thousand quadrillion";
                Assert.AreEqual(expect, actual);
            }
        }

        [TestMethod]
        public void Translate_400_Thousand_Quadrillion_Success()
        {
            foreach (var item in spec)
            {
                Translater ts = new Translater(400 * (decimal)Math.Pow(10, 18));
                var actual = ts.Translate();
                var expect = "four hundred thousand quadrillion";
                Assert.AreEqual(expect, actual);
            }
        }

        private Dictionary<decimal, string> spec = new Dictionary<decimal, string>() {
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
            { 5 *   (decimal)Math.Pow(10, 9)  ,"five billion" },
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
            { decimal.MaxValue , "seventy nine trillion two hundred twenty eight billion one hundred sixty two million five hundred fourteen thousand two hundred sixty four quadrillion three hundred thirty seven trillion five hundred ninety three billion five hundred fourty three million nine hundred fifty thousand three hundred thirty five" }// Max
        };
        [TestMethod]
        public void Translate_Collection_Success()
        {
            foreach (var item in spec)
            {
                Translater ts = new Translater(item.Key);
                var actual = ts.Translate();
                var expect = item.Value;
                Assert.AreEqual(expect, actual);
            }
        }

    }
}
