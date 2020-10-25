namespace ÜEnabled
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
            this.cmdLöschen = new System.Windows.Forms.Button();
            this.lstLand = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Enabled = false;
            this.cmdLöschen.Location = new System.Drawing.Point(118, 12);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(75, 23);
            this.cmdLöschen.TabIndex = 7;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // lstLand
            // 
            this.lstLand.FormattingEnabled = true;
            this.lstLand.Location = new System.Drawing.Point(12, 12);
            this.lstLand.Name = "lstLand";
            this.lstLand.Size = new System.Drawing.Size(100, 173);
            this.lstLand.TabIndex = 6;
            this.lstLand.SelectedIndexChanged += new System.EventHandler(this.lstLand_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.lstLand);
            this.Name = "Form1";
            this.Text = "Enabled";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdLöschen;
        internal System.Windows.Forms.ListBox lstLand;
    }
}

