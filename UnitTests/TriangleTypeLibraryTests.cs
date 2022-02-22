using System;
using TriangleTypeLibrary;
using Xunit;

namespace UnitTests
{
    public class TriangleTypeLibraryTests
    {
        Creator c = new Creator();

        [Fact]
        public void ValidEquilateral()
        {
            string expected = "Equilateral";
            ITriangle myTriangle = c.FactoryMethod(2, 2, 2);
            string actual = myTriangle.GetTriangleType();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidIsosceles()
        {
            string expected = "Isosceles";
            ITriangle myTriangle = c.FactoryMethod(4, 4, 6);
            string actual = myTriangle.GetTriangleType();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidScalene()
        {
            string expected = "Scalene";
            ITriangle myTriangle = c.FactoryMethod(10, 11, 12);
            string actual = myTriangle.GetTriangleType();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InvalidTriangle()
        {
            ITriangle myTriangle;
            Assert.Throws<ArgumentException>(() => myTriangle = c.FactoryMethod(10, 100, 3));
        }
        [Fact]
        public void InvalidTriangleNegativeSide()
        {
            ITriangle myTriangle;
            Assert.Throws<ArgumentException>(() => myTriangle = c.FactoryMethod(4, -4, 6));
        }
        [Fact]
        public void InvalidTriangleZeroSide()
        {
            ITriangle myTriangle;
            Assert.Throws<ArgumentException>(() => myTriangle = c.FactoryMethod(0, 0, 0));
        }
    }
}