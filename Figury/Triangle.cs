using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Triangle: Figure
    {
        public override string fileName => "triangle.png";
        public Triangle(int x, int y, int width, int height) : base(x, y, width, height) { }
    }
}
