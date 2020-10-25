namespace MehrereEreignisse
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
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.optFarbeBlau = new System.Windows.Forms.RadioButton();
            this.optFarbeGrün = new System.Windows.Forms.RadioButton();
            this.optFarbeRot = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(11, 15);
            this.lblAnzeige.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(24, 13);
            this.lblAnzeige.TabIndex = 7;
            this.lblAnzeige.Text = "Rot";
            // 
            // optFarbeBlau
            // 
            this.optFarbeBlau.AutoSize = true;
            this.optFarbeBlau.Location = new System.Drawing.Point(225, 55);
            this.optFarbeBlau.Margin = new System.Windows.Forms.Padding(2);
            this.optFarbeBlau.Name = "optFarbeBlau";
            this.optFarbeBlau.Size = new System.Drawing.Size(46, 17);
            this.optFarbeBlau.TabIndex = 6;
            this.optFarbeBlau.Text = "Blau";
            this.optFarbeBlau.UseVisualStyleBackColor = true;
            this.optFarbeBlau.Click += new System.EventHandler(this.optFarbeGewechselt);
            // 
            // optFarbeGrün
            // 
            this.optFarbeGrün.AutoSize = true;
            this.optFarbeGrün.Location = new System.Drawing.Point(225, 33);
            this.optFarbeGrün.Margin = new System.Windows.Forms.Padding(2);
            this.optFarbeGrün.Name = "optFarbeGrün";
            this.optFarbeGrün.Size = new System.Drawing.Size(48, 17);
            this.optFarbeGrün.TabIndex = 5;
            this.optFarbeGrün.Text = "Grün";
            this.optFarbeGrün.UseVisualStyleBackColor = true;
            this.optFarbeGrün.Click += new System.EventHandler(this.optFarbeGewechselt);
            // 
            // optFarbeRot
            // 
            this.optFarbeRot.AutoSize = true;
            this.optFarbeRot.Checked = true;
            this.optFarbeRot.Location = new System.Drawing.Point(225, 11);
            this.optFarbeRot.Margin = new System.Windows.Forms.Padding(2);
            this.optFarbeRot.Name = "optFarbeRot";
            this.optFarbeRot.Size = new System.Drawing.Size(42, 17);
            this.optFarbeRot.TabIndex = 4;
            this.optFarbeRot.TabStop = true;
            this.optFarbeRot.Text = "Rot";
            this.optFarbeRot.UseVisualStyleBackColor = true;
            this.optFarbeRot.Click += new System.EventHandler(this.optFarbeGewechselt);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.optFarbeBlau);
            this.Controls.Add(this.optFarbeGrün);
            this.Controls.Add(this.optFarbeRot);
            this.Name = "Form1";
            this.Text = "Mehrere Ereignisse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.RadioButton optFarbeBlau;
        private System.Windows.Forms.RadioButton optFarbeGrün;
        private System.Windows.Forms.RadioButton optFarbeRot;
    }
}

