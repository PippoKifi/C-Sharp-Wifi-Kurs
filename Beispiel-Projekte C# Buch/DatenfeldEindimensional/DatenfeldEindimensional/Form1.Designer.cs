namespace DatenfeldEindimensional
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
            this.cmdAnzeigen3 = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdAnzeigen2 = new System.Windows.Forms.Button();
            this.cmdAnzeigen1 = new System.Windows.Forms.Button();
            this.lstFeld = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdAnzeigen3
            // 
            this.cmdAnzeigen3.Location = new System.Drawing.Point(247, 70);
            this.cmdAnzeigen3.Name = "cmdAnzeigen3";
            this.cmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen3.TabIndex = 20;
            this.cmdAnzeigen3.Text = "Anzeigen 3";
            this.cmdAnzeigen3.UseVisualStyleBackColor = true;
            this.cmdAnzeigen3.Click += new System.EventHandler(this.cmdAnzeigen3_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(126, 117);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 19;
            // 
            // cmdAnzeigen2
            // 
            this.cmdAnzeigen2.Location = new System.Drawing.Point(247, 41);
            this.cmdAnzeigen2.Name = "cmdAnzeigen2";
            this.cmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen2.TabIndex = 18;
            this.cmdAnzeigen2.Text = "Anzeigen 2";
            this.cmdAnzeigen2.UseVisualStyleBackColor = true;
            this.cmdAnzeigen2.Click += new System.EventHandler(this.cmdAnzeigen2_Click);
            // 
            // cmdAnzeigen1
            // 
            this.cmdAnzeigen1.Location = new System.Drawing.Point(247, 12);
            this.cmdAnzeigen1.Name = "cmdAnzeigen1";
            this.cmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen1.TabIndex = 17;
            this.cmdAnzeigen1.Text = "Anzeigen 1";
            this.cmdAnzeigen1.UseVisualStyleBackColor = true;
            this.cmdAnzeigen1.Click += new System.EventHandler(this.cmdAnzeigen1_Click);
            // 
            // lstFeld
            // 
            this.lstFeld.FormattingEnabled = true;
            this.lstFeld.Location = new System.Drawing.Point(12, 12);
            this.lstFeld.Name = "lstFeld";
            this.lstFeld.Size = new System.Drawing.Size(94, 121);
            this.lstFeld.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.cmdAnzeigen3);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeigen2);
            this.Controls.Add(this.cmdAnzeigen1);
            this.Controls.Add(this.lstFeld);
            this.Name = "Form1";
            this.Text = "Datenfeld, eindimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAnzeigen3;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdAnzeigen2;
        internal System.Windows.Forms.Button cmdAnzeigen1;
        internal System.Windows.Forms.ListBox lstFeld;
    }
}

