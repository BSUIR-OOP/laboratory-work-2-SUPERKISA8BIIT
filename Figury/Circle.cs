using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Circle: Figure
    {
        public override string fileName => "circle.png";
        public Circle(int x, int y, int width, int height) : base(x, y, width, height) { }
        public static Figure CircleDelegate(int x, int y) => new Circle(x, y, 200, 200);       
    }
}
