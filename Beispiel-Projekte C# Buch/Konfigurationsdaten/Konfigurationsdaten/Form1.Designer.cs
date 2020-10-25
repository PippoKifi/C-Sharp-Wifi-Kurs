namespace Konfigurationsdaten
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
            this.lstTab = new System.Windows.Forms.ListBox();
            this.cmdAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.Location = new System.Drawing.Point(12, 115);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(318, 134);
            this.lstTab.TabIndex = 3;
            // 
            // cmdAnzeigen
            // 
            this.cmdAnzeigen.Location = new System.Drawing.Point(12, 12);
            this.cmdAnzeigen.Name = "cmdAnzeigen";
            this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen.TabIndex = 2;
            this.cmdAnzeigen.Text = "Anzeigen";
            this.cmdAnzeigen.UseVisualStyleBackColor = true;
            this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.lstTab);
            this.Controls.Add(this.cmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Konfigurationsdaten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTab;
        private System.Windows.Forms.Button cmdAnzeigen;
    }
}

