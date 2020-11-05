using System;
using TDD;
using Xunit;

namespace xUnitTestCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ICalculator c = new CalculatorImpl();
            c.Set(5);
            Assert.Equal(5, c.Peek);
        }

        compilererror

        [Fact]
        public void TestAdd()
        {
            ICalculator c = new CalculatorImpl();
            c.Set(5);
            c.Add(9);
            Assert.Equal(14, c.Peek);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(-7)]
        [InlineData(123445)]
        [InlineData(int.MaxValue -3)]
        public void CanAdd(int value)
        {
            ICalculator c = new CalculatorImpl();

            c.Set(5);
            int current = c.Peek;

            c.Add(value);

            Assert.Equal(current + value, c.Peek);
            //Assert.True(value < c.Peek);
        }
    }
}
