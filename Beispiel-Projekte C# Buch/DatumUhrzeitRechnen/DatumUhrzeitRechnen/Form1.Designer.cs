namespace DatumUhrzeitRechnen
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
            this.lstA = new System.Windows.Forms.ListBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(12, 41);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(310, 108);
            this.lstA.TabIndex = 9;
            // 
            // cmdA
            // 
            this.cmdA.Location = new System.Drawing.Point(247, 12);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(75, 23);
            this.cmdA.TabIndex = 8;
            this.cmdA.Text = "Anzeigen";
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.cmdA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.cmdA);
            this.Name = "Form1";
            this.Text = "Datum und Uhrzeit, Rechnen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lstA;
        internal System.Windows.Forms.Button cmdA;
    }
}

