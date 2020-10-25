namespace DateiSicherLesen
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
            this.cmdPfad = new System.Windows.Forms.Button();
            this.cmdAusnahme = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdExistenz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPfad
            // 
            this.cmdPfad.Location = new System.Drawing.Point(197, 70);
            this.cmdPfad.Name = "cmdPfad";
            this.cmdPfad.Size = new System.Drawing.Size(75, 23);
            this.cmdPfad.TabIndex = 15;
            this.cmdPfad.Text = "Pfad";
            this.cmdPfad.UseVisualStyleBackColor = true;
            this.cmdPfad.Click += new System.EventHandler(this.cmdPfad_Click);
            // 
            // cmdAusnahme
            // 
            this.cmdAusnahme.Location = new System.Drawing.Point(197, 41);
            this.cmdAusnahme.Name = "cmdAusnahme";
            this.cmdAusnahme.Size = new System.Drawing.Size(75, 23);
            this.cmdAusnahme.TabIndex = 14;
            this.cmdAusnahme.Text = "Ausnahme";
            this.cmdAusnahme.UseVisualStyleBackColor = true;
            this.cmdAusnahme.Click += new System.EventHandler(this.cmdAusnahme_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 13;
            // 
            // cmdExistenz
            // 
            this.cmdExistenz.Location = new System.Drawing.Point(197, 12);
            this.cmdExistenz.Name = "cmdExistenz";
            this.cmdExistenz.Size = new System.Drawing.Size(75, 23);
            this.cmdExistenz.TabIndex = 12;
            this.cmdExistenz.Text = "Existenz";
            this.cmdExistenz.UseVisualStyleBackColor = true;
            this.cmdExistenz.Click += new System.EventHandler(this.cmdExistenz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdPfad);
            this.Controls.Add(this.cmdAusnahme);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdExistenz);
            this.Name = "Form1";
            this.Text = "Datei sicher lesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdPfad;
        internal System.Windows.Forms.Button cmdAusnahme;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdExistenz;
    }
}

