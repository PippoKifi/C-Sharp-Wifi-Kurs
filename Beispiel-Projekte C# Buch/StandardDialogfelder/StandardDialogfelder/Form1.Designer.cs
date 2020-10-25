namespace StandardDialogfelder
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
            this.cmdFontDialog = new System.Windows.Forms.Button();
            this.cmdColorDialog = new System.Windows.Forms.Button();
            this.cmdFolderBrowserDialog = new System.Windows.Forms.Button();
            this.cmdSaveFileDialog = new System.Windows.Forms.Button();
            this.cmdOpenFileDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(19, 165);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(112, 13);
            this.lblA.TabIndex = 23;
            this.lblA.Text = "Das ist ein Beispieltext";
            // 
            // cmdFontDialog
            // 
            this.cmdFontDialog.Location = new System.Drawing.Point(12, 128);
            this.cmdFontDialog.Name = "cmdFontDialog";
            this.cmdFontDialog.Size = new System.Drawing.Size(150, 23);
            this.cmdFontDialog.TabIndex = 22;
            this.cmdFontDialog.Text = "Font Dialog";
            this.cmdFontDialog.UseVisualStyleBackColor = true;
            this.cmdFontDialog.Click += new System.EventHandler(this.cmdFontDialog_Click);
            // 
            // cmdColorDialog
            // 
            this.cmdColorDialog.Location = new System.Drawing.Point(12, 99);
            this.cmdColorDialog.Name = "cmdColorDialog";
            this.cmdColorDialog.Size = new System.Drawing.Size(150, 23);
            this.cmdColorDialog.TabIndex = 21;
            this.cmdColorDialog.Text = "Color Dialog";
            this.cmdColorDialog.UseVisualStyleBackColor = true;
            this.cmdColorDialog.Click += new System.EventHandler(this.cmdColorDialog_Click);
            // 
            // cmdFolderBrowserDialog
            // 
            this.cmdFolderBrowserDialog.Location = new System.Drawing.Point(12, 70);
            this.cmdFolderBrowserDialog.Name = "cmdFolderBrowserDialog";
            this.cmdFolderBrowserDialog.Size = new System.Drawing.Size(150, 23);
            this.cmdFolderBrowserDialog.TabIndex = 20;
            this.cmdFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.cmdFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.cmdFolderBrowserDialog.Click += new System.EventHandler(this.cmdFolderBrowserDialog_Click);
            // 
            // cmdSaveFileDialog
            // 
            this.cmdSaveFileDialog.Location = new System.Drawing.Point(12, 41);
            this.cmdSaveFileDialog.Name = "cmdSaveFileDialog";
            this.cmdSaveFileDialog.Size = new System.Drawing.Size(150, 23);
            this.cmdSaveFileDialog.TabIndex = 19;
            this.cmdSaveFileDialog.Text = "Save File Dialog";
            this.cmdSaveFileDialog.UseVisualStyleBackColor = true;
            this.cmdSaveFileDialog.Click += new System.EventHandler(this.cmdSaveFileDialog_Click);
            // 
            // cmdOpenFileDialog
            // 
            this.cmdOpenFileDialog.Location = new System.Drawing.Point(12, 12);
            this.cmdOpenFileDialog.Name = "cmdOpenFileDialog";
            this.cmdOpenFileDialog.Size = new System.Drawing.Size(150, 23);
            this.cmdOpenFileDialog.TabIndex = 18;
            this.cmdOpenFileDialog.Text = "Open File Dialog";
            this.cmdOpenFileDialog.UseVisualStyleBackColor = true;
            this.cmdOpenFileDialog.Click += new System.EventHandler(this.cmdOpenFileDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdFontDialog);
            this.Controls.Add(this.cmdColorDialog);
            this.Controls.Add(this.cmdFolderBrowserDialog);
            this.Controls.Add(this.cmdSaveFileDialog);
            this.Controls.Add(this.cmdOpenFileDialog);
            this.Name = "Form1";
            this.Text = "Standard-Dialogfelder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdFontDialog;
        internal System.Windows.Forms.Button cmdColorDialog;
        internal System.Windows.Forms.Button cmdFolderBrowserDialog;
        internal System.Windows.Forms.Button cmdSaveFileDialog;
        internal System.Windows.Forms.Button cmdOpenFileDialog;
    }
}

