using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleV2.Test
{
    [TestClass]
    public class TranslaterTest
    {
        [TestMethod]
        public void GetSuffix_ONE_HUNDRED_Success()
        {

            TranslaterManager ts = new TranslaterManager(123);

            string expect = "ONE_HUNDRED";

            string actual = ts.GetSuffix();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetSuffix_ONE_THOUSAND_Success()
        {
            TranslaterManager ts = new TranslaterManager(123456);

            string expect = "ONE_THOUSAND";

            string actual = ts.GetSuffix();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetSuffix_ONE_MILLION_Success()
        {
            TranslaterManager ts = new TranslaterManager(123456789);

            string expect = "ONE_MILLION";

            string actual = ts.GetSuffix();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetSuffix_ONE_BILLION_Success()
        {
            TranslaterManager ts = new TranslaterManager(123456789000);

            string expect = "ONE_BILLION";

            string actual = ts.GetSuffix();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetSuffix_ONE_TRILLION_Success()
        {
            TranslaterManager ts = new TranslaterManager(123456789000123);

            string expect = "ONE_TRILLION";

            string actual = ts.GetSuffix();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetSuffix_ONE_QUADRILLION_Success()
        {
            TranslaterManager ts = new TranslaterManager(123456789000123456);

            string expect = "ONE_QUADRILLION";

            string actual = ts.GetSuffix();

            Assert.AreEqual(expect, actual);
        }

        //[TestMethod]
        //public void GetWord_ONE_HUNDRED_Success()
        //{

        //    TranslaterManager ts = new TranslaterManager(20);

        //    string expect = "Twenty";

        //    string actual = ts.GetWords();

        //    Assert.AreEqual(expect, actual);
        //}

    }
}
