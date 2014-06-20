using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Meta_Forma
{
    public abstract class MyGraphicObject
    {
        /// <summary>
        /// Dieses Pen-Objekt wird verwendet um zu überprüfen, ob ein
        /// Punkt über der Linie des Objekts liegt. Die Farbe ist
        /// hierfür irrelevant. Als Breite hat sich 4 als sinnvoll erwiesen.
        /// </summary>
        static Pen HitTestPen = new Pen(Brushes.Black, 4);
        Pen _pen;
        bool _bVisible = true;
        GraphicsPath _path = new GraphicsPath();

        public MyGraphicObject(Pen pen)
        {
            _pen = pen;
        }

        protected GraphicsPath Path
        {
            get { return _path; }
        }

        public Pen Pen
        {
            get { return _pen; }
        }

        public bool Visible
        {
            get { return _bVisible; }
            set { _bVisible = value; }
        }

        /// <summary>
        /// Befindet sich der angegebene Punkt über der Linie des Objekts?
        /// </summary>
        public virtual bool Hit(Point pt)
        {
            return Contains(pt) || _path.IsOutlineVisible(pt, HitTestPen);
        }

        /// <summary>
        /// Befindet sich der angegebene Punkt innerhalb des Objekts?
        /// </summary>
        public virtual bool Contains(Point pt)
        {
            return _path.IsVisible(pt);
        }

        public virtual void Draw(Graphics g)
        {
            g.FillPath(Pen.Brush, Path);
        }

        /// <summary>
        /// Bewegt das Objekt um deltaX in x-Richtung und deltaY in y-Richtung.
        /// </summary>
        public virtual void Move(int deltaX, int deltaY)
        {
            Matrix mat = new Matrix();
            mat.Translate(deltaX, deltaY);
            _path.Transform(mat);
        }
    }
}
