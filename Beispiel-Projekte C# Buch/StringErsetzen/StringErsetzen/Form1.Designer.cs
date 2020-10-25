namespace StringErsetzen
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
            this.txtErsetzen = new System.Windows.Forms.TextBox();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.lblErsetzen = new System.Windows.Forms.Label();
            this.lblSuchen = new System.Windows.Forms.Label();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdErsetzen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtErsetzen
            // 
            this.txtErsetzen.Location = new System.Drawing.Point(12, 171);
            this.txtErsetzen.Name = "txtErsetzen";
            this.txtErsetzen.Size = new System.Drawing.Size(50, 20);
            this.txtErsetzen.TabIndex = 78;
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(12, 132);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(50, 20);
            this.txtSuchen.TabIndex = 77;
            // 
            // lblErsetzen
            // 
            this.lblErsetzen.AutoSize = true;
            this.lblErsetzen.Location = new System.Drawing.Point(12, 155);
            this.lblErsetzen.Name = "lblErsetzen";
            this.lblErsetzen.Size = new System.Drawing.Size(37, 13);
            this.lblErsetzen.TabIndex = 76;
            this.lblErsetzen.Text = "durch:";
            // 
            // lblSuchen
            // 
            this.lblSuchen.AutoSize = true;
            this.lblSuchen.Location = new System.Drawing.Point(12, 116);
            this.lblSuchen.Name = "lblSuchen";
            this.lblSuchen.Size = new System.Drawing.Size(45, 13);
            this.lblSuchen.TabIndex = 75;
            this.lblSuchen.Text = "Ersetze:";
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(12, 9);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(49, 13);
            this.lblEingabe.TabIndex = 74;
            this.lblEingabe.Text = "Eingabe:";
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 61);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 73;
            // 
            // cmdErsetzen
            // 
            this.cmdErsetzen.Location = new System.Drawing.Point(12, 197);
            this.cmdErsetzen.Name = "cmdErsetzen";
            this.cmdErsetzen.Size = new System.Drawing.Size(75, 23);
            this.cmdErsetzen.TabIndex = 72;
            this.cmdErsetzen.Text = "Ersetzen";
            this.cmdErsetzen.UseVisualStyleBackColor = true;
            this.cmdErsetzen.Click += new System.EventHandler(this.cmdErsetzen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 25);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(150, 20);
            this.txtEingabe.TabIndex = 71;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtErsetzen);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.lblErsetzen);
            this.Controls.Add(this.lblSuchen);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdErsetzen);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Ersetzen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtErsetzen;
        internal System.Windows.Forms.TextBox txtSuchen;
        internal System.Windows.Forms.Label lblErsetzen;
        internal System.Windows.Forms.Label lblSuchen;
        internal System.Windows.Forms.Label lblEingabe;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdErsetzen;
        internal System.Windows.Forms.TextBox txtEingabe;
    }
}

