namespace DateiSchreiben
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
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.cmdSchreiben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 55);
            this.txtEingabe.Multiline = true;
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(200, 150);
            this.txtEingabe.TabIndex = 9;
            // 
            // cmdSchreiben
            // 
            this.cmdSchreiben.Location = new System.Drawing.Point(12, 12);
            this.cmdSchreiben.Name = "cmdSchreiben";
            this.cmdSchreiben.Size = new System.Drawing.Size(75, 23);
            this.cmdSchreiben.TabIndex = 8;
            this.cmdSchreiben.Text = "Schreiben";
            this.cmdSchreiben.UseVisualStyleBackColor = true;
            this.cmdSchreiben.Click += new System.EventHandler(this.cmdSchreiben_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.cmdSchreiben);
            this.Name = "Form1";
            this.Text = "Datei schreiben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtEingabe;
        internal System.Windows.Forms.Button cmdSchreiben;
    }
}

