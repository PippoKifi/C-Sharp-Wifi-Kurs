namespace ListenfeldEigenschaften
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
            this.lblAnzeige4 = new System.Windows.Forms.Label();
            this.lblAnzeige3 = new System.Windows.Forms.Label();
            this.lblAnzeige2 = new System.Windows.Forms.Label();
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.lblAnzeige1 = new System.Windows.Forms.Label();
            this.lstSpeisen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAnzeige4
            // 
            this.lblAnzeige4.AutoSize = true;
            this.lblAnzeige4.Location = new System.Drawing.Point(12, 198);
            this.lblAnzeige4.Name = "lblAnzeige4";
            this.lblAnzeige4.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige4.TabIndex = 23;
            // 
            // lblAnzeige3
            // 
            this.lblAnzeige3.AutoSize = true;
            this.lblAnzeige3.Location = new System.Drawing.Point(12, 171);
            this.lblAnzeige3.Name = "lblAnzeige3";
            this.lblAnzeige3.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige3.TabIndex = 22;
            // 
            // lblAnzeige2
            // 
            this.lblAnzeige2.AutoSize = true;
            this.lblAnzeige2.Location = new System.Drawing.Point(12, 148);
            this.lblAnzeige2.Name = "lblAnzeige2";
            this.lblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige2.TabIndex = 21;
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(247, 12);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige.TabIndex = 20;
            this.cmdAnzeige.Text = "Anzeige";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // lblAnzeige1
            // 
            this.lblAnzeige1.AutoSize = true;
            this.lblAnzeige1.Location = new System.Drawing.Point(12, 123);
            this.lblAnzeige1.Name = "lblAnzeige1";
            this.lblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige1.TabIndex = 19;
            // 
            // lstSpeisen
            // 
            this.lstSpeisen.FormattingEnabled = true;
            this.lstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.lstSpeisen.Name = "lstSpeisen";
            this.lstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.lstSpeisen.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.lblAnzeige4);
            this.Controls.Add(this.lblAnzeige3);
            this.Controls.Add(this.lblAnzeige2);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.lblAnzeige1);
            this.Controls.Add(this.lstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Eigenschaften";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAnzeige4;
        internal System.Windows.Forms.Label lblAnzeige3;
        internal System.Windows.Forms.Label lblAnzeige2;
        internal System.Windows.Forms.Button cmdAnzeige;
        internal System.Windows.Forms.Label lblAnzeige1;
        internal System.Windows.Forms.ListBox lstSpeisen;
    }
}

