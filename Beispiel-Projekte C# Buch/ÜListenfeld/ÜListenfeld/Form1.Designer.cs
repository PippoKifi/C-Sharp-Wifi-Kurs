namespace ÜListenfeld
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
            this.cmdLinks = new System.Windows.Forms.Button();
            this.cmdRechts = new System.Windows.Forms.Button();
            this.lstRechts = new System.Windows.Forms.ListBox();
            this.lstLinks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdLinks
            // 
            this.cmdLinks.Location = new System.Drawing.Point(117, 41);
            this.cmdLinks.Name = "cmdLinks";
            this.cmdLinks.Size = new System.Drawing.Size(48, 23);
            this.cmdLinks.TabIndex = 15;
            this.cmdLinks.Text = "<<";
            this.cmdLinks.UseVisualStyleBackColor = true;
            this.cmdLinks.Click += new System.EventHandler(this.cmdLinks_Click);
            // 
            // cmdRechts
            // 
            this.cmdRechts.Location = new System.Drawing.Point(117, 12);
            this.cmdRechts.Name = "cmdRechts";
            this.cmdRechts.Size = new System.Drawing.Size(48, 23);
            this.cmdRechts.TabIndex = 14;
            this.cmdRechts.Text = ">>";
            this.cmdRechts.UseVisualStyleBackColor = true;
            this.cmdRechts.Click += new System.EventHandler(this.cmdRechts_Click);
            // 
            // lstRechts
            // 
            this.lstRechts.FormattingEnabled = true;
            this.lstRechts.Location = new System.Drawing.Point(178, 11);
            this.lstRechts.Name = "lstRechts";
            this.lstRechts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRechts.Size = new System.Drawing.Size(94, 238);
            this.lstRechts.TabIndex = 13;
            // 
            // lstLinks
            // 
            this.lstLinks.FormattingEnabled = true;
            this.lstLinks.Location = new System.Drawing.Point(12, 12);
            this.lstLinks.Name = "lstLinks";
            this.lstLinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLinks.Size = new System.Drawing.Size(94, 238);
            this.lstLinks.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdLinks);
            this.Controls.Add(this.cmdRechts);
            this.Controls.Add(this.lstRechts);
            this.Controls.Add(this.lstLinks);
            this.Name = "Form1";
            this.Text = "Listenfelder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdLinks;
        internal System.Windows.Forms.Button cmdRechts;
        internal System.Windows.Forms.ListBox lstRechts;
        internal System.Windows.Forms.ListBox lstLinks;
    }
}

