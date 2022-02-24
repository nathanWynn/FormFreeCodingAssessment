using System;
using TriangleTypeLibrary;
using Xunit;

namespace UnitTests
{
    public class TriangleTypeLibraryTests
    {
        Creator c = new Creator();

        [Fact]
        public void ValidEquilateralTest()
        {
            string expected = "Equilateral";
            ITriangle myTriangle = c.FactoryMethod(2, 2, 2);
            string actual = myTriangle.GetTriangleType();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidIsoscelesTest()
        {
            string expected = "Isosceles";
            ITriangle myTriangle = c.FactoryMethod(4, 4, 6);
            string actual = myTriangle.GetTriangleType();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidScaleneTest()
        {
            string expected = "Scalene";
            ITriangle myTriangle = c.FactoryMethod(10, 11, 12);
            string actual = myTriangle.GetTriangleType();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InvalidTriangleTest()
        {
            ITriangle myTriangle;
            Assert.Throws<ArgumentException>(() => myTriangle = c.FactoryMethod(10, 100, 3));
        }
        [Fact]
        public void InvalidTriangleNegativeSideTest()
        {
            ITriangle myTriangle;
            Assert.Throws<ArgumentException>(() => myTriangle = c.FactoryMethod(4, -4, 6));
        }
        [Fact]
        public void InvalidTriangleZeroSideTest()
        {
            ITriangle myTriangle;
            Assert.Throws<ArgumentException>(() => myTriangle = c.FactoryMethod(0, 0, 0));
        }
    }
}