namespace Meta_Forma
{
    partial class Spielfeld
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new TablessControl();
            this.tbp_menu = new System.Windows.Forms.TabPage();
            this.cmd_beenden = new System.Windows.Forms.Button();
            this.cmd_zumSpiel = new System.Windows.Forms.Button();
            this.tbp_schwierigkeit = new System.Windows.Forms.TabPage();
            this.tbp_level = new System.Windows.Forms.TabPage();
            this.tbp_spielfeld = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tbp_menu.SuspendLayout();
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
            this.tabControl.Location = new System.Drawing.Point(3, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 723);
            this.tabControl.TabIndex = 0;
            // 
            // tbp_menu
            // 
            this.tbp_menu.Controls.Add(this.cmd_beenden);
            this.tbp_menu.Controls.Add(this.cmd_zumSpiel);
            this.tbp_menu.Location = new System.Drawing.Point(4, 25);
            this.tbp_menu.Name = "tbp_menu";
            this.tbp_menu.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_menu.Size = new System.Drawing.Size(998, 694);
            this.tbp_menu.TabIndex = 0;
            this.tbp_menu.Text = "tbp_menu";
            this.tbp_menu.UseVisualStyleBackColor = true;
            // 
            // cmd_beenden
            // 
            this.cmd_beenden.Location = new System.Drawing.Point(143, 475);
            this.cmd_beenden.Name = "cmd_beenden";
            this.cmd_beenden.Size = new System.Drawing.Size(665, 99);
            this.cmd_beenden.TabIndex = 1;
            this.cmd_beenden.Text = "Beenden";
            this.cmd_beenden.UseVisualStyleBackColor = true;
            this.cmd_beenden.Click += new System.EventHandler(this.cmd_beenden_Click);
            // 
            // cmd_zumSpiel
            // 
            this.cmd_zumSpiel.Location = new System.Drawing.Point(143, 219);
            this.cmd_zumSpiel.Name = "cmd_zumSpiel";
            this.cmd_zumSpiel.Size = new System.Drawing.Size(666, 204);
            this.cmd_zumSpiel.TabIndex = 0;
            this.cmd_zumSpiel.Text = "zum Spiel";
            this.cmd_zumSpiel.UseVisualStyleBackColor = true;
            this.cmd_zumSpiel.Click += new System.EventHandler(this.cmd_zumSpiel_Click);
            // 
            // tbp_schwierigkeit
            // 
            this.tbp_schwierigkeit.Location = new System.Drawing.Point(4, 25);
            this.tbp_schwierigkeit.Name = "tbp_schwierigkeit";
            this.tbp_schwierigkeit.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_schwierigkeit.Size = new System.Drawing.Size(998, 694);
            this.tbp_schwierigkeit.TabIndex = 1;
            this.tbp_schwierigkeit.Text = "tbp_schwierigkeit";
            this.tbp_schwierigkeit.UseVisualStyleBackColor = true;
            // 
            // tbp_level
            // 
            this.tbp_level.Location = new System.Drawing.Point(4, 25);
            this.tbp_level.Name = "tbp_level";
            this.tbp_level.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_level.Size = new System.Drawing.Size(998, 694);
            this.tbp_level.TabIndex = 2;
            this.tbp_level.Text = "tbp_level";
            this.tbp_level.UseVisualStyleBackColor = true;
            // 
            // tbp_spielfeld
            // 
            this.tbp_spielfeld.Location = new System.Drawing.Point(4, 25);
            this.tbp_spielfeld.Name = "tbp_spielfeld";
            this.tbp_spielfeld.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_spielfeld.Size = new System.Drawing.Size(998, 694);
            this.tbp_spielfeld.TabIndex = 3;
            this.tbp_spielfeld.Text = "tbp_spielfeld";
            this.tbp_spielfeld.UseVisualStyleBackColor = true;
            // 
            // Spielfeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.tabControl);
            this.Name = "Spielfeld";
            this.Text = "Spielfeld";
            this.tabControl.ResumeLayout(false);
            this.tbp_menu.ResumeLayout(false);
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
    }
}