namespace Methoden
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
            this.cmdAnzeige2 = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdAnzeige1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAnzeige2
            // 
            this.cmdAnzeige2.Location = new System.Drawing.Point(197, 41);
            this.cmdAnzeige2.Name = "cmdAnzeige2";
            this.cmdAnzeige2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige2.TabIndex = 14;
            this.cmdAnzeige2.Text = "Anzeige 2";
            this.cmdAnzeige2.UseVisualStyleBackColor = true;
            this.cmdAnzeige2.Click += new System.EventHandler(this.cmdAnzeige2_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(9, 17);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 13;
            // 
            // cmdAnzeige1
            // 
            this.cmdAnzeige1.Location = new System.Drawing.Point(197, 12);
            this.cmdAnzeige1.Name = "cmdAnzeige1";
            this.cmdAnzeige1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige1.TabIndex = 12;
            this.cmdAnzeige1.Text = "Anzeige 1";
            this.cmdAnzeige1.UseVisualStyleBackColor = true;
            this.cmdAnzeige1.Click += new System.EventHandler(this.cmdAnzeige1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.cmdAnzeige2);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeige1);
            this.Name = "Form1";
            this.Text = "Methoden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAnzeige2;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdAnzeige1;
    }
}

