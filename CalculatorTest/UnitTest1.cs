using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetandPeek()
        {
            ICalculator c = new CalculatorImpl();
            c.Set(5);
            Assert.AreEqual(5, c.Peek);
        }

        [TestMethod]
        public void TestAdd()
        {
            ICalculator c = new CalculatorImpl();
            c.Set(5);
            c.Add(9);
            Assert.AreEqual(14, c.Peek);
        }

        [TestMethod]
        public void TestDiv()
        {
            ICalculator c = new CalculatorImpl();
            c.Set(10);
            c.Div(2);
            Assert.AreEqual(5, c.Peek);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDivException()
        {
            ICalculator c = new CalculatorImpl();
            c.Set(5);
            c.Div(0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCorrectInit()
        {
            ICalculator c = new CalculatorImpl();
            int x = c.Peek;
        }
    }
}
