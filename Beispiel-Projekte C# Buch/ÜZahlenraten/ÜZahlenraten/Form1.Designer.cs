namespace ÜZahlenraten
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
            this.cmdErzeugen = new System.Windows.Forms.Button();
            this.cmdPrüfen = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdErzeugen
            // 
            this.cmdErzeugen.Location = new System.Drawing.Point(217, 12);
            this.cmdErzeugen.Name = "cmdErzeugen";
            this.cmdErzeugen.Size = new System.Drawing.Size(75, 23);
            this.cmdErzeugen.TabIndex = 21;
            this.cmdErzeugen.Text = "Erzeugen";
            this.cmdErzeugen.UseVisualStyleBackColor = true;
            this.cmdErzeugen.Click += new System.EventHandler(this.cmdErzeugen_Click);
            // 
            // cmdPrüfen
            // 
            this.cmdPrüfen.Location = new System.Drawing.Point(217, 41);
            this.cmdPrüfen.Name = "cmdPrüfen";
            this.cmdPrüfen.Size = new System.Drawing.Size(75, 23);
            this.cmdPrüfen.TabIndex = 20;
            this.cmdPrüfen.Text = "Prüfen";
            this.cmdPrüfen.UseVisualStyleBackColor = true;
            this.cmdPrüfen.Click += new System.EventHandler(this.cmdPrüfen_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(17, 78);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 19;
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(111, 43);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe.TabIndex = 18;
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(12, 46);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(49, 13);
            this.lblEingabe.TabIndex = 17;
            this.lblEingabe.Text = "Eingabe:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.cmdErzeugen);
            this.Controls.Add(this.cmdPrüfen);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.lblEingabe);
            this.Name = "Form1";
            this.Text = "Zahl zwischen 1 und 100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdErzeugen;
        internal System.Windows.Forms.Button cmdPrüfen;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.TextBox txtEingabe;
        internal System.Windows.Forms.Label lblEingabe;
    }
}

