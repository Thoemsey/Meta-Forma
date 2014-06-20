using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meta_Forma
{
    public class DrawPanel : Panel
    {
        List<MyGraphicObject> _graphicObjects = new List<MyGraphicObject>();
        Rectangle _canvas;

        public DrawPanel()
        {
            this.DoubleBuffered = true;
            Pen penGelb = new Pen(Color.Yellow, 1);
            Pen penRot = new Pen(Color.Red, 1);
            Pen penBlau = new Pen(Color.Blue, 1);
            MyTriangle tg = new MyTriangle(penGelb, new Point(50, 510), 4);
            MyTriangle tr = new MyTriangle(penRot, new Point(380, 510), 7);
            MyTriangle tb = new MyTriangle(penBlau, new Point(710, 510),1);
            MyRectangle rg = new MyRectangle(penGelb, new Point(160, 510),6);
            MyRectangle rr = new MyRectangle(penRot, new Point(490, 510),9);
            MyRectangle rb = new MyRectangle(penBlau, new Point(820, 510),3);
            MyCircle cg = new MyCircle(penGelb, new Point(270, 510),5);
            MyCircle cr = new MyCircle(penRot, new Point(600, 510),8);
            MyCircle cb = new MyCircle(penBlau, new Point(930, 510),2);
            FieldPanel p0 = new FieldPanel(0, new Point(508,30));
            FieldPanel p1 = new FieldPanel(1, new Point(654, 30));
            FieldPanel p2 = new FieldPanel(2, new Point(800, 30));
            FieldPanel p3 = new FieldPanel(3, new Point(508, 176));
            FieldPanel p4 = new FieldPanel(4, new Point(654, 176));
            FieldPanel p5 = new FieldPanel(5, new Point(800, 176));
            FieldPanel p6 = new FieldPanel(6, new Point(508, 322));
            FieldPanel p7 = new FieldPanel(7, new Point(654, 322));
            FieldPanel p8 = new FieldPanel(8, new Point(800, 322));
            this.Controls.Add(p0);
            this.Controls.Add(p1);
            this.Controls.Add(p2);
            this.Controls.Add(p3);
            this.Controls.Add(p4);
            this.Controls.Add(p5);
            this.Controls.Add(p6);
            this.Controls.Add(p7);
            this.Controls.Add(p8);
            _graphicObjects.Add(tg);
            _graphicObjects.Add(tr);
            _graphicObjects.Add(tb);
            _graphicObjects.Add(rg);
            _graphicObjects.Add(rr);
            _graphicObjects.Add(rb);
            _graphicObjects.Add(cg);
            _graphicObjects.Add(cr);
            _graphicObjects.Add(cb);
            

            this.Invalidate();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            // Der Bereich, der neugezeichnet werden soll, wird auf die Zeichenfläche
            // beschränkt, damit Objekte, die darüber hinausschauen abgeschnitten werden.
            Region clip = new Region(_canvas);
            clip.Intersect(e.Graphics.Clip);
            e.Graphics.Clip = clip;
            //e.Graphics.Clear(Color.Transparent);
            foreach (MyGraphicObject go in _graphicObjects)
            {
                go.Draw(e.Graphics);
            }

        }
        Point _lastMouseLocation;
        MyGraphicObject _movingGraphicObject;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Wenn die Maus außerhalb der Zeichenfläche gedrückt wurde, wird abgebrochen.
            if (!_canvas.Contains(e.Location)) return;
            // Anderenfalls wird die Liste mit den gezeichneten Objekten von hinten (damit
            // das oberste Objekte gefunden wird) durchgegangen und geprüft, über welchem
            // Objekt die Maus sich befindet. 
            for (int i = _graphicObjects.Count - 1; i >= 0; i--)
            {
                MyGraphicObject go = _graphicObjects[i];
                if (go.Hit(e.Location))
                {
                    _movingGraphicObject = go;
                    break;
                }
            }
            _lastMouseLocation = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_movingGraphicObject != null)
            {
                // Wenn gerade ein Objekt verschoben werden soll, wird die Differenz zur letzten
                // Mausposition ausgerechnet und das Objekt um diese verschoben.
                _movingGraphicObject.Move(e.X - _lastMouseLocation.X, e.Y - _lastMouseLocation.Y);
                _lastMouseLocation = e.Location;
                // Hier könnte man noch optimieren, indem man immer nur den Bereich
                // neuzeichnet, in dem das Objekt bewegt wurde.
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _movingGraphicObject = null;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            // Wenn sich die Größe des Fensters ändert, wird die Größe der Zeichenfläche angepasst.
            _canvas = new Rectangle(new Point(0, 0),
                new Size(this.ClientSize.Width, this.ClientSize.Height - 70));
            this.Invalidate();
        }
    }
}
