namespace RekursiverAufruf
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
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdRekursion = new System.Windows.Forms.Button();
            this.cmdSchleife = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(9, 17);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 11;
            // 
            // cmdRekursion
            // 
            this.cmdRekursion.Location = new System.Drawing.Point(197, 41);
            this.cmdRekursion.Name = "cmdRekursion";
            this.cmdRekursion.Size = new System.Drawing.Size(75, 23);
            this.cmdRekursion.TabIndex = 10;
            this.cmdRekursion.Text = "Rekursion";
            this.cmdRekursion.UseVisualStyleBackColor = true;
            this.cmdRekursion.Click += new System.EventHandler(this.cmdRekursion_Click);
            // 
            // cmdSchleife
            // 
            this.cmdSchleife.Location = new System.Drawing.Point(197, 12);
            this.cmdSchleife.Name = "cmdSchleife";
            this.cmdSchleife.Size = new System.Drawing.Size(75, 23);
            this.cmdSchleife.TabIndex = 9;
            this.cmdSchleife.Text = "Schleife";
            this.cmdSchleife.UseVisualStyleBackColor = true;
            this.cmdSchleife.Click += new System.EventHandler(this.cmdSchleife_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdRekursion);
            this.Controls.Add(this.cmdSchleife);
            this.Name = "Form1";
            this.Text = "Rekursiver Aufruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdRekursion;
        internal System.Windows.Forms.Button cmdSchleife;
    }
}

