namespace Kontrollkästchen
{
    partial class Form1
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
            this.cmdUmschalten = new System.Windows.Forms.Button();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.chkSchalter = new System.Windows.Forms.CheckBox();
            this.cmdPrüfen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUmschalten
            // 
            this.cmdUmschalten.Location = new System.Drawing.Point(152, 93);
            this.cmdUmschalten.Name = "cmdUmschalten";
            this.cmdUmschalten.Size = new System.Drawing.Size(120, 23);
            this.cmdUmschalten.TabIndex = 19;
            this.cmdUmschalten.Text = "Schalter umschalten";
            this.cmdUmschalten.UseVisualStyleBackColor = true;
            this.cmdUmschalten.Click += new System.EventHandler(this.cmdUmschalten_Click);
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(95, 70);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(25, 13);
            this.lblTest2.TabIndex = 18;
            this.lblTest2.Text = "Aus";
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(95, 17);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(25, 13);
            this.lblTest1.TabIndex = 17;
            this.lblTest1.Text = "Aus";
            // 
            // chkSchalter
            // 
            this.chkSchalter.AutoSize = true;
            this.chkSchalter.Location = new System.Drawing.Point(152, 70);
            this.chkSchalter.Name = "chkSchalter";
            this.chkSchalter.Size = new System.Drawing.Size(65, 17);
            this.chkSchalter.TabIndex = 16;
            this.chkSchalter.Text = "Schalter";
            this.chkSchalter.UseVisualStyleBackColor = true;
            this.chkSchalter.CheckedChanged += new System.EventHandler(this.chkSchalter_CheckedChanged);
            // 
            // cmdPrüfen
            // 
            this.cmdPrüfen.Location = new System.Drawing.Point(152, 12);
            this.cmdPrüfen.Name = "cmdPrüfen";
            this.cmdPrüfen.Size = new System.Drawing.Size(120, 23);
            this.cmdPrüfen.TabIndex = 15;
            this.cmdPrüfen.Text = "Schalter prüfen";
            this.cmdPrüfen.UseVisualStyleBackColor = true;
            this.cmdPrüfen.Click += new System.EventHandler(this.cmdPrüfen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdUmschalten);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.chkSchalter);
            this.Controls.Add(this.cmdPrüfen);
            this.Name = "Form1";
            this.Text = "Kontrollkästchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdUmschalten;
        internal System.Windows.Forms.Label lblTest2;
        internal System.Windows.Forms.Label lblTest1;
        internal System.Windows.Forms.CheckBox chkSchalter;
        internal System.Windows.Forms.Button cmdPrüfen;
    }
}

