namespace Drucken
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
            this.cmdInfo = new System.Windows.Forms.Button();
            this.cmdSeitenvorschau = new System.Windows.Forms.Button();
            this.cmdDrucken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdInfo
            // 
            this.cmdInfo.Location = new System.Drawing.Point(11, 65);
            this.cmdInfo.Margin = new System.Windows.Forms.Padding(2);
            this.cmdInfo.Name = "cmdInfo";
            this.cmdInfo.Size = new System.Drawing.Size(112, 23);
            this.cmdInfo.TabIndex = 8;
            this.cmdInfo.Text = "Druckinformationen";
            this.cmdInfo.UseVisualStyleBackColor = true;
            this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
            // 
            // cmdSeitenvorschau
            // 
            this.cmdSeitenvorschau.Location = new System.Drawing.Point(11, 38);
            this.cmdSeitenvorschau.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSeitenvorschau.Name = "cmdSeitenvorschau";
            this.cmdSeitenvorschau.Size = new System.Drawing.Size(112, 23);
            this.cmdSeitenvorschau.TabIndex = 7;
            this.cmdSeitenvorschau.Text = "Seitenvorschau";
            this.cmdSeitenvorschau.UseVisualStyleBackColor = true;
            this.cmdSeitenvorschau.Click += new System.EventHandler(this.cmdSeitenvorschau_Click);
            // 
            // cmdDrucken
            // 
            this.cmdDrucken.Location = new System.Drawing.Point(11, 11);
            this.cmdDrucken.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDrucken.Name = "cmdDrucken";
            this.cmdDrucken.Size = new System.Drawing.Size(112, 23);
            this.cmdDrucken.TabIndex = 6;
            this.cmdDrucken.Text = "Formular drucken";
            this.cmdDrucken.UseVisualStyleBackColor = true;
            this.cmdDrucken.Click += new System.EventHandler(this.cmdDrucken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 131);
            this.Controls.Add(this.cmdInfo);
            this.Controls.Add(this.cmdSeitenvorschau);
            this.Controls.Add(this.cmdDrucken);
            this.Name = "Form1";
            this.Text = "Drucken";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdInfo;
        internal System.Windows.Forms.Button cmdSeitenvorschau;
        internal System.Windows.Forms.Button cmdDrucken;
    }
}

