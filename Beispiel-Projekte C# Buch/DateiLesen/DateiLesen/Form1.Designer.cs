namespace DateiLesen
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
            this.lblA = new System.Windows.Forms.Label();
            this.cmdLesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 7;
            // 
            // cmdLesen
            // 
            this.cmdLesen.Location = new System.Drawing.Point(12, 12);
            this.cmdLesen.Name = "cmdLesen";
            this.cmdLesen.Size = new System.Drawing.Size(75, 23);
            this.cmdLesen.TabIndex = 6;
            this.cmdLesen.Text = "Lesen";
            this.cmdLesen.UseVisualStyleBackColor = true;
            this.cmdLesen.Click += new System.EventHandler(this.cmdLesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdLesen);
            this.Name = "Form1";
            this.Text = "Datei lesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdLesen;
    }
}

