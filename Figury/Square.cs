using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Square: Figure
    {
        public override string fileName => "square.png";
        public Square(int x, int y, int width, int height) : base(x, y, width, height) { }
    }
}
