using ConsoleXUnitWorkshop;
using System;
using Xunit;

namespace XUnitTestProjectWorkshop
{
    public class CalcTests
    {
        [Fact]
        public void TestAdd2Plus2()
        {
            //Arrange
            Calc calc = new Calc();
            double result;

            //Act
            result = calc.Add(2, 2);

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestAdd2Negetiv2()
        {
            //Arrange
            Calc calc = new Calc();
            double result;

            //Act
            result = calc.Add(-2, -2);

            //Assert
            Assert.Equal(-4, result);
        }

        [Fact]
        public void TestAdd2Plus2Double()
        {
            //Arrange
            Calc calc = new Calc();
            double result;

            //Act
            result = calc.Add(2.5, 2.8);

            //Assert
            Assert.Equal(5.3, result);
        }
    }
}
