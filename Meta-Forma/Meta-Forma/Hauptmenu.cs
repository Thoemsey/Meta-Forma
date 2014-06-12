using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meta_Forma
{
    public partial class Hauptmenu : Form
    {
        public Hauptmenu()
        {
            InitializeComponent();
        }

        private void cmd_zumSpiel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Schwierigkeitsauswahl s = new Schwierigkeitsauswahl();
            s.getForm = this;
            this.Hide();
            s.ShowDialog();
        }

        private void cmd_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
