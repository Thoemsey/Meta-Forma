using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meta_Forma
{
    public partial class Spiel : Form
    {
        private SpielController controller;

        public Spiel()
        {
            InitializeComponent();

            pic_gelb.MouseEnter += new System.EventHandler(this.pic_gelb_MouseEnter);
            pic_gelb.MouseLeave += new System.EventHandler(this.pic_gelb_MouseLeave);
            pic_orange.MouseEnter += new System.EventHandler(this.pic_orange_MouseEnter);
            pic_orange.MouseLeave += new System.EventHandler(this.pic_orange_MouseLeave);
            pic_gruen.MouseEnter += new System.EventHandler(this.pic_gruen_MouseEnter);
            pic_gruen.MouseLeave += new System.EventHandler(this.pic_gruen_MouseLeave);
            pic_blau.MouseEnter += new System.EventHandler(this.pic_blau_MouseEnter);
            pic_blau.MouseLeave += new System.EventHandler(this.pic_blau_MouseLeave);
            pic_violett.MouseEnter += new System.EventHandler(this.pic_violett_MouseEnter);
            pic_violett.MouseLeave += new System.EventHandler(this.pic_violett_MouseLeave);
            pic_rot.MouseEnter += new System.EventHandler(this.pic_rot_MouseEnter);
            pic_rot.MouseLeave += new System.EventHandler(this.pic_rot_MouseLeave);
        }
        
        public SpielController Controller
        {
            get { return controller; }
            set { controller = value; }
        }
        

        private void cmd_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cmd_zumSpiel_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_schwierigkeit;
        }

        private void pic_gelb_MouseEnter(object sender, EventArgs e)
        {
            pic_gelb.Image = Properties.Resources.gelbHover;
        }
        private void pic_gelb_MouseLeave(object sender, EventArgs e)
        {
            pic_gelb.Image = Properties.Resources.gelb;
        }
        private void pic_orange_MouseEnter(object sender, EventArgs e)
        {
            pic_orange.Image = Properties.Resources.orangeHover;
        }
        private void pic_orange_MouseLeave(object sender, EventArgs e)
        {
            pic_orange.Image = Properties.Resources.orange;
        }
        private void pic_gruen_MouseEnter(object sender, EventArgs e)
        {
            pic_gruen.Image = Properties.Resources.gruenHover;
        }
        private void pic_gruen_MouseLeave(object sender, EventArgs e)
        {
            pic_gruen.Image = Properties.Resources.gruen;
        }
        private void pic_blau_MouseEnter(object sender, EventArgs e)
        {
            pic_blau.Image = Properties.Resources.blauHover;
        }
        private void pic_blau_MouseLeave(object sender, EventArgs e)
        {
            pic_blau.Image = Properties.Resources.blau;
        }
        private void pic_violett_MouseEnter(object sender, EventArgs e)
        {
            pic_violett.Image = Properties.Resources.violettHover;
        }
        private void pic_violett_MouseLeave(object sender, EventArgs e)
        {
            pic_violett.Image = Properties.Resources.violett;
        }
        private void pic_rot_MouseEnter(object sender, EventArgs e)
        {
            pic_rot.Image = Properties.Resources.rotHover;
        }
        private void pic_rot_MouseLeave(object sender, EventArgs e)
        {
            pic_rot.Image = Properties.Resources.rot;
        }

        private void pic_gelb_Click(object sender, EventArgs e)
        {

        }



        private void pic_rot_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_level;
        }

        private void cmd_zurueckhptm_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_menu;
        }

        private void cmd_zurueckschwkt_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_schwierigkeit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_spielfeld;
        }

        private void cmd_zuruecklvl_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_level;
        }


        //Tets Bdrag&Drop button1

        private void test_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            test.DoDragDrop(test, DragDropEffects.Move);
        }






    }
}
