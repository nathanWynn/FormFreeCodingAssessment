using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    class TriangleBase : ITriangle
    {
        // Protected To be accessible in children.
        protected int a, b, c;
        
        /// <summary>
        /// Construct a triangle using three integers representing
        /// three sides.
        /// </summary>
        public TriangleBase(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Get the type of the triangle - overridden in children.
        /// </summary>
        /// <returns>String representation of triangle type</returns>
        public virtual string GetTriangleType()
        {
            return "Generic Triangle";
        }
    }
}
