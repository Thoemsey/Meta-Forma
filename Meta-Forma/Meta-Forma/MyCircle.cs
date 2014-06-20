using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Meta_Forma
{
    class MyCircle : MyGraphicObject
    {
        private int key;
        public MyCircle(Pen pen, Point top, int key)
            : base(pen)
        {
            this.key = key;
            int radius = 50;
            Point center = new Point(top.X, top.Y + radius);
            Path.AddEllipse(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }
        public int Key
        {
            get { return key; }
        }
    }
}
