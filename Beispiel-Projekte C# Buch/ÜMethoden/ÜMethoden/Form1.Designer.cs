namespace ÜMethoden
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
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdFelder = new System.Windows.Forms.Button();
            this.cmdMittelwert2 = new System.Windows.Forms.Button();
            this.cmdMittelwert1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(9, 46);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 13);
            this.lblB.TabIndex = 15;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 14;
            // 
            // cmdFelder
            // 
            this.cmdFelder.Location = new System.Drawing.Point(197, 84);
            this.cmdFelder.Name = "cmdFelder";
            this.cmdFelder.Size = new System.Drawing.Size(75, 23);
            this.cmdFelder.TabIndex = 13;
            this.cmdFelder.Text = "Felder";
            this.cmdFelder.UseVisualStyleBackColor = true;
            this.cmdFelder.Click += new System.EventHandler(this.cmdFelder_Click);
            // 
            // cmdMittelwert2
            // 
            this.cmdMittelwert2.Location = new System.Drawing.Point(197, 41);
            this.cmdMittelwert2.Name = "cmdMittelwert2";
            this.cmdMittelwert2.Size = new System.Drawing.Size(75, 23);
            this.cmdMittelwert2.TabIndex = 12;
            this.cmdMittelwert2.Text = "Mittelwert 2";
            this.cmdMittelwert2.UseVisualStyleBackColor = true;
            this.cmdMittelwert2.Click += new System.EventHandler(this.cmdMittelwert2_Click);
            // 
            // cmdMittelwert1
            // 
            this.cmdMittelwert1.Location = new System.Drawing.Point(197, 12);
            this.cmdMittelwert1.Name = "cmdMittelwert1";
            this.cmdMittelwert1.Size = new System.Drawing.Size(75, 23);
            this.cmdMittelwert1.TabIndex = 11;
            this.cmdMittelwert1.Text = "Mittelwert 1";
            this.cmdMittelwert1.UseVisualStyleBackColor = true;
            this.cmdMittelwert1.Click += new System.EventHandler(this.cmdMittelwert1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdFelder);
            this.Controls.Add(this.cmdMittelwert2);
            this.Controls.Add(this.cmdMittelwert1);
            this.Name = "Form1";
            this.Text = "Methoden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button cmdFelder;
        private System.Windows.Forms.Button cmdMittelwert2;
        private System.Windows.Forms.Button cmdMittelwert1;
    }
}

