using System;
using Xunit;
using Assignment00;

namespace Assignment00.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData("1234", 10)]
        [InlineData("0000", 0)]
        [InlineData("2147483647", 46)]
        [InlineData("9223372036854775807", 88)]
        public void Returns_sum(string input, int expected)
        {
            //Arrange

            //Act
            var actual = Calculator.SumDigits(input);

            //Assert
            Assert.Equal(actual, expected);

        }
    }
}
