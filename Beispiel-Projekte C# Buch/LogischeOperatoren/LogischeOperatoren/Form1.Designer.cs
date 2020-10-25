namespace LogischeOperatoren
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
            this.cmdLogisch4 = new System.Windows.Forms.Button();
            this.cmdLogisch3 = new System.Windows.Forms.Button();
            this.cmdLogisch2 = new System.Windows.Forms.Button();
            this.cmdLogisch1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 16);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 23;
            // 
            // cmdLogisch4
            // 
            this.cmdLogisch4.Location = new System.Drawing.Point(160, 99);
            this.cmdLogisch4.Name = "cmdLogisch4";
            this.cmdLogisch4.Size = new System.Drawing.Size(112, 23);
            this.cmdLogisch4.TabIndex = 22;
            this.cmdLogisch4.Text = "(B < A) ^ (C > B)";
            this.cmdLogisch4.UseCompatibleTextRendering = true;
            this.cmdLogisch4.UseVisualStyleBackColor = true;
            this.cmdLogisch4.Click += new System.EventHandler(this.cmdLogisch4_Click);
            // 
            // cmdLogisch3
            // 
            this.cmdLogisch3.Location = new System.Drawing.Point(160, 69);
            this.cmdLogisch3.Name = "cmdLogisch3";
            this.cmdLogisch3.Size = new System.Drawing.Size(112, 23);
            this.cmdLogisch3.TabIndex = 21;
            this.cmdLogisch3.Text = "(B < A) || (C < B)";
            this.cmdLogisch3.UseVisualStyleBackColor = true;
            this.cmdLogisch3.Click += new System.EventHandler(this.cmdLogisch3_Click);
            // 
            // cmdLogisch2
            // 
            this.cmdLogisch2.Location = new System.Drawing.Point(160, 40);
            this.cmdLogisch2.Name = "cmdLogisch2";
            this.cmdLogisch2.Size = new System.Drawing.Size(112, 23);
            this.cmdLogisch2.TabIndex = 20;
            this.cmdLogisch2.Text = "(B > A) &&&& (C > B)";
            this.cmdLogisch2.UseVisualStyleBackColor = true;
            this.cmdLogisch2.Click += new System.EventHandler(this.cmdLogisch2_Click);
            // 
            // cmdLogisch1
            // 
            this.cmdLogisch1.Location = new System.Drawing.Point(160, 12);
            this.cmdLogisch1.Name = "cmdLogisch1";
            this.cmdLogisch1.Size = new System.Drawing.Size(112, 23);
            this.cmdLogisch1.TabIndex = 19;
            this.cmdLogisch1.Text = "!(A < B)";
            this.cmdLogisch1.UseVisualStyleBackColor = true;
            this.cmdLogisch1.Click += new System.EventHandler(this.cmdLogisch1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdLogisch4);
            this.Controls.Add(this.cmdLogisch3);
            this.Controls.Add(this.cmdLogisch2);
            this.Controls.Add(this.cmdLogisch1);
            this.Name = "Form1";
            this.Text = "Logische Operatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdLogisch4;
        internal System.Windows.Forms.Button cmdLogisch3;
        internal System.Windows.Forms.Button cmdLogisch2;
        internal System.Windows.Forms.Button cmdLogisch1;
    }
}

