using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    /// <summary>
    /// Represents a scalene triangle.
    /// </summary>
    internal class ScaleneTriangle : TriangleBase
    {
        // Call the parent constructor
        public ScaleneTriangle(int a, int b, int c) : base(a, b, c) { }
        
        /// <summary>
        /// Get the type of the triangle.
        /// </summary>
        /// <returns>String representation of triangle type.</returns>
        public override string GetTriangleType()
        {
            return "Scalene";
        }
    }
}
