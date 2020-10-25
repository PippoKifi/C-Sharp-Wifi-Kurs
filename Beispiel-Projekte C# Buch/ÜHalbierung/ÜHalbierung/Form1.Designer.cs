namespace ÜHalbierung
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
            this.cmdAnzeigen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAnzeigen
            // 
            this.cmdAnzeigen.Location = new System.Drawing.Point(197, 41);
            this.cmdAnzeigen.Name = "cmdAnzeigen";
            this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen.TabIndex = 5;
            this.cmdAnzeigen.Text = "Anzeigen";
            this.cmdAnzeigen.UseVisualStyleBackColor = true;
            this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(197, 12);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(75, 20);
            this.txtEingabe.TabIndex = 4;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdAnzeigen);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Halbierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAnzeigen;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Label lblA;
    }
}

