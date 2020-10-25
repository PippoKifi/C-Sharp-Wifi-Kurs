namespace Tetris
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
            this.components = new System.ComponentModel.Container();
            this.lblPNr = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.timT = new System.Windows.Forms.Timer(this.components);
            this.panUnten = new System.Windows.Forms.Panel();
            this.panRechts = new System.Windows.Forms.Panel();
            this.panLinks = new System.Windows.Forms.Panel();
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdRechts = new System.Windows.Forms.Button();
            this.cmdUnten = new System.Windows.Forms.Button();
            this.cmdLinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPNr
            // 
            this.lblPNr.AutoSize = true;
            this.lblPNr.Location = new System.Drawing.Point(133, 17);
            this.lblPNr.Name = "lblPNr";
            this.lblPNr.Size = new System.Drawing.Size(0, 13);
            this.lblPNr.TabIndex = 37;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(127, 17);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 36;
            // 
            // timT
            // 
            this.timT.Enabled = true;
            this.timT.Interval = 500;
            this.timT.Tick += new System.EventHandler(this.timT_Tick);
            // 
            // panUnten
            // 
            this.panUnten.BackColor = System.Drawing.Color.Black;
            this.panUnten.Location = new System.Drawing.Point(20, 340);
            this.panUnten.Name = "panUnten";
            this.panUnten.Size = new System.Drawing.Size(160, 1);
            this.panUnten.TabIndex = 40;
            // 
            // panRechts
            // 
            this.panRechts.BackColor = System.Drawing.Color.Black;
            this.panRechts.Location = new System.Drawing.Point(180, 80);
            this.panRechts.Name = "panRechts";
            this.panRechts.Size = new System.Drawing.Size(1, 260);
            this.panRechts.TabIndex = 39;
            // 
            // panLinks
            // 
            this.panLinks.BackColor = System.Drawing.Color.Black;
            this.panLinks.Location = new System.Drawing.Point(20, 80);
            this.panLinks.Name = "panLinks";
            this.panLinks.Size = new System.Drawing.Size(1, 260);
            this.panLinks.TabIndex = 38;
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(70, 350);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(70, 28);
            this.cmdPause.TabIndex = 35;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdRechts
            // 
            this.cmdRechts.Location = new System.Drawing.Point(96, 15);
            this.cmdRechts.Name = "cmdRechts";
            this.cmdRechts.Size = new System.Drawing.Size(40, 28);
            this.cmdRechts.TabIndex = 34;
            this.cmdRechts.Text = "Re";
            this.cmdRechts.UseVisualStyleBackColor = true;
            this.cmdRechts.Click += new System.EventHandler(this.cmdRechts_Click);
            // 
            // cmdUnten
            // 
            this.cmdUnten.Location = new System.Drawing.Point(56, 50);
            this.cmdUnten.Name = "cmdUnten";
            this.cmdUnten.Size = new System.Drawing.Size(40, 28);
            this.cmdUnten.TabIndex = 33;
            this.cmdUnten.Text = "Dr";
            this.cmdUnten.UseVisualStyleBackColor = true;
            this.cmdUnten.Click += new System.EventHandler(this.cmdUnten_Click);
            // 
            // cmdLinks
            // 
            this.cmdLinks.Location = new System.Drawing.Point(16, 15);
            this.cmdLinks.Name = "cmdLinks";
            this.cmdLinks.Size = new System.Drawing.Size(40, 28);
            this.cmdLinks.TabIndex = 32;
            this.cmdLinks.Text = "Li";
            this.cmdLinks.UseVisualStyleBackColor = true;
            this.cmdLinks.Click += new System.EventHandler(this.cmdLinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 401);
            this.Controls.Add(this.lblPNr);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.panUnten);
            this.Controls.Add(this.panRechts);
            this.Controls.Add(this.panLinks);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdRechts);
            this.Controls.Add(this.cmdUnten);
            this.Controls.Add(this.cmdLinks);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPNr;
        internal System.Windows.Forms.Label lblTest;
        internal System.Windows.Forms.Timer timT;
        internal System.Windows.Forms.Panel panUnten;
        internal System.Windows.Forms.Panel panRechts;
        internal System.Windows.Forms.Panel panLinks;
        internal System.Windows.Forms.Button cmdPause;
        internal System.Windows.Forms.Button cmdRechts;
        internal System.Windows.Forms.Button cmdUnten;
        internal System.Windows.Forms.Button cmdLinks;
    }
}

