﻿using System;
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
    public partial class Spielfeld : Form
    {
        public Spielfeld()
        {
            InitializeComponent();

            
        }

        private void cmd_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_zumSpiel_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbp_schwierigkeit;
        }


    }
}
