using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Rhombus: Figure
    {
        public override string fileName => "rhombus.png";
        public Rhombus(int x, int y, int width, int height) : base(x, y, width, height) { }
        public static Figure RhombusDelegate(int x, int y) => new Rhombus(x, y, 300, 150);
    }
}
