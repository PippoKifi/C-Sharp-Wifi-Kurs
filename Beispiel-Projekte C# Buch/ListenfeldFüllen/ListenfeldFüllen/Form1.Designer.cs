namespace ListenfeldFüllen
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
            this.lstSpeisen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstSpeisen
            // 
            this.lstSpeisen.FormattingEnabled = true;
            this.lstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.lstSpeisen.Name = "lstSpeisen";
            this.lstSpeisen.Size = new System.Drawing.Size(120, 43);
            this.lstSpeisen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld füllen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lstSpeisen;
    }
}

