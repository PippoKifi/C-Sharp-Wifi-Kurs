namespace ExceptionHandlingErweitert
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
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.txtEingabe2 = new System.Windows.Forms.TextBox();
            this.txtEingabe1 = new System.Windows.Forms.TextBox();
            this.cmdRechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(12, 71);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAusgabe.TabIndex = 23;
            // 
            // txtEingabe2
            // 
            this.txtEingabe2.Location = new System.Drawing.Point(12, 38);
            this.txtEingabe2.Name = "txtEingabe2";
            this.txtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe2.TabIndex = 22;
            // 
            // txtEingabe1
            // 
            this.txtEingabe1.Location = new System.Drawing.Point(12, 12);
            this.txtEingabe1.Name = "txtEingabe1";
            this.txtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe1.TabIndex = 21;
            // 
            // cmdRechnen
            // 
            this.cmdRechnen.Location = new System.Drawing.Point(205, 9);
            this.cmdRechnen.Name = "cmdRechnen";
            this.cmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen.TabIndex = 20;
            this.cmdRechnen.Text = "Rechnen";
            this.cmdRechnen.UseVisualStyleBackColor = true;
            this.cmdRechnen.Click += new System.EventHandler(this.cmdRechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 111);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.txtEingabe2);
            this.Controls.Add(this.txtEingabe1);
            this.Controls.Add(this.cmdRechnen);
            this.Name = "Form1";
            this.Text = "Exception Handling, erweitert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAusgabe;
        internal System.Windows.Forms.TextBox txtEingabe2;
        internal System.Windows.Forms.TextBox txtEingabe1;
        internal System.Windows.Forms.Button cmdRechnen;
    }
}

