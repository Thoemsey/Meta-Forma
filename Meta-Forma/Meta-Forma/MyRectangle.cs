using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Meta_Forma
{
    class MyRectangle : MyGraphicObject
    {
        private int key;
        public MyRectangle(Pen pen, Point a, int key)
            : base(pen)
        {
            this.key = key;
            int widthNheight = 100;
            Rectangle rect = new Rectangle(a.X - (widthNheight / 2), a.Y, widthNheight, widthNheight);
            Path.AddRectangle(rect);
        }
        public int Key
        {
            get { return key; }
        }

    }

}
