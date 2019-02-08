using ConsoleXUnitWorkshop;
using System;
using Xunit;

namespace XUnitTestProjectWorkshop
{
    public class GolfTests
    {
        [Fact]
        public void TestOverAngle()
        {
            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(90);

            Assert.False(result);
        }

        [Fact]
        public void TestUnderAngle()
        {
            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(0);

            Assert.False(result);
        }

        [Fact]
        public void TestUnderNegativAngle()
        {
            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(-0.00001);

            Assert.False(result);
        }

        [Fact]
        public void TestOverDecimalAngle()
        {
            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(90.00001);

            Assert.False(result);
        }

        [Fact]
        public void TestAngleInsideRangeCloseTo90()
        {
            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(89.99);

            Assert.True(result);
        }

        [Fact]
        public void TestAngleInsideRangeCloseToZero()
        {
            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(0.01);

            Assert.True(result);
        }

        [Fact]
        public void TestRandomAngleInsideRange()
        {
            Random rng = new Random();
            double number = rng.NextDouble() + 0.0000001 + rng.Next(0,88);

            Golf golf = new Golf();
            bool result;

            result = golf.VaildAngle(number);

            Assert.True(result);
        }

    }//class
}//namespace
