using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Meta_Forma
{
    class MyTriangle : MyGraphicObject
    {
        public MyTriangle(Pen pen, Point a)
            : base(pen)
        {
            Point b = new Point(a.X - 50, a.Y + 90);
            Point c = new Point(a.X + 50, a.Y + 90);
            Point[] curvePoints = { a, b, c };
            Path.AddPolygon(curvePoints);
        }

    }
}
