using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    /// <summary>
    /// Represents an equilateral triangle.
    /// </summary>
    class EquilateralTriangle : TriangleBase
    {
        // Call the parent constructor
        public EquilateralTriangle(int a, int b, int c) : base(a, b, c) { }
        
        /// <summary>
        /// Get the type of the triangle.
        /// </summary>
        /// <returns>String representation of triangle type.</returns>
        public override string GetTriangleType()
        {
            return "Equilateral";
        }
    }
}
