namespace Optionen
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
            this.cmdSchalter = new System.Windows.Forms.Button();
            this.lblAnzeige2 = new System.Windows.Forms.Label();
            this.lblAnzeige1 = new System.Windows.Forms.Label();
            this.optFarbeBlau = new System.Windows.Forms.RadioButton();
            this.optFarbeGrün = new System.Windows.Forms.RadioButton();
            this.optFarbeRot = new System.Windows.Forms.RadioButton();
            this.cmdPrüfen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSchalter
            // 
            this.cmdSchalter.Location = new System.Drawing.Point(197, 110);
            this.cmdSchalter.Name = "cmdSchalter";
            this.cmdSchalter.Size = new System.Drawing.Size(75, 23);
            this.cmdSchalter.TabIndex = 27;
            this.cmdSchalter.Text = "Rot schalten";
            this.cmdSchalter.UseVisualStyleBackColor = true;
            this.cmdSchalter.Click += new System.EventHandler(this.cmdSchalter_Click);
            // 
            // lblAnzeige2
            // 
            this.lblAnzeige2.AutoSize = true;
            this.lblAnzeige2.Location = new System.Drawing.Point(18, 115);
            this.lblAnzeige2.Name = "lblAnzeige2";
            this.lblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige2.TabIndex = 26;
            // 
            // lblAnzeige1
            // 
            this.lblAnzeige1.AutoSize = true;
            this.lblAnzeige1.Location = new System.Drawing.Point(18, 17);
            this.lblAnzeige1.Name = "lblAnzeige1";
            this.lblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige1.TabIndex = 25;
            // 
            // optFarbeBlau
            // 
            this.optFarbeBlau.AutoSize = true;
            this.optFarbeBlau.Location = new System.Drawing.Point(197, 87);
            this.optFarbeBlau.Name = "optFarbeBlau";
            this.optFarbeBlau.Size = new System.Drawing.Size(46, 17);
            this.optFarbeBlau.TabIndex = 24;
            this.optFarbeBlau.Text = "Blau";
            this.optFarbeBlau.UseVisualStyleBackColor = true;
            this.optFarbeBlau.CheckedChanged += new System.EventHandler(this.optFarbeBlau_CheckedChanged);
            // 
            // optFarbeGrün
            // 
            this.optFarbeGrün.AutoSize = true;
            this.optFarbeGrün.Location = new System.Drawing.Point(197, 64);
            this.optFarbeGrün.Name = "optFarbeGrün";
            this.optFarbeGrün.Size = new System.Drawing.Size(48, 17);
            this.optFarbeGrün.TabIndex = 23;
            this.optFarbeGrün.Text = "Grün";
            this.optFarbeGrün.UseVisualStyleBackColor = true;
            this.optFarbeGrün.CheckedChanged += new System.EventHandler(this.optFarbeGrün_CheckedChanged);
            // 
            // optFarbeRot
            // 
            this.optFarbeRot.AutoSize = true;
            this.optFarbeRot.Checked = true;
            this.optFarbeRot.Location = new System.Drawing.Point(197, 41);
            this.optFarbeRot.Name = "optFarbeRot";
            this.optFarbeRot.Size = new System.Drawing.Size(42, 17);
            this.optFarbeRot.TabIndex = 22;
            this.optFarbeRot.TabStop = true;
            this.optFarbeRot.Text = "Rot";
            this.optFarbeRot.UseVisualStyleBackColor = true;
            this.optFarbeRot.CheckedChanged += new System.EventHandler(this.optFarbeRot_CheckedChanged);
            // 
            // cmdPrüfen
            // 
            this.cmdPrüfen.Location = new System.Drawing.Point(197, 12);
            this.cmdPrüfen.Name = "cmdPrüfen";
            this.cmdPrüfen.Size = new System.Drawing.Size(75, 23);
            this.cmdPrüfen.TabIndex = 21;
            this.cmdPrüfen.Text = "Prüfen";
            this.cmdPrüfen.UseVisualStyleBackColor = true;
            this.cmdPrüfen.Click += new System.EventHandler(this.cmdPrüfen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdSchalter);
            this.Controls.Add(this.lblAnzeige2);
            this.Controls.Add(this.lblAnzeige1);
            this.Controls.Add(this.optFarbeBlau);
            this.Controls.Add(this.optFarbeGrün);
            this.Controls.Add(this.optFarbeRot);
            this.Controls.Add(this.cmdPrüfen);
            this.Name = "Form1";
            this.Text = "Optionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdSchalter;
        internal System.Windows.Forms.Label lblAnzeige2;
        internal System.Windows.Forms.Label lblAnzeige1;
        internal System.Windows.Forms.RadioButton optFarbeBlau;
        internal System.Windows.Forms.RadioButton optFarbeGrün;
        internal System.Windows.Forms.RadioButton optFarbeRot;
        internal System.Windows.Forms.Button cmdPrüfen;
    }
}

