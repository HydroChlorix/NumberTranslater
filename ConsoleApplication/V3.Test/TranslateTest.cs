using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace V3.Test
{
    [TestClass]
    public class TranslateTest
    {
        [TestMethod]
        public void Translate_Zero_Success()
        {
            Translater ts = new Translater(0);
            var actual = ts.Translate();
            var expect = "Zero";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_Ten_Success()
        {
            Translater ts = new Translater(10);
            var actual = ts.Translate();
            var expect = "Ten";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_Hundred_Success()
        {
            Translater ts = new Translater(100);
            var actual = ts.Translate();
            var expect = "One hundred";

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Translate_Thousand_Success()
        {
            Translater ts = new Translater(1000);
            var actual = ts.Translate();
            var expect = "One thousand";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenThousand_Success()
        {
            Translater ts = new Translater(10 * 1000);
            var actual = ts.Translate();
            var expect = "Ten thousand";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneMillion_Success()
        {
            Translater ts = new Translater(1000 * 1000);
            var actual = ts.Translate();
            var expect = "One million";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenMillion_Success()
        {
            Translater ts = new Translater(10 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "Ten million";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneBillion_Success()
        {
            Translater ts = new Translater(1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "One billion";

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void Translate_TenBillion_Success()
        {
            Translater ts = new Translater((long)10 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "Ten billion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneTrillion_Success()
        {
            Translater ts = new Translater((long)1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "One trillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenTrillion_Success()
        {
            Translater ts = new Translater((long)10 * 1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "Ten trillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneQuadrillion_Success()
        {
            Translater ts = new Translater((long)1000 * 1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "One quadrillion";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_TenQuadrillion_Success()
        {
            Translater ts = new Translater((long)10 * 1000 * 1000 * 1000 * 1000 * 1000);
            var actual = ts.Translate();
            var expect = "Ten quadrillion";

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void Translate_TwentyOne_Success()
        {
            Translater ts = new Translater(21);
            var actual = ts.Translate();
            var expect = "Twenty One";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Translate_OneHundredTwentyOne_Success()
        {
            Translater ts = new Translater(121);
            var actual = ts.Translate();
            var expect = "One hundred Twenty One";

            Assert.AreEqual(expect, actual);
        }
    }
}
