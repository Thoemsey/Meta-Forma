namespace Meta_Forma
{
    partial class Hauptmenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_zumSpiel = new System.Windows.Forms.Button();
            this.cmd_beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_zumSpiel
            // 
            this.cmd_zumSpiel.Location = new System.Drawing.Point(384, 406);
            this.cmd_zumSpiel.Name = "cmd_zumSpiel";
            this.cmd_zumSpiel.Size = new System.Drawing.Size(210, 69);
            this.cmd_zumSpiel.TabIndex = 0;
            this.cmd_zumSpiel.Text = "Zum Spiel";
            this.cmd_zumSpiel.UseVisualStyleBackColor = true;
            this.cmd_zumSpiel.Click += new System.EventHandler(this.cmd_zumSpiel_Click);
            // 
            // cmd_beenden
            // 
            this.cmd_beenden.Location = new System.Drawing.Point(384, 531);
            this.cmd_beenden.Name = "cmd_beenden";
            this.cmd_beenden.Size = new System.Drawing.Size(210, 69);
            this.cmd_beenden.TabIndex = 1;
            this.cmd_beenden.Text = "Beenden";
            this.cmd_beenden.UseVisualStyleBackColor = true;
            this.cmd_beenden.Click += new System.EventHandler(this.cmd_beenden_Click);
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.cmd_beenden);
            this.Controls.Add(this.cmd_zumSpiel);
            this.Name = "Hauptmenu";
            this.Text = "Meta-Forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_zumSpiel;
        private System.Windows.Forms.Button cmd_beenden;
    }
}

