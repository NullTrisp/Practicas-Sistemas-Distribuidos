using System;
using Xunit;
using FluentAssertions;
using CalC;

namespace CalcTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("2", "3", "5")]
        [InlineData("5", "5", "10")]
        [InlineData("12", "8", "20")]
        [InlineData("-5", "10", "5")]
        [InlineData("200", "32.5", "232.5")]
        public void TestSum(string a, string b, string actual)
        {
            actual.Should().Be(Calculator.Sum(a, b));
        }

        [Theory]
        [InlineData("2_", "3")]
        [InlineData("2", "3/")]
        [InlineData("2", "3-")]
        [InlineData("-2", "3-")]
        [InlineData("-2-", "3-")]
        [InlineData("-2+", "3")]
        public void TestSumFail(string a, string b)
        {
            Action act = () => Calculator.Sum(a, b);
            act.Should().Throw<Exception>();
        }

        [Theory]
        [InlineData("2", "3", "5")]
        [InlineData("5", "5", "10")]
        [InlineData("12", "8", "20")]
        [InlineData("-5", "10", "5")]
        [InlineData("200", "32.5", "232.5")]
        public void TestMultiply(string a, string b, string actual)
        {
            actual.Should().Be(Calculator.Mult(a, b));
        }

        [Theory]
        [InlineData("2_", "3")]
        [InlineData("2", "3/")]
        [InlineData("2", "3-")]
        [InlineData("-2", "3-")]
        [InlineData("-2-", "3-")]
        [InlineData("-2+", "3")]
        public void TestMultiplyFail(string a, string b)
        {
            Action act = () => Calculator.Mult(a, b);
            act.Should().Throw<Exception>();
        }
    }
}
