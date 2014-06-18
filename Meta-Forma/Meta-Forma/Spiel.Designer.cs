﻿namespace Meta_Forma
{
    partial class Spiel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spiel));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new TablessControl();
            this.tbp_menu = new System.Windows.Forms.TabPage();
            this.cmd_beenden = new System.Windows.Forms.Button();
            this.cmd_zumSpiel = new System.Windows.Forms.Button();
            this.tbp_schwierigkeit = new System.Windows.Forms.TabPage();
            this.cmd_zurueckhptm = new System.Windows.Forms.Button();
            this.txt_leicht = new System.Windows.Forms.TextBox();
            this.txt_schwierig = new System.Windows.Forms.TextBox();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.pnl_ampel = new System.Windows.Forms.Panel();
            this.pic_rot = new System.Windows.Forms.PictureBox();
            this.pic_blau = new System.Windows.Forms.PictureBox();
            this.pic_violett = new System.Windows.Forms.PictureBox();
            this.pic_gruen = new System.Windows.Forms.PictureBox();
            this.pic_orange = new System.Windows.Forms.PictureBox();
            this.pic_gelb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbp_level = new System.Windows.Forms.TabPage();
            this.cmd_lvl2 = new System.Windows.Forms.Button();
            this.cmd_zurueckschwkt = new System.Windows.Forms.Button();
            this.cmd_lvl1 = new System.Windows.Forms.Button();
            this.tbp_spielfeld = new System.Windows.Forms.TabPage();
            this.pic_spielfeld = new System.Windows.Forms.PictureBox();
            this.cmd_zuruecklvl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_regeln = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tbp_menu.SuspendLayout();
            this.tbp_schwierigkeit.SuspendLayout();
            this.pnl_ampel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_blau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_violett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gelb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbp_level.SuspendLayout();
            this.tbp_spielfeld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_spielfeld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regeln)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbp_menu);
            this.tabControl.Controls.Add(this.tbp_schwierigkeit);
            this.tabControl.Controls.Add(this.tbp_level);
            this.tabControl.Controls.Add(this.tbp_spielfeld);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 723);
            this.tabControl.TabIndex = 0;
            // 
            // tbp_menu
            // 
            this.tbp_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbp_menu.Controls.Add(this.textBox1);
            this.tbp_menu.Controls.Add(this.cmd_beenden);
            this.tbp_menu.Controls.Add(this.cmd_zumSpiel);
            this.tbp_menu.Location = new System.Drawing.Point(4, 25);
            this.tbp_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_menu.Name = "tbp_menu";
            this.tbp_menu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_menu.Size = new System.Drawing.Size(998, 694);
            this.tbp_menu.TabIndex = 0;
            this.tbp_menu.Text = "tbp_menu";
            this.tbp_menu.UseVisualStyleBackColor = true;
            // 
            // cmd_beenden
            // 
            this.cmd_beenden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_beenden.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_beenden.FlatAppearance.BorderSize = 5;
            this.cmd_beenden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_beenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_beenden.Location = new System.Drawing.Point(143, 475);
            this.cmd_beenden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_beenden.Name = "cmd_beenden";
            this.cmd_beenden.Size = new System.Drawing.Size(665, 100);
            this.cmd_beenden.TabIndex = 1;
            this.cmd_beenden.Text = "Beenden";
            this.cmd_beenden.UseVisualStyleBackColor = false;
            this.cmd_beenden.Click += new System.EventHandler(this.cmd_beenden_Click);
            // 
            // cmd_zumSpiel
            // 
            this.cmd_zumSpiel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_zumSpiel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_zumSpiel.FlatAppearance.BorderSize = 5;
            this.cmd_zumSpiel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_zumSpiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_zumSpiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_zumSpiel.Location = new System.Drawing.Point(143, 348);
            this.cmd_zumSpiel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_zumSpiel.Name = "cmd_zumSpiel";
            this.cmd_zumSpiel.Size = new System.Drawing.Size(665, 100);
            this.cmd_zumSpiel.TabIndex = 0;
            this.cmd_zumSpiel.Text = "zum Spiel";
            this.cmd_zumSpiel.UseVisualStyleBackColor = false;
            this.cmd_zumSpiel.Click += new System.EventHandler(this.cmd_zumSpiel_Click);
            // 
            // tbp_schwierigkeit
            // 
            this.tbp_schwierigkeit.Controls.Add(this.cmd_zurueckhptm);
            this.tbp_schwierigkeit.Controls.Add(this.txt_leicht);
            this.tbp_schwierigkeit.Controls.Add(this.txt_schwierig);
            this.tbp_schwierigkeit.Controls.Add(this.txt_info);
            this.tbp_schwierigkeit.Controls.Add(this.pnl_ampel);
            this.tbp_schwierigkeit.Controls.Add(this.pictureBox1);
            this.tbp_schwierigkeit.Location = new System.Drawing.Point(4, 25);
            this.tbp_schwierigkeit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_schwierigkeit.Name = "tbp_schwierigkeit";
            this.tbp_schwierigkeit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_schwierigkeit.Size = new System.Drawing.Size(998, 694);
            this.tbp_schwierigkeit.TabIndex = 1;
            this.tbp_schwierigkeit.Text = "tbp_schwierigkeit";
            this.tbp_schwierigkeit.UseVisualStyleBackColor = true;
            // 
            // cmd_zurueckhptm
            // 
            this.cmd_zurueckhptm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_zurueckhptm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_zurueckhptm.FlatAppearance.BorderSize = 2;
            this.cmd_zurueckhptm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_zurueckhptm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_zurueckhptm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_zurueckhptm.Location = new System.Drawing.Point(91, 545);
            this.cmd_zurueckhptm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_zurueckhptm.Name = "cmd_zurueckhptm";
            this.cmd_zurueckhptm.Size = new System.Drawing.Size(409, 100);
            this.cmd_zurueckhptm.TabIndex = 5;
            this.cmd_zurueckhptm.Text = "zurück";
            this.cmd_zurueckhptm.UseVisualStyleBackColor = false;
            this.cmd_zurueckhptm.Click += new System.EventHandler(this.cmd_zurueckhptm_Click);
            // 
            // txt_leicht
            // 
            this.txt_leicht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_leicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leicht.HideSelection = false;
            this.txt_leicht.Location = new System.Drawing.Point(572, 654);
            this.txt_leicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_leicht.Name = "txt_leicht";
            this.txt_leicht.Size = new System.Drawing.Size(73, 31);
            this.txt_leicht.TabIndex = 3;
            this.txt_leicht.TabStop = false;
            this.txt_leicht.Text = "leicht";
            // 
            // txt_schwierig
            // 
            this.txt_schwierig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_schwierig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schwierig.HideSelection = false;
            this.txt_schwierig.Location = new System.Drawing.Point(543, 50);
            this.txt_schwierig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_schwierig.Name = "txt_schwierig";
            this.txt_schwierig.Size = new System.Drawing.Size(133, 31);
            this.txt_schwierig.TabIndex = 2;
            this.txt_schwierig.TabStop = false;
            this.txt_schwierig.Text = "schwierig";
            // 
            // txt_info
            // 
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.HideSelection = false;
            this.txt_info.Location = new System.Drawing.Point(91, 242);
            this.txt_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(409, 31);
            this.txt_info.TabIndex = 1;
            this.txt_info.TabStop = false;
            this.txt_info.Text = "Wähle deinen Schwierigkeitsgrad";
            // 
            // pnl_ampel
            // 
            this.pnl_ampel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ampel.Controls.Add(this.pic_rot);
            this.pnl_ampel.Controls.Add(this.pic_blau);
            this.pnl_ampel.Controls.Add(this.pic_violett);
            this.pnl_ampel.Controls.Add(this.pic_gruen);
            this.pnl_ampel.Controls.Add(this.pic_orange);
            this.pnl_ampel.Controls.Add(this.pic_gelb);
            this.pnl_ampel.Location = new System.Drawing.Point(683, 2);
            this.pnl_ampel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_ampel.Name = "pnl_ampel";
            this.pnl_ampel.Size = new System.Drawing.Size(157, 715);
            this.pnl_ampel.TabIndex = 0;
            // 
            // pic_rot
            // 
            this.pic_rot.Image = ((System.Drawing.Image)(resources.GetObject("pic_rot.Image")));
            this.pic_rot.Location = new System.Drawing.Point(16, 0);
            this.pic_rot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_rot.Name = "pic_rot";
            this.pic_rot.Size = new System.Drawing.Size(120, 121);
            this.pic_rot.TabIndex = 1;
            this.pic_rot.TabStop = false;
            this.pic_rot.Click += new System.EventHandler(this.pic_rot_Click);
            // 
            // pic_blau
            // 
            this.pic_blau.Image = ((System.Drawing.Image)(resources.GetObject("pic_blau.Image")));
            this.pic_blau.Location = new System.Drawing.Point(16, 238);
            this.pic_blau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_blau.Name = "pic_blau";
            this.pic_blau.Size = new System.Drawing.Size(120, 121);
            this.pic_blau.TabIndex = 1;
            this.pic_blau.TabStop = false;
            // 
            // pic_violett
            // 
            this.pic_violett.Image = ((System.Drawing.Image)(resources.GetObject("pic_violett.Image")));
            this.pic_violett.Location = new System.Drawing.Point(16, 119);
            this.pic_violett.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_violett.Name = "pic_violett";
            this.pic_violett.Size = new System.Drawing.Size(120, 121);
            this.pic_violett.TabIndex = 1;
            this.pic_violett.TabStop = false;
            // 
            // pic_gruen
            // 
            this.pic_gruen.Image = ((System.Drawing.Image)(resources.GetObject("pic_gruen.Image")));
            this.pic_gruen.Location = new System.Drawing.Point(16, 357);
            this.pic_gruen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_gruen.Name = "pic_gruen";
            this.pic_gruen.Size = new System.Drawing.Size(120, 121);
            this.pic_gruen.TabIndex = 1;
            this.pic_gruen.TabStop = false;
            // 
            // pic_orange
            // 
            this.pic_orange.BackColor = System.Drawing.Color.Transparent;
            this.pic_orange.Image = ((System.Drawing.Image)(resources.GetObject("pic_orange.Image")));
            this.pic_orange.Location = new System.Drawing.Point(16, 476);
            this.pic_orange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_orange.Name = "pic_orange";
            this.pic_orange.Size = new System.Drawing.Size(120, 121);
            this.pic_orange.TabIndex = 1;
            this.pic_orange.TabStop = false;
            // 
            // pic_gelb
            // 
            this.pic_gelb.Image = ((System.Drawing.Image)(resources.GetObject("pic_gelb.Image")));
            this.pic_gelb.Location = new System.Drawing.Point(16, 594);
            this.pic_gelb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_gelb.Name = "pic_gelb";
            this.pic_gelb.Size = new System.Drawing.Size(120, 121);
            this.pic_gelb.TabIndex = 0;
            this.pic_gelb.TabStop = false;
            this.pic_gelb.Click += new System.EventHandler(this.pic_gelb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meta_Forma.Properties.Resources.pfeil;
            this.pictureBox1.Location = new System.Drawing.Point(587, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 550);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbp_level
            // 
            this.tbp_level.Controls.Add(this.cmd_lvl2);
            this.tbp_level.Controls.Add(this.cmd_zurueckschwkt);
            this.tbp_level.Controls.Add(this.cmd_lvl1);
            this.tbp_level.Location = new System.Drawing.Point(4, 25);
            this.tbp_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_level.Name = "tbp_level";
            this.tbp_level.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_level.Size = new System.Drawing.Size(998, 694);
            this.tbp_level.TabIndex = 2;
            this.tbp_level.Text = "tbp_level";
            this.tbp_level.UseVisualStyleBackColor = true;
            // 
            // cmd_lvl2
            // 
            this.cmd_lvl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_lvl2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_lvl2.FlatAppearance.BorderSize = 10;
            this.cmd_lvl2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_lvl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_lvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_lvl2.Location = new System.Drawing.Point(507, 34);
            this.cmd_lvl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_lvl2.Name = "cmd_lvl2";
            this.cmd_lvl2.Size = new System.Drawing.Size(452, 482);
            this.cmd_lvl2.TabIndex = 7;
            this.cmd_lvl2.Text = "000";
            this.cmd_lvl2.UseVisualStyleBackColor = false;
            // 
            // cmd_zurueckschwkt
            // 
            this.cmd_zurueckschwkt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_zurueckschwkt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_zurueckschwkt.FlatAppearance.BorderSize = 2;
            this.cmd_zurueckschwkt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_zurueckschwkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_zurueckschwkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_zurueckschwkt.Location = new System.Drawing.Point(299, 561);
            this.cmd_zurueckschwkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_zurueckschwkt.Name = "cmd_zurueckschwkt";
            this.cmd_zurueckschwkt.Size = new System.Drawing.Size(409, 100);
            this.cmd_zurueckschwkt.TabIndex = 6;
            this.cmd_zurueckschwkt.Text = "zurück";
            this.cmd_zurueckschwkt.UseVisualStyleBackColor = false;
            this.cmd_zurueckschwkt.Click += new System.EventHandler(this.cmd_zurueckschwkt_Click);
            // 
            // cmd_lvl1
            // 
            this.cmd_lvl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_lvl1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_lvl1.FlatAppearance.BorderSize = 10;
            this.cmd_lvl1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_lvl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_lvl1.Location = new System.Drawing.Point(37, 34);
            this.cmd_lvl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_lvl1.Name = "cmd_lvl1";
            this.cmd_lvl1.Size = new System.Drawing.Size(452, 482);
            this.cmd_lvl1.TabIndex = 1;
            this.cmd_lvl1.Text = "000";
            this.cmd_lvl1.UseVisualStyleBackColor = false;
            this.cmd_lvl1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbp_spielfeld
            // 
            this.tbp_spielfeld.Controls.Add(this.pic_spielfeld);
            this.tbp_spielfeld.Controls.Add(this.cmd_zuruecklvl);
            this.tbp_spielfeld.Controls.Add(this.panel1);
            this.tbp_spielfeld.Controls.Add(this.pic_regeln);
            this.tbp_spielfeld.Location = new System.Drawing.Point(4, 25);
            this.tbp_spielfeld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_spielfeld.Name = "tbp_spielfeld";
            this.tbp_spielfeld.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbp_spielfeld.Size = new System.Drawing.Size(998, 694);
            this.tbp_spielfeld.TabIndex = 3;
            this.tbp_spielfeld.Text = "tbp_spielfeld";
            this.tbp_spielfeld.UseVisualStyleBackColor = true;
            // 
            // pic_spielfeld
            // 
            this.pic_spielfeld.Image = global::Meta_Forma.Properties.Resources.spielfeld;
            this.pic_spielfeld.Location = new System.Drawing.Point(499, 14);
            this.pic_spielfeld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_spielfeld.Name = "pic_spielfeld";
            this.pic_spielfeld.Size = new System.Drawing.Size(475, 475);
            this.pic_spielfeld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_spielfeld.TabIndex = 8;
            this.pic_spielfeld.TabStop = false;
            // 
            // cmd_zuruecklvl
            // 
            this.cmd_zuruecklvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(201)))), ((int)(((byte)(230)))));
            this.cmd_zuruecklvl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cmd_zuruecklvl.FlatAppearance.BorderSize = 2;
            this.cmd_zuruecklvl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmd_zuruecklvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_zuruecklvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_zuruecklvl.Location = new System.Drawing.Point(3, 652);
            this.cmd_zuruecklvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_zuruecklvl.Name = "cmd_zuruecklvl";
            this.cmd_zuruecklvl.Size = new System.Drawing.Size(305, 63);
            this.cmd_zuruecklvl.TabIndex = 7;
            this.cmd_zuruecklvl.Text = "zurück";
            this.cmd_zuruecklvl.UseVisualStyleBackColor = false;
            this.cmd_zuruecklvl.Click += new System.EventHandler(this.cmd_zuruecklvl_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 153);
            this.panel1.TabIndex = 1;
            // 
            // pic_regeln
            // 
            this.pic_regeln.Image = global::Meta_Forma.Properties.Resources.gelb1;
            this.pic_regeln.Location = new System.Drawing.Point(3, 14);
            this.pic_regeln.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_regeln.Name = "pic_regeln";
            this.pic_regeln.Size = new System.Drawing.Size(475, 475);
            this.pic_regeln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_regeln.TabIndex = 0;
            this.pic_regeln.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Spiel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Spiel";
            this.Text = "Spielfeld";
            this.tabControl.ResumeLayout(false);
            this.tbp_menu.ResumeLayout(false);
            this.tbp_menu.PerformLayout();
            this.tbp_schwierigkeit.ResumeLayout(false);
            this.tbp_schwierigkeit.PerformLayout();
            this.pnl_ampel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_rot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_blau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_violett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gruen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gelb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbp_level.ResumeLayout(false);
            this.tbp_spielfeld.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_spielfeld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regeln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private TablessControl tabControl;
        private System.Windows.Forms.TabPage tbp_menu;
        private System.Windows.Forms.TabPage tbp_schwierigkeit;
        private System.Windows.Forms.TabPage tbp_level;
        private System.Windows.Forms.TabPage tbp_spielfeld;
        private System.Windows.Forms.Button cmd_beenden;
        private System.Windows.Forms.Button cmd_zumSpiel;
        private System.Windows.Forms.Panel pnl_ampel;
        private System.Windows.Forms.PictureBox pic_gelb;
        private System.Windows.Forms.PictureBox pic_rot;
        private System.Windows.Forms.PictureBox pic_violett;
        private System.Windows.Forms.PictureBox pic_blau;
        private System.Windows.Forms.PictureBox pic_gruen;
        private System.Windows.Forms.PictureBox pic_orange;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.TextBox txt_schwierig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_leicht;
        private System.Windows.Forms.Button cmd_lvl1;
        private System.Windows.Forms.Button cmd_zurueckhptm;
        private System.Windows.Forms.Button cmd_zurueckschwkt;
        private System.Windows.Forms.Button cmd_lvl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_regeln;
        private System.Windows.Forms.Button cmd_zuruecklvl;
        private System.Windows.Forms.PictureBox pic_spielfeld;
        private System.Windows.Forms.TextBox textBox1;
    }
}