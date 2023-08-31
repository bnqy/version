using CalculatorLib;

namespace CalcLibUnitTests
{
    public class CalcLibUnitTests
    {
        [Fact]
        public void TestAdd2n2()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            CalcLib calc = new();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TestAdd2n3()
        {
            // arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            CalcLib calc = new();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}