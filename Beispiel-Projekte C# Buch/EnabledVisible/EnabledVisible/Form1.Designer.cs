namespace EnabledVisible
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
            this.cmdRechnen2 = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.cmdRechnen1 = new System.Windows.Forms.Button();
            this.txtEingabe2 = new System.Windows.Forms.TextBox();
            this.txtEingabe1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdRechnen2
            // 
            this.cmdRechnen2.Location = new System.Drawing.Point(197, 64);
            this.cmdRechnen2.Name = "cmdRechnen2";
            this.cmdRechnen2.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen2.TabIndex = 19;
            this.cmdRechnen2.Text = "Rechnen 2";
            this.cmdRechnen2.UseVisualStyleBackColor = true;
            this.cmdRechnen2.Visible = false;
            this.cmdRechnen2.Click += new System.EventHandler(this.cmdRechnen_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(161, 16);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAusgabe.TabIndex = 18;
            // 
            // cmdRechnen1
            // 
            this.cmdRechnen1.Enabled = false;
            this.cmdRechnen1.Location = new System.Drawing.Point(12, 64);
            this.cmdRechnen1.Name = "cmdRechnen1";
            this.cmdRechnen1.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen1.TabIndex = 17;
            this.cmdRechnen1.Text = "Rechnen 1";
            this.cmdRechnen1.UseVisualStyleBackColor = true;
            this.cmdRechnen1.Click += new System.EventHandler(this.cmdRechnen_Click);
            // 
            // txtEingabe2
            // 
            this.txtEingabe2.Location = new System.Drawing.Point(68, 12);
            this.txtEingabe2.Name = "txtEingabe2";
            this.txtEingabe2.Size = new System.Drawing.Size(50, 20);
            this.txtEingabe2.TabIndex = 16;
            this.txtEingabe2.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // txtEingabe1
            // 
            this.txtEingabe1.Location = new System.Drawing.Point(12, 12);
            this.txtEingabe1.Name = "txtEingabe1";
            this.txtEingabe1.Size = new System.Drawing.Size(50, 20);
            this.txtEingabe1.TabIndex = 15;
            this.txtEingabe1.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.cmdRechnen2);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.cmdRechnen1);
            this.Controls.Add(this.txtEingabe2);
            this.Controls.Add(this.txtEingabe1);
            this.Name = "Form1";
            this.Text = "Enabled, Visible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdRechnen2;
        internal System.Windows.Forms.Label lblAusgabe;
        internal System.Windows.Forms.Button cmdRechnen1;
        internal System.Windows.Forms.TextBox txtEingabe2;
        internal System.Windows.Forms.TextBox txtEingabe1;
    }
}

