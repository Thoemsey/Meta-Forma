using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Meta_Forma
{
    class MyCircle : MyGraphicObject
    {
        //Zeichnet einen kreis
        public MyCircle(Pen pen, Point top, int key)
            : base(pen,top,key)
        {
            int radius = 50;
            Point center = new Point(top.X, top.Y + radius);
            Path.AddEllipse(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }
        

        
    }
}
