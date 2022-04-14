using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Line: Figure
    {
        public override string fileName => "line.png";
        public Line(int x, int y, int width, int height) : base(x, y, width, height) { }
        public static Figure LineDelegate(int x, int y) => new Line(x, y, 300, 150);
    }
}
