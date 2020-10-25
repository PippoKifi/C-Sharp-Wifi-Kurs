namespace Datentypen
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
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(263, 15);
            this.cmdAnzeige.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(100, 28);
            this.cmdAnzeige.TabIndex = 8;
            this.cmdAnzeige.Text = "Anzeige";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 15);
            this.lblAnzeige.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 17);
            this.lblAnzeige.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 215);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.lblAnzeige);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Variablen, Datentypen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAnzeige;
        internal System.Windows.Forms.Label lblAnzeige;
    }
}

