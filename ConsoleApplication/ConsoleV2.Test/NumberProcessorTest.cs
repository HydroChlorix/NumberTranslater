using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleV2.Test
{
    [TestClass]
    public class NumberProcessorTest
    {
        private long Hundred_TestNumber = 123;
        private long Thousand_TestNumber = 123456;
        private long Million_TestNumber = 123456789;
        private long Billion_TestNumber = 123456789111;
        private long Trillion_TestNumber = 123456789111222;
        private long Quadrillion_TestNumber = 123456789111222333;

        [TestMethod]
        public void GetPart_Hundred_Success()
        {
            NumberProcessor np = new NumberProcessor(Hundred_TestNumber);
            int expect = 123;

            long actual = np.GetDivider();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Thousand_Success()
        {
            NumberProcessor np = new NumberProcessor(Thousand_TestNumber);
            int expect = 123;

            long actual = np.GetDivider();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Million_Success()
        {
            NumberProcessor np = new NumberProcessor(Million_TestNumber);
            int expect = 123;

            long actual = np.GetDivider();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Billion_Success()
        {
            NumberProcessor np = new NumberProcessor(Billion_TestNumber);
            int expect = 123;

            long actual = np.GetDivider();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Trillion_Success()
        {
            NumberProcessor np = new NumberProcessor(Trillion_TestNumber);
            int expect = 123;

            long actual = np.GetDivider();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Quadrillion_Success()
        {
            NumberProcessor np = new NumberProcessor(Quadrillion_TestNumber);
            int expect = 123;

            long actual = np.GetDivider();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetFirstPart_THOUSAND_Success()
        {
            NumberProcessor np = new NumberProcessor(Thousand_TestNumber);
            int expect = 123;

            int actual = np.GetFirstPart(np.ONE_THOUSAND);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetLastPart_THOUSAND_Success()
        {
            NumberProcessor np = new NumberProcessor(Thousand_TestNumber);
            int expect = 456;

            long actual = np.GetLastPart(np.GetFirstPart(np.ONE_THOUSAND), np.ONE_THOUSAND);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetFirstPart_Million_Success()
        {
            NumberProcessor np = new NumberProcessor(Million_TestNumber);
            int expect = 123;

            int actual = np.GetFirstPart(np.ONE_MILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetLastPart_Million_Success()
        {
            NumberProcessor np = new NumberProcessor(Million_TestNumber);
            int expect = 456789;

            long actual = np.GetLastPart(np.GetFirstPart(np.ONE_MILLION), np.ONE_MILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetFirstPart_BILLION_Success()
        {
            NumberProcessor np = new NumberProcessor(Billion_TestNumber);
            int expect = 123;

            int actual = np.GetFirstPart(np.ONE_BILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetLastPart_BILLION_Success()
        {
            NumberProcessor np = new NumberProcessor(Billion_TestNumber);
            int expect = 456789111;

            long actual = np.GetLastPart(np.GetFirstPart(np.ONE_BILLION), np.ONE_BILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetFirstPart_TRILLION_Success()
        {
            NumberProcessor np = new NumberProcessor(Trillion_TestNumber);
            int expect = 123;

            int actual = np.GetFirstPart(np.ONE_TRILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetLastPart_TRILLION_Success()
        {
            NumberProcessor np = new NumberProcessor(Trillion_TestNumber);
            long expect = 456789111222;

            long actual = np.GetLastPart(np.GetFirstPart(np.ONE_TRILLION), np.ONE_TRILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetFirstPart_QUADRILLION_Success()
        {
            NumberProcessor np = new NumberProcessor(Quadrillion_TestNumber);
            int expect = 123;

            int actual = np.GetFirstPart(np.ONE_QUADRILLION);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetLastPart_QUADRILLION_Success()
        {
            NumberProcessor np = new NumberProcessor(Quadrillion_TestNumber);
            long expect = 456789111222333;

            long actual = np.GetLastPart(np.GetFirstPart(np.ONE_QUADRILLION), np.ONE_QUADRILLION);

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void Process_Hundred_Success()
        {
            var np = new NumberProcessor(Hundred_TestNumber);

            long div = np.GetDivider();

            var first = np.GetFirstPart(div);

            var last = np.GetLastPart(first, div);

            var translateFirst = new TranslaterManager(first);

            translateFirst.GetWords();
        }

        //[TestMethod]
        //public void Process_Hundred_Success()
        //{

        //}

      
    }
}
