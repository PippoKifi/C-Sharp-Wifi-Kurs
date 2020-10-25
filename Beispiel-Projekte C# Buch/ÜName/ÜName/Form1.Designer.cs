namespace ÜName
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
            this.cmdEnde = new System.Windows.Forms.Button();
            this.cmdMyName = new System.Windows.Forms.Button();
            this.lblMyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdEnde
            // 
            this.cmdEnde.Location = new System.Drawing.Point(263, 53);
            this.cmdEnde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEnde.Name = "cmdEnde";
            this.cmdEnde.Size = new System.Drawing.Size(100, 28);
            this.cmdEnde.TabIndex = 8;
            this.cmdEnde.Text = "Ende";
            this.cmdEnde.UseVisualStyleBackColor = true;
            this.cmdEnde.Click += new System.EventHandler(this.cmdEnde_Click);
            // 
            // cmdMyName
            // 
            this.cmdMyName.Location = new System.Drawing.Point(16, 53);
            this.cmdMyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdMyName.Name = "cmdMyName";
            this.cmdMyName.Size = new System.Drawing.Size(100, 28);
            this.cmdMyName.TabIndex = 7;
            this.cmdMyName.Text = "Mein Name";
            this.cmdMyName.UseVisualStyleBackColor = true;
            this.cmdMyName.Click += new System.EventHandler(this.cmdMyName_Click);
            // 
            // lblMyName
            // 
            this.lblMyName.AutoSize = true;
            this.lblMyName.Location = new System.Drawing.Point(12, 16);
            this.lblMyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(0, 17);
            this.lblMyName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 105);
            this.Controls.Add(this.cmdEnde);
            this.Controls.Add(this.cmdMyName);
            this.Controls.Add(this.lblMyName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mein Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdEnde;
        internal System.Windows.Forms.Button cmdMyName;
        internal System.Windows.Forms.Label lblMyName;
    }
}

