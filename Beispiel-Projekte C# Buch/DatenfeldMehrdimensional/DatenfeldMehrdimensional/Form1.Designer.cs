namespace DatenfeldMehrdimensional
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
            this.cmdInit = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.lstSpalte2 = new System.Windows.Forms.ListBox();
            this.lstSpalte1 = new System.Windows.Forms.ListBox();
            this.lstSpalte0 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(247, 41);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(75, 23);
            this.cmdInit.TabIndex = 23;
            this.cmdInit.Text = "Initialisieren";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(192, 130);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 22;
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(247, 12);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige.TabIndex = 21;
            this.cmdAnzeige.Text = "Anzeige";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // lstSpalte2
            // 
            this.lstSpalte2.FormattingEnabled = true;
            this.lstSpalte2.Location = new System.Drawing.Point(126, 12);
            this.lstSpalte2.Name = "lstSpalte2";
            this.lstSpalte2.Size = new System.Drawing.Size(51, 134);
            this.lstSpalte2.TabIndex = 20;
            this.lstSpalte2.Click += new System.EventHandler(this.lstSpalte2_Click);
            // 
            // lstSpalte1
            // 
            this.lstSpalte1.FormattingEnabled = true;
            this.lstSpalte1.Location = new System.Drawing.Point(69, 12);
            this.lstSpalte1.Name = "lstSpalte1";
            this.lstSpalte1.Size = new System.Drawing.Size(51, 134);
            this.lstSpalte1.TabIndex = 19;
            this.lstSpalte1.Click += new System.EventHandler(this.lstSpalte1_Click);
            // 
            // lstSpalte0
            // 
            this.lstSpalte0.FormattingEnabled = true;
            this.lstSpalte0.Location = new System.Drawing.Point(12, 12);
            this.lstSpalte0.Name = "lstSpalte0";
            this.lstSpalte0.Size = new System.Drawing.Size(51, 134);
            this.lstSpalte0.TabIndex = 18;
            this.lstSpalte0.Click += new System.EventHandler(this.lstSpalte0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.lstSpalte2);
            this.Controls.Add(this.lstSpalte1);
            this.Controls.Add(this.lstSpalte0);
            this.Name = "Form1";
            this.Text = "Datenfeld, mehrdimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdInit;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdAnzeige;
        internal System.Windows.Forms.ListBox lstSpalte2;
        internal System.Windows.Forms.ListBox lstSpalte1;
        internal System.Windows.Forms.ListBox lstSpalte0;
    }
}

