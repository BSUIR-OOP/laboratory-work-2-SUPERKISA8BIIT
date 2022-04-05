using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Ellipse: Figure
    {
        public override string fileName => "ellipse.png";
        public Ellipse(int x, int y, int width, int height) : base(x, y, width, height) { }
    }
}
