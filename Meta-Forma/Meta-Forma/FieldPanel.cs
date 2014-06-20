using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meta_Forma
{
    public class FieldPanel : Panel
    {
        private int key;
        private Point position;
        public FieldPanel(int key, Point position)
        {
            this.key = key;
            this.position = position;
            this.Location = position;
            this.Width = 146;
            this.Height = 146;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Transparent;
            this.Visible = true;
        }
    }
}
