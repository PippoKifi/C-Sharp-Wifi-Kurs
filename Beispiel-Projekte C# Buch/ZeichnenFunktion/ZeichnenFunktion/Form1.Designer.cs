namespace ZeichnenFunktion
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
            this.cmdZeichnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdZeichnen
            // 
            this.cmdZeichnen.Location = new System.Drawing.Point(318, 247);
            this.cmdZeichnen.Margin = new System.Windows.Forms.Padding(2);
            this.cmdZeichnen.Name = "cmdZeichnen";
            this.cmdZeichnen.Size = new System.Drawing.Size(75, 23);
            this.cmdZeichnen.TabIndex = 4;
            this.cmdZeichnen.Text = "Zeichnen";
            this.cmdZeichnen.UseVisualStyleBackColor = true;
            this.cmdZeichnen.Click += new System.EventHandler(this.cmdZeichnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.cmdZeichnen);
            this.Name = "Form1";
            this.Text = "Funktion zeichnen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdZeichnen;
    }
}

