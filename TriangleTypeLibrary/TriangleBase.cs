using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeLibrary
{
    class TriangleBase : ITriangle
    {
        public int a, b, c;
        public TriangleBase(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public virtual string GetTriangleType()
        {
            return "Generic Triangle";
        }
    }
}
