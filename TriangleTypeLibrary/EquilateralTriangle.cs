using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    class EquilateralTriangle : TriangleBase
    {
        public EquilateralTriangle(int a, int b, int c) : base(a, b, c) { }
        public override string GetTriangleType()
        {
            return "Equilateral";
        }
    }
}
