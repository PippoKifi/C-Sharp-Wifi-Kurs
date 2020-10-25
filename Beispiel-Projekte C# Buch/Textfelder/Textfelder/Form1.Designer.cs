namespace Textfelder
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
            this.cmdAusgabe = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.cmdRechnen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAusgabe
            // 
            this.cmdAusgabe.Location = new System.Drawing.Point(118, 10);
            this.cmdAusgabe.Name = "cmdAusgabe";
            this.cmdAusgabe.Size = new System.Drawing.Size(75, 23);
            this.cmdAusgabe.TabIndex = 17;
            this.cmdAusgabe.Text = "Ausgabe";
            this.cmdAusgabe.UseVisualStyleBackColor = true;
            this.cmdAusgabe.Click += new System.EventHandler(this.cmdAusgabe_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(12, 85);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAusgabe.TabIndex = 16;
            // 
            // cmdRechnen
            // 
            this.cmdRechnen.Location = new System.Drawing.Point(118, 39);
            this.cmdRechnen.Name = "cmdRechnen";
            this.cmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen.TabIndex = 15;
            this.cmdRechnen.Text = "Rechnen";
            this.cmdRechnen.UseVisualStyleBackColor = true;
            this.cmdRechnen.Click += new System.EventHandler(this.cmdRechnen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 12);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdAusgabe);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.cmdRechnen);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Textfelder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAusgabe;
        internal System.Windows.Forms.Label lblAusgabe;
        internal System.Windows.Forms.Button cmdRechnen;
        internal System.Windows.Forms.TextBox txtEingabe;
    }
}

