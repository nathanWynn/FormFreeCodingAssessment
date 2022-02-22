using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    public class Creator
    {
        private static bool IsValidTriangle(int a, int b, int c) 
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        public ITriangle FactoryMethod(int a, int b, int c)
        {
            if(!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException($"Sides {a}, {b}, and {c} do not form a valid triangle");
            }
            if (a == b && b == c)
            {
                return new EquilateralTriangle(a, b, c);
            }
            else if ((a == b && b != c) || (a != b && a == c) || (b == c && c != a))
            {
                return new IsoscelesTriangle(a, b, c);
            }
            else if (a != b && b != c && a != c)
            {
                return new ScaleneTriangle(a, b, c);
            }
            return null;
        }
    }
}
