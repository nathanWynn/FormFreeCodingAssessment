using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    /// <summary>
    /// Creator class declares the factory method for returning
    /// the correct triangle object.
    /// </summary>
    public class Creator
    {
        /// <summary>
        /// Determines whether 3 integers representing sides of
        /// a triangle form a valid triangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>True if valid, false if invalid.</returns>
        private static bool IsValidTriangle(int a, int b, int c) 
        {
            // Triangle sides can not be negative
            if(a < 0 || b < 0 || c < 0)
            {
                return false;
            }
            // sum of two sides must be greater than the third
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Factory method for returning the appropriate triangle object.
        /// Usage: 
        /// <code>
        /// Creator c = new Creator();
        /// ITriangle myTriangle = c.FactoryMethod(a, b, c);
        /// </code>
        /// </summary>
        /// <exception cref="System.ArgumentException">Thrown when sides do not form a valid triangle.</exception>
        /// <returns>Appropriate triangle of type {Equilateral, Isosceles, or Scalene}</returns>
        public ITriangle FactoryMethod(int a, int b, int c)
        {
            if(!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException($"Sides {a}, {b}, and {c} do not form a valid triangle.");
            }
            if (a == b && b == c)
            {
                return new EquilateralTriangle(a, b, c);
            }
            else if ((a == b && b != c) || (a != b && a == c) || (b == c && c != a))
            {
                return new IsoscelesTriangle(a, b, c);
            }
            else
            {
                // Implicit condition: (a != b && b != c && a != c)
                return new ScaleneTriangle(a, b, c);
            }
        }
    }
}
