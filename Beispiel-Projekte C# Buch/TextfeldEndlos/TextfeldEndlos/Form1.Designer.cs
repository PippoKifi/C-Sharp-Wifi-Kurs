namespace TextfeldEndlos
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
            this.txtEingabe2 = new System.Windows.Forms.TextBox();
            this.txtEingabe1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 9;
            // 
            // txtEingabe2
            // 
            this.txtEingabe2.Location = new System.Drawing.Point(222, 38);
            this.txtEingabe2.Name = "txtEingabe2";
            this.txtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe2.TabIndex = 8;
            this.txtEingabe2.TextChanged += new System.EventHandler(this.txtEingabe2_TextChanged);
            // 
            // txtEingabe1
            // 
            this.txtEingabe1.Location = new System.Drawing.Point(222, 12);
            this.txtEingabe1.Name = "txtEingabe1";
            this.txtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe1.TabIndex = 7;
            this.txtEingabe1.TextChanged += new System.EventHandler(this.txtEingabe1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtEingabe2);
            this.Controls.Add(this.txtEingabe1);
            this.Name = "Form1";
            this.Text = "Textfeld, endlose Ereigniskette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.TextBox txtEingabe2;
        internal System.Windows.Forms.TextBox txtEingabe1;
    }
}

