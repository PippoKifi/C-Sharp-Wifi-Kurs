namespace WhileDoWhileSchleifen
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
            this.cmdDoWhile = new System.Windows.Forms.Button();
            this.cmdWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 5;
            // 
            // cmdDoWhile
            // 
            this.cmdDoWhile.Location = new System.Drawing.Point(197, 41);
            this.cmdDoWhile.Name = "cmdDoWhile";
            this.cmdDoWhile.Size = new System.Drawing.Size(75, 23);
            this.cmdDoWhile.TabIndex = 4;
            this.cmdDoWhile.Text = "do-while";
            this.cmdDoWhile.UseVisualStyleBackColor = true;
            this.cmdDoWhile.Click += new System.EventHandler(this.cmdDoWhile_Click);
            // 
            // cmdWhile
            // 
            this.cmdWhile.Location = new System.Drawing.Point(197, 12);
            this.cmdWhile.Name = "cmdWhile";
            this.cmdWhile.Size = new System.Drawing.Size(75, 23);
            this.cmdWhile.TabIndex = 3;
            this.cmdWhile.Text = "while";
            this.cmdWhile.UseVisualStyleBackColor = true;
            this.cmdWhile.Click += new System.EventHandler(this.cmdWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdDoWhile);
            this.Controls.Add(this.cmdWhile);
            this.Name = "Form1";
            this.Text = "while / do-while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button cmdDoWhile;
        private System.Windows.Forms.Button cmdWhile;
    }
}

