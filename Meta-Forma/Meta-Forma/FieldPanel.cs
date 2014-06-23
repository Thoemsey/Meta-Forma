﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        GraphicsPath _path = new GraphicsPath();
        static Pen HitTestPen = new Pen(Brushes.Black, 4);
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
            this.MouseUp += OnMouseUp;
            
        }

       

        public SpielController Controller
        {
            get { return controller; }
            set { controller = value; }
        }

        public virtual bool Hit(Point pt)
        {
            return this.Bounds.Contains(pt);
            
        }

        public virtual bool Contains(Point pt)
        {
            return _path.IsVisible(pt);
        }
        protected GraphicsPath Path
        {
            get { return _path; }
        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            

            if (controller.View.status != 0)
            {
                controller.View.versuch[key] = controller.View.status;
                controller.View.status = 0;
                bool b = true;
                for (int i = 0; i < controller.View.versuch.Length; i++)
                {
                    if (controller.View.versuch[i] == 0)
                    {
                        b = false;
                    }

                    
                    //Console.Write(controller.View.versuch[i]);
                }
                if (b)
                {
                    bool sieg = true;
                    for (int i = 0; i < controller.View.versuch.Length; i++)
                    {
                        if (controller.View.versuch[i] != controller.View.loesung[i])
                        {
                            sieg = false;
                        }
                    }
                    if (sieg)
                    {
                        MessageBox.Show("YOU WON!!");
                    }
                }
                //Console.WriteLine();
            }
            else
            {
                controller.View.versuch[key] = controller.View.status;
                for (int i = 0; i < controller.View.versuch.Length; i++)
                {
                    //Console.Write(controller.View.versuch[i]);
                }
                //Console.WriteLine();

            }
            
        }
    }
}
