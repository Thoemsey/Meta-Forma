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
        public MyRectangle(Pen pen, Point a, int key)
            : base(pen,a,key)
        {
            int widthNheight = 100;
            Rectangle rect = new Rectangle(a.X - (widthNheight / 2), a.Y, widthNheight, widthNheight);
            Path.AddRectangle(rect);
        }
        

    }

}
