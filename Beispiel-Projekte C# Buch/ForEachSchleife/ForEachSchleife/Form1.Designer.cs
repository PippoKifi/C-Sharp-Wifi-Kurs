namespace ForEachSchleife
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
            this.cmdSteuerelemente = new System.Windows.Forms.Button();
            this.lstLand = new System.Windows.Forms.ListBox();
            this.cmdListBox = new System.Windows.Forms.Button();
            this.cmdArrayList = new System.Windows.Forms.Button();
            this.cmdDatenfeld = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSteuerelemente
            // 
            this.cmdSteuerelemente.Location = new System.Drawing.Point(158, 99);
            this.cmdSteuerelemente.Name = "cmdSteuerelemente";
            this.cmdSteuerelemente.Size = new System.Drawing.Size(112, 23);
            this.cmdSteuerelemente.TabIndex = 11;
            this.cmdSteuerelemente.Text = "Steuerelemente";
            this.cmdSteuerelemente.UseVisualStyleBackColor = true;
            this.cmdSteuerelemente.Click += new System.EventHandler(this.cmdSteuerelemente_Click);
            // 
            // lstLand
            // 
            this.lstLand.FormattingEnabled = true;
            this.lstLand.Location = new System.Drawing.Point(152, 154);
            this.lstLand.Name = "lstLand";
            this.lstLand.Size = new System.Drawing.Size(120, 95);
            this.lstLand.TabIndex = 10;
            // 
            // cmdListBox
            // 
            this.cmdListBox.Location = new System.Drawing.Point(197, 70);
            this.cmdListBox.Name = "cmdListBox";
            this.cmdListBox.Size = new System.Drawing.Size(75, 23);
            this.cmdListBox.TabIndex = 9;
            this.cmdListBox.Text = "ListBox";
            this.cmdListBox.UseVisualStyleBackColor = true;
            this.cmdListBox.Click += new System.EventHandler(this.cmdListBox_Click);
            // 
            // cmdArrayList
            // 
            this.cmdArrayList.Location = new System.Drawing.Point(197, 41);
            this.cmdArrayList.Name = "cmdArrayList";
            this.cmdArrayList.Size = new System.Drawing.Size(75, 23);
            this.cmdArrayList.TabIndex = 8;
            this.cmdArrayList.Text = "ArrayList";
            this.cmdArrayList.UseVisualStyleBackColor = true;
            this.cmdArrayList.Click += new System.EventHandler(this.cmdArrayList_Click);
            // 
            // cmdDatenfeld
            // 
            this.cmdDatenfeld.Location = new System.Drawing.Point(197, 12);
            this.cmdDatenfeld.Name = "cmdDatenfeld";
            this.cmdDatenfeld.Size = new System.Drawing.Size(75, 23);
            this.cmdDatenfeld.TabIndex = 7;
            this.cmdDatenfeld.Text = "Datenfeld";
            this.cmdDatenfeld.UseVisualStyleBackColor = true;
            this.cmdDatenfeld.Click += new System.EventHandler(this.cmdDatenfeld_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(11, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdSteuerelemente);
            this.Controls.Add(this.lstLand);
            this.Controls.Add(this.cmdListBox);
            this.Controls.Add(this.cmdArrayList);
            this.Controls.Add(this.cmdDatenfeld);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "For-Each-Schleife";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSteuerelemente;
        private System.Windows.Forms.ListBox lstLand;
        private System.Windows.Forms.Button cmdListBox;
        private System.Windows.Forms.Button cmdArrayList;
        private System.Windows.Forms.Button cmdDatenfeld;
        private System.Windows.Forms.Label lblA;
    }
}

