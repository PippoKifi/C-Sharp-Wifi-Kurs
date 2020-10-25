namespace Vergleichsoperatoren
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
            this.cmdVergleich4 = new System.Windows.Forms.Button();
            this.cmdVergleich3 = new System.Windows.Forms.Button();
            this.cmdVergleich2 = new System.Windows.Forms.Button();
            this.cmdVergleich1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(16, 13);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 9;
            // 
            // cmdVergleich4
            // 
            this.cmdVergleich4.Location = new System.Drawing.Point(161, 92);
            this.cmdVergleich4.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVergleich4.Name = "cmdVergleich4";
            this.cmdVergleich4.Size = new System.Drawing.Size(112, 23);
            this.cmdVergleich4.TabIndex = 8;
            this.cmdVergleich4.Text = "\"Maier\" == \"Mayer\"";
            this.cmdVergleich4.UseVisualStyleBackColor = true;
            this.cmdVergleich4.Click += new System.EventHandler(this.cmdVergleich4_Click);
            // 
            // cmdVergleich3
            // 
            this.cmdVergleich3.Location = new System.Drawing.Point(161, 65);
            this.cmdVergleich3.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVergleich3.Name = "cmdVergleich3";
            this.cmdVergleich3.Size = new System.Drawing.Size(112, 23);
            this.cmdVergleich3.TabIndex = 7;
            this.cmdVergleich3.Text = "5 + 3 * 2 >= 12";
            this.cmdVergleich3.UseVisualStyleBackColor = true;
            this.cmdVergleich3.Click += new System.EventHandler(this.cmdVergleich3_Click);
            // 
            // cmdVergleich2
            // 
            this.cmdVergleich2.Location = new System.Drawing.Point(161, 38);
            this.cmdVergleich2.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVergleich2.Name = "cmdVergleich2";
            this.cmdVergleich2.Size = new System.Drawing.Size(112, 23);
            this.cmdVergleich2.TabIndex = 6;
            this.cmdVergleich2.Text = "3 == 3.2";
            this.cmdVergleich2.UseVisualStyleBackColor = true;
            this.cmdVergleich2.Click += new System.EventHandler(this.cmdVergleich2_Click);
            // 
            // cmdVergleich1
            // 
            this.cmdVergleich1.Location = new System.Drawing.Point(161, 11);
            this.cmdVergleich1.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVergleich1.Name = "cmdVergleich1";
            this.cmdVergleich1.Size = new System.Drawing.Size(112, 23);
            this.cmdVergleich1.TabIndex = 5;
            this.cmdVergleich1.Text = "5 > 3";
            this.cmdVergleich1.UseVisualStyleBackColor = true;
            this.cmdVergleich1.Click += new System.EventHandler(this.cmdVergleich1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdVergleich4);
            this.Controls.Add(this.cmdVergleich3);
            this.Controls.Add(this.cmdVergleich2);
            this.Controls.Add(this.cmdVergleich1);
            this.Name = "Form1";
            this.Text = "Vergleichsoperatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button cmdVergleich4;
        private System.Windows.Forms.Button cmdVergleich3;
        private System.Windows.Forms.Button cmdVergleich2;
        private System.Windows.Forms.Button cmdVergleich1;
    }
}

