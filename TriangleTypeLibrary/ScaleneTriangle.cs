using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    internal class ScaleneTriangle : TriangleBase
    {
        public ScaleneTriangle(int a, int b, int c) : base(a, b, c) { }
        public override string GetTriangleType()
        {
            return "Scalene";
        }
    }
}
