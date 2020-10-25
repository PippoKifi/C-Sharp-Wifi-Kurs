namespace Panel
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
            this.cmdUnten = new System.Windows.Forms.Button();
            this.cmdLinks = new System.Windows.Forms.Button();
            this.cmdRechts = new System.Windows.Forms.Button();
            this.cmdOben = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdUnten
            // 
            this.cmdUnten.Location = new System.Drawing.Point(162, 232);
            this.cmdUnten.Name = "cmdUnten";
            this.cmdUnten.Size = new System.Drawing.Size(75, 23);
            this.cmdUnten.TabIndex = 17;
            this.cmdUnten.Text = "nach unten";
            this.cmdUnten.UseVisualStyleBackColor = true;
            this.cmdUnten.Click += new System.EventHandler(this.cmdUnten_Click);
            // 
            // cmdLinks
            // 
            this.cmdLinks.Location = new System.Drawing.Point(12, 101);
            this.cmdLinks.Name = "cmdLinks";
            this.cmdLinks.Size = new System.Drawing.Size(75, 23);
            this.cmdLinks.TabIndex = 14;
            this.cmdLinks.Text = "nach links";
            this.cmdLinks.UseVisualStyleBackColor = true;
            this.cmdLinks.Click += new System.EventHandler(this.cmdLinks_Click);
            // 
            // cmdRechts
            // 
            this.cmdRechts.Location = new System.Drawing.Point(305, 101);
            this.cmdRechts.Name = "cmdRechts";
            this.cmdRechts.Size = new System.Drawing.Size(75, 23);
            this.cmdRechts.TabIndex = 16;
            this.cmdRechts.Text = "nach rechts";
            this.cmdRechts.UseVisualStyleBackColor = true;
            this.cmdRechts.Click += new System.EventHandler(this.cmdRechts_Click);
            // 
            // cmdOben
            // 
            this.cmdOben.Location = new System.Drawing.Point(162, 13);
            this.cmdOben.Name = "cmdOben";
            this.cmdOben.Size = new System.Drawing.Size(75, 23);
            this.cmdOben.TabIndex = 13;
            this.cmdOben.Text = "nach oben";
            this.cmdOben.UseVisualStyleBackColor = true;
            this.cmdOben.Click += new System.EventHandler(this.cmdOben_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.p.Location = new System.Drawing.Point(145, 82);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 100);
            this.p.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 271);
            this.Controls.Add(this.cmdUnten);
            this.Controls.Add(this.cmdLinks);
            this.Controls.Add(this.cmdRechts);
            this.Controls.Add(this.cmdOben);
            this.Controls.Add(this.p);
            this.Name = "Form1";
            this.Text = "Panel bewegen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdUnten;
        internal System.Windows.Forms.Button cmdLinks;
        internal System.Windows.Forms.Button cmdRechts;
        internal System.Windows.Forms.Button cmdOben;
        internal System.Windows.Forms.Panel p;
    }
}

