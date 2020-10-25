namespace DBZugriffMySQL
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
            this.cmdSenken = new System.Windows.Forms.Button();
            this.lstTab = new System.Windows.Forms.ListBox();
            this.cmdErhöhen = new System.Windows.Forms.Button();
            this.cmdAlleSehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSenken
            // 
            this.cmdSenken.Location = new System.Drawing.Point(12, 70);
            this.cmdSenken.Name = "cmdSenken";
            this.cmdSenken.Size = new System.Drawing.Size(150, 23);
            this.cmdSenken.TabIndex = 20;
            this.cmdSenken.Text = "Gehälter senken";
            this.cmdSenken.UseVisualStyleBackColor = true;
            this.cmdSenken.Click += new System.EventHandler(this.cmdErhöhen_Click);
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.Location = new System.Drawing.Point(12, 99);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(268, 95);
            this.lstTab.TabIndex = 19;
            // 
            // cmdErhöhen
            // 
            this.cmdErhöhen.Location = new System.Drawing.Point(12, 41);
            this.cmdErhöhen.Name = "cmdErhöhen";
            this.cmdErhöhen.Size = new System.Drawing.Size(150, 23);
            this.cmdErhöhen.TabIndex = 18;
            this.cmdErhöhen.Text = "Gehälter erhöhen";
            this.cmdErhöhen.UseVisualStyleBackColor = true;
            this.cmdErhöhen.Click += new System.EventHandler(this.cmdErhöhen_Click);
            // 
            // cmdAlleSehen
            // 
            this.cmdAlleSehen.Location = new System.Drawing.Point(12, 12);
            this.cmdAlleSehen.Name = "cmdAlleSehen";
            this.cmdAlleSehen.Size = new System.Drawing.Size(150, 23);
            this.cmdAlleSehen.TabIndex = 17;
            this.cmdAlleSehen.Text = "Alle Datensätze sehen";
            this.cmdAlleSehen.UseVisualStyleBackColor = true;
            this.cmdAlleSehen.Click += new System.EventHandler(this.cmdAlleSehen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.cmdSenken);
            this.Controls.Add(this.lstTab);
            this.Controls.Add(this.cmdErhöhen);
            this.Controls.Add(this.cmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Datenbank, Zugriff MySQL";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdSenken;
        internal System.Windows.Forms.ListBox lstTab;
        internal System.Windows.Forms.Button cmdErhöhen;
        internal System.Windows.Forms.Button cmdAlleSehen;
    }
}

