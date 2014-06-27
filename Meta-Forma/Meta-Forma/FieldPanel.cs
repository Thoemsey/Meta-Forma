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
    public class FieldPanel : Panel
    {
        private int key;
        private Point position;
        private SpielController controller;
        GraphicsPath _path = new GraphicsPath();
        static Pen HitTestPen = new Pen(Brushes.Black, 4);
        private DrawPanel drawPanel;
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

        public DrawPanel DrawPanel
        {
            set { drawPanel = value; }
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
            
            //Wenn auf einem Spielfeld Mouseup ausgeführt wird,  wird überprüft ob auf diesem Feld ein Stein liegt
            
            if (controller.View.status != 0)
            {
                //wenn ein Stein darauf liegt, wird dieser wieder zurück gesetzt und die Variable um diesen Wert gekürzt
                //wenn man gleichzeitig einen Stein bewegt hat, wird dieser in das Feld gespeichert
                feldLoeschen();
                controller.View.versuch[key] = controller.View.status;
                controller.View.status = 0;
                bool b = true;
                for (int i = 0; i < controller.View.versuch.Length; i++)
                {
                    //es wird überprüft ob in jedem Feld ein Stein liegt
                    if (controller.View.versuch[i] == 0)
                    {
                        b = false;
                    }

                    
                    
                }
                if (b)
                {
                    //Wenn in jedem Feld ein Stein Liegt wird überprüft ob jeder Stein an dem der lösung entsprechenden
                    //Platz liegt
                    bool sieg = true;
                    for (int i = 0; i < controller.View.versuch.Length; i++)
                    {
                        //Wenn ein Stein an der Falschen Position liegt, wird die variable auf false gesetzt
                        if (controller.View.versuch[i] != controller.View.loesung[i])
                        {
                            sieg = false;
                        }
                        
                    }
                    if (sieg)
                    {
                        //Falls alle Steine richtig liegen, wird das Label mit You won beschriftet und erhält
                        //einen grünen Rahmen
                        controller.View.lblWinLoseChange("You won!", Color.LightGreen);
                    }
                    else if (!sieg)
                    {
                        //andernfalls wird It's wrong ausgegeben und das Label erhält einen roten Hintergrund
                        controller.View.lblWinLoseChange("It's wrong!", Color.Red);
                    }
                    
                }
                else
                {
                    //Wenn auf irgend einem Spielfeld noch kein Stein liegt, steht auf dem label
                    //playing.. und der Hintergrund bleibt weiss (unsichtbar)
                    controller.View.lblWinLoseChange("playing...", Color.White);
                }
            }
            else
            {
                //Wenn alle Steine gelegt sind und einer wieder gelöscht wird, steht auf dem label
                //wieder playing.. und der Hintergrund wird wieder weiss (unsichtbar)
                
                controller.View.lblWinLoseChange("playing...", Color.White);
                feldLoeschen();

            }
            
        }

        public void feldLoeschen()
        {
            //diese Funktion löscht den Wert des Spielsteines aus dem Spielfeld und setzt seine Postition
            //wieder auf seine Startposition zurück
            if (controller.View.versuch[key] != 0)
            {
                foreach (MyGraphicObject go in drawPanel._graphicObjects)
                {
                    //hier wird überprüft, welches Objekt sich in dem Panel befindet
                    if (go.Key == controller.View.versuch[key])
                    {
                        go.Move(go.Start.X - this.position.X - 50, go.Start.Y - this.position.Y - 50);
                        drawPanel.Invalidate();
                        drawPanel.Update();
                    }
                }
                


            }
            controller.View.versuch[key] = controller.View.status;
            for (int i = 0; i < controller.View.versuch.Length; i++)
            {
                
            }
            
        }
    }
}
