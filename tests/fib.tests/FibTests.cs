using System;
using Xunit;

namespace fib.tests
{
    public class FibTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        public void Test1(int n, int expectedValue)
        {
            var fib = new Fibonnaci();

            Assert.Equal(expectedValue, fib.Calculate(n));
        }
    }
}
