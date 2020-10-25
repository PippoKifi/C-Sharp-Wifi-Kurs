namespace ÜDatenfeldEindimensional
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
            this.cmdMinima = new System.Windows.Forms.Button();
            this.lstZahl = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(115, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 11;
            // 
            // cmdMinima
            // 
            this.cmdMinima.Location = new System.Drawing.Point(118, 12);
            this.cmdMinima.Name = "cmdMinima";
            this.cmdMinima.Size = new System.Drawing.Size(75, 23);
            this.cmdMinima.TabIndex = 10;
            this.cmdMinima.Text = "Minima";
            this.cmdMinima.UseVisualStyleBackColor = true;
            this.cmdMinima.Click += new System.EventHandler(this.cmdMinima_Click);
            // 
            // lstZahl
            // 
            this.lstZahl.FormattingEnabled = true;
            this.lstZahl.Location = new System.Drawing.Point(12, 12);
            this.lstZahl.Name = "lstZahl";
            this.lstZahl.Size = new System.Drawing.Size(75, 147);
            this.lstZahl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 171);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdMinima);
            this.Controls.Add(this.lstZahl);
            this.Name = "Form1";
            this.Text = "Datenfeld, eindimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdMinima;
        internal System.Windows.Forms.ListBox lstZahl;
    }
}

