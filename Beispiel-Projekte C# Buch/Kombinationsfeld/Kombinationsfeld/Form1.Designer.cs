namespace Kombinationsfeld
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
            this.lblAnzeige3 = new System.Windows.Forms.Label();
            this.cmdAnzeigen3 = new System.Windows.Forms.Button();
            this.lblAnzeige2 = new System.Windows.Forms.Label();
            this.cmdAnzeigen2 = new System.Windows.Forms.Button();
            this.cmbWerkzeug2 = new System.Windows.Forms.ComboBox();
            this.cmbWerkzeug3 = new System.Windows.Forms.ComboBox();
            this.lblAnzeige1 = new System.Windows.Forms.Label();
            this.cmdAnzeigen1 = new System.Windows.Forms.Button();
            this.cmbWerkzeug1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAnzeige3
            // 
            this.lblAnzeige3.AutoSize = true;
            this.lblAnzeige3.Location = new System.Drawing.Point(268, 110);
            this.lblAnzeige3.Name = "lblAnzeige3";
            this.lblAnzeige3.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige3.TabIndex = 35;
            // 
            // cmdAnzeigen3
            // 
            this.cmdAnzeigen3.Location = new System.Drawing.Point(168, 100);
            this.cmdAnzeigen3.Name = "cmdAnzeigen3";
            this.cmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen3.TabIndex = 34;
            this.cmdAnzeigen3.Text = "Anzeigen 3";
            this.cmdAnzeigen3.UseVisualStyleBackColor = true;
            this.cmdAnzeigen3.Click += new System.EventHandler(this.cmdAnzeigen3_Click);
            // 
            // lblAnzeige2
            // 
            this.lblAnzeige2.AutoSize = true;
            this.lblAnzeige2.Location = new System.Drawing.Point(268, 65);
            this.lblAnzeige2.Name = "lblAnzeige2";
            this.lblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige2.TabIndex = 33;
            // 
            // cmdAnzeigen2
            // 
            this.cmdAnzeigen2.Location = new System.Drawing.Point(168, 55);
            this.cmdAnzeigen2.Name = "cmdAnzeigen2";
            this.cmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen2.TabIndex = 32;
            this.cmdAnzeigen2.Text = "Anzeigen 2";
            this.cmdAnzeigen2.UseVisualStyleBackColor = true;
            this.cmdAnzeigen2.Click += new System.EventHandler(this.cmdAnzeigen2_Click);
            // 
            // cmbWerkzeug2
            // 
            this.cmbWerkzeug2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWerkzeug2.FormattingEnabled = true;
            this.cmbWerkzeug2.Location = new System.Drawing.Point(12, 55);
            this.cmbWerkzeug2.Name = "cmbWerkzeug2";
            this.cmbWerkzeug2.Size = new System.Drawing.Size(121, 21);
            this.cmbWerkzeug2.TabIndex = 31;
            // 
            // cmbWerkzeug3
            // 
            this.cmbWerkzeug3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWerkzeug3.FormattingEnabled = true;
            this.cmbWerkzeug3.Location = new System.Drawing.Point(12, 100);
            this.cmbWerkzeug3.Name = "cmbWerkzeug3";
            this.cmbWerkzeug3.Size = new System.Drawing.Size(121, 98);
            this.cmbWerkzeug3.TabIndex = 30;
            // 
            // lblAnzeige1
            // 
            this.lblAnzeige1.AutoSize = true;
            this.lblAnzeige1.Location = new System.Drawing.Point(268, 20);
            this.lblAnzeige1.Name = "lblAnzeige1";
            this.lblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige1.TabIndex = 29;
            // 
            // cmdAnzeigen1
            // 
            this.cmdAnzeigen1.Location = new System.Drawing.Point(168, 10);
            this.cmdAnzeigen1.Name = "cmdAnzeigen1";
            this.cmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen1.TabIndex = 28;
            this.cmdAnzeigen1.Text = "Anzeigen 1";
            this.cmdAnzeigen1.UseVisualStyleBackColor = true;
            this.cmdAnzeigen1.Click += new System.EventHandler(this.cmdAnzeigen1_Click);
            // 
            // cmbWerkzeug1
            // 
            this.cmbWerkzeug1.FormattingEnabled = true;
            this.cmbWerkzeug1.Location = new System.Drawing.Point(12, 12);
            this.cmbWerkzeug1.Name = "cmbWerkzeug1";
            this.cmbWerkzeug1.Size = new System.Drawing.Size(121, 21);
            this.cmbWerkzeug1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.lblAnzeige3);
            this.Controls.Add(this.cmdAnzeigen3);
            this.Controls.Add(this.lblAnzeige2);
            this.Controls.Add(this.cmdAnzeigen2);
            this.Controls.Add(this.cmbWerkzeug2);
            this.Controls.Add(this.cmbWerkzeug3);
            this.Controls.Add(this.lblAnzeige1);
            this.Controls.Add(this.cmdAnzeigen1);
            this.Controls.Add(this.cmbWerkzeug1);
            this.Name = "Form1";
            this.Text = "Kombinationsfeld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAnzeige3;
        internal System.Windows.Forms.Button cmdAnzeigen3;
        internal System.Windows.Forms.Label lblAnzeige2;
        internal System.Windows.Forms.Button cmdAnzeigen2;
        internal System.Windows.Forms.ComboBox cmbWerkzeug2;
        internal System.Windows.Forms.ComboBox cmbWerkzeug3;
        internal System.Windows.Forms.Label lblAnzeige1;
        internal System.Windows.Forms.Button cmdAnzeigen1;
        internal System.Windows.Forms.ComboBox cmbWerkzeug1;
    }
}

