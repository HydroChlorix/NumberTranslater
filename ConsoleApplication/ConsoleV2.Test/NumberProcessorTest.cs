using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleV2.Test
{
    [TestClass]
    public class NumberProcessorTest
    {
        [TestMethod]
        public void GetPart_Hundred_Success()
        {
            NumberProcessor np = new NumberProcessor(123);
            int expect = 123;

            int actual = np.GetEachPart();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Thousand_Success()
        {
            NumberProcessor np = new NumberProcessor(123456);
            int expect = 123;

            int actual = np.GetEachPart();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Million_Success()
        {
            NumberProcessor np = new NumberProcessor(123456789);
            int expect = 123;

            int actual = np.GetEachPart();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Billion_Success()
        {
            NumberProcessor np = new NumberProcessor(123456789000);
            int expect = 123;

            int actual = np.GetEachPart();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Trillion_Success()
        {
            NumberProcessor np = new NumberProcessor(123456789000111);
            int expect = 123;

            int actual = np.GetEachPart();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetPart_Quadrillion_Success()
        {
            NumberProcessor np = new NumberProcessor(123456789000111222);
            int expect = 123;

            int actual = np.GetEachPart();

            Assert.AreEqual(expect, actual);
        }
    }
}
