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
        private List<int> lvl;
        public int[] loesung = new int[9];
        public int[] versuch = new int[] {0,0,0,0,0,0,0,0,0 };
        public int status = 0;
        public Spiel()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
        
        public void dp1SetController(SpielController cont)
        {
            this.drawPanel1.Controller = cont;

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
            this.drawPanel1.Controller = controller;
            this.drawPanel1.setFPController();
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
            setLvlText(1);
            tabControl.SelectedTab = tbp_level;
        }



        private void pic_rot_Click(object sender, EventArgs e)
        {
            setLvlText(6);
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

        private void cmd_lvl1_Click(object sender, EventArgs e)
        {
            setLvl(lvl[0]);
            setLoesung(lvl[0]);
            tabControl.SelectedTab = tbp_spielfeld;
            pic_regeln.SendToBack();
        }

        private void cmd_lvl2_Click(object sender, EventArgs e)
        {
            setLvl(lvl[1]);
            setLoesung(lvl[1]);
            tabControl.SelectedTab = tbp_spielfeld;
        }

        private void cmd_zuruecklvl_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_level;
            pic_regeln.Image = Properties.Resources.loading;
            controller.View.drawPanel1.removeGraphicObjects();
            controller.View.drawPanel1.setGraphicObjects();

            for (int i = 0; i < versuch.Length; i++)
            {
                versuch[i] = 0;
            }
        }

        private void pic_violett_Click(object sender, EventArgs e)
        {
            setLvlText(5);
            tabControl.SelectedTab = tbp_level;
        }

        private void pic_blau_Click(object sender, EventArgs e)
        {
            setLvlText(4);
            tabControl.SelectedTab = tbp_level;
        }

        private void pic_gruen_Click(object sender, EventArgs e)
        {
            setLvlText(3);
            tabControl.SelectedTab = tbp_level;
        }

        private void pic_orange_Click(object sender, EventArgs e)
        {
            setLvlText(2);
            tabControl.SelectedTab = tbp_level;
        }




        private void setLvl(int levelId)
        {
            String rules = Controller.DB.getRulesById(levelId);

            pic_regeln.ImageLocation = Application.StartupPath+"\\..\\..\\Resources\\Spielfeld\\"+rules+".jpg";
        }


        private void setLvlText(int diffId)
        {
            lvl = Controller.DB.getLvlByDifficulty(diffId);
            cmd_lvl1.Text = lvl[0].ToString();
            cmd_lvl2.Text = lvl[1].ToString();
        }

        private void setLoesung(int lvlId)
        {
            String sol = Controller.DB.getLoesungById(lvlId);
            for (int i = 0; i < sol.Length; i++)
            {
                char temp = sol.ElementAt(i);
                loesung[i] = (int)Char.GetNumericValue(temp);
                
            }
            

        }

        
        private void Spiel_Closing(object sender, FormClosingEventArgs e)
        {
            //Handle event here
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
