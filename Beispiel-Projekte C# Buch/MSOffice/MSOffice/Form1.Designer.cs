namespace MSOffice
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
            this.cmdExcel = new System.Windows.Forms.Button();
            this.cmdWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdExcel
            // 
            this.cmdExcel.Location = new System.Drawing.Point(12, 41);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(134, 23);
            this.cmdExcel.TabIndex = 6;
            this.cmdExcel.Text = "MS Excel Datei erstellen";
            this.cmdExcel.UseVisualStyleBackColor = true;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmdWord
            // 
            this.cmdWord.Location = new System.Drawing.Point(12, 12);
            this.cmdWord.Name = "cmdWord";
            this.cmdWord.Size = new System.Drawing.Size(134, 23);
            this.cmdWord.TabIndex = 5;
            this.cmdWord.Text = "MS Word Datei erstellen";
            this.cmdWord.UseVisualStyleBackColor = true;
            this.cmdWord.Click += new System.EventHandler(this.cmdWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdWord);
            this.Name = "Form1";
            this.Text = "MS Office";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdExcel;
        internal System.Windows.Forms.Button cmdWord;
    }
}

