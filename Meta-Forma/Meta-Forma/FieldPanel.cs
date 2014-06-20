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
        private SpielController controller;
        public FieldPanel(int key, Point position)
        {  
            this.key = key;
            this.position = position;
            this.Location = position;
            this.Width = 146;
            this.Height = 146;
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.Transparent;
            this.Visible = true;
            this.DoubleBuffered = true;
        }

        public SpielController Controller
        {
            get { return controller; }
            set { controller = value; }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (controller.View.status != 0)
            {
                controller.View.versuch[key] = controller.View.status;
                controller.View.status = 0;
                for (int i = 0; i < controller.View.versuch.Length; i++)
                {
                    Console.WriteLine(controller.View.versuch[i]);
                }
            }
            else
            {
                controller.View.versuch[key] = controller.View.status;
                for (int i = 0; i < controller.View.versuch.Length; i++)
                {
                    Console.WriteLine(controller.View.versuch[i]);
                }
            }
        }
    }
}
