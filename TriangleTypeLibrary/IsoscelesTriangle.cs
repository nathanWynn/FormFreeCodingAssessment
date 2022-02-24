using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    /// <summary>
    /// Represents an isosceles triangle.
    /// </summary>
    class IsoscelesTriangle : TriangleBase
    {
        // Call the parent constructor
        public IsoscelesTriangle(int a, int b, int c) : base(a, b, c) { }
        
        /// <summary>
        /// Get the type of the triangle.
        /// </summary>
        /// <returns>String representation of triangle type.</returns>
        public override string GetTriangleType()
        {
            return "Isosceles";
        }
    }
}
