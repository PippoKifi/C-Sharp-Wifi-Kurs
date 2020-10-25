namespace ButtonEndlos
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
            this.cmdEreignis2 = new System.Windows.Forms.Button();
            this.cmdEreignis1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(4, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 9;
            // 
            // cmdEreignis2
            // 
            this.cmdEreignis2.Location = new System.Drawing.Point(197, 41);
            this.cmdEreignis2.Name = "cmdEreignis2";
            this.cmdEreignis2.Size = new System.Drawing.Size(75, 23);
            this.cmdEreignis2.TabIndex = 8;
            this.cmdEreignis2.Text = "Ereignis 2";
            this.cmdEreignis2.UseVisualStyleBackColor = true;
            this.cmdEreignis2.Click += new System.EventHandler(this.cmdEreignis2_Click);
            // 
            // cmdEreignis1
            // 
            this.cmdEreignis1.Location = new System.Drawing.Point(197, 12);
            this.cmdEreignis1.Name = "cmdEreignis1";
            this.cmdEreignis1.Size = new System.Drawing.Size(75, 23);
            this.cmdEreignis1.TabIndex = 7;
            this.cmdEreignis1.Text = "Ereignis 1";
            this.cmdEreignis1.UseVisualStyleBackColor = true;
            this.cmdEreignis1.Click += new System.EventHandler(this.cmdEreignis1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdEreignis2);
            this.Controls.Add(this.cmdEreignis1);
            this.Name = "Form1";
            this.Text = "Endlose Ereigniskette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdEreignis2;
        internal System.Windows.Forms.Button cmdEreignis1;
    }
}

