namespace MethodenÜbergabe
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
            this.cmdDreiDimFeld = new System.Windows.Forms.Button();
            this.cmdOut = new System.Windows.Forms.Button();
            this.cmdEinDimFeld = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdReferenz = new System.Windows.Forms.Button();
            this.cmdKopie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdDreiDimFeld
            // 
            this.cmdDreiDimFeld.Location = new System.Drawing.Point(182, 99);
            this.cmdDreiDimFeld.Name = "cmdDreiDimFeld";
            this.cmdDreiDimFeld.Size = new System.Drawing.Size(90, 23);
            this.cmdDreiDimFeld.TabIndex = 22;
            this.cmdDreiDimFeld.Text = "dreidim. Feld";
            this.cmdDreiDimFeld.UseVisualStyleBackColor = true;
            this.cmdDreiDimFeld.Click += new System.EventHandler(this.cmdDreiDimFeld_Click);
            // 
            // cmdOut
            // 
            this.cmdOut.Location = new System.Drawing.Point(182, 128);
            this.cmdOut.Name = "cmdOut";
            this.cmdOut.Size = new System.Drawing.Size(90, 23);
            this.cmdOut.TabIndex = 21;
            this.cmdOut.Text = "out";
            this.cmdOut.UseVisualStyleBackColor = true;
            this.cmdOut.Click += new System.EventHandler(this.cmdOut_Click);
            // 
            // cmdEinDimFeld
            // 
            this.cmdEinDimFeld.Location = new System.Drawing.Point(182, 70);
            this.cmdEinDimFeld.Name = "cmdEinDimFeld";
            this.cmdEinDimFeld.Size = new System.Drawing.Size(90, 23);
            this.cmdEinDimFeld.TabIndex = 20;
            this.cmdEinDimFeld.Text = "eindim. Feld";
            this.cmdEinDimFeld.UseVisualStyleBackColor = true;
            this.cmdEinDimFeld.Click += new System.EventHandler(this.cmdEinDimFeld_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 19;
            // 
            // cmdReferenz
            // 
            this.cmdReferenz.Location = new System.Drawing.Point(182, 41);
            this.cmdReferenz.Name = "cmdReferenz";
            this.cmdReferenz.Size = new System.Drawing.Size(90, 23);
            this.cmdReferenz.TabIndex = 18;
            this.cmdReferenz.Text = "Referenz";
            this.cmdReferenz.UseVisualStyleBackColor = true;
            this.cmdReferenz.Click += new System.EventHandler(this.cmdReferenz_Click);
            // 
            // cmdKopie
            // 
            this.cmdKopie.Location = new System.Drawing.Point(182, 12);
            this.cmdKopie.Name = "cmdKopie";
            this.cmdKopie.Size = new System.Drawing.Size(90, 23);
            this.cmdKopie.TabIndex = 17;
            this.cmdKopie.Text = "Kopie";
            this.cmdKopie.UseVisualStyleBackColor = true;
            this.cmdKopie.Click += new System.EventHandler(this.cmdKopie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdDreiDimFeld);
            this.Controls.Add(this.cmdOut);
            this.Controls.Add(this.cmdEinDimFeld);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdReferenz);
            this.Controls.Add(this.cmdKopie);
            this.Name = "Form1";
            this.Text = "Übergabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdDreiDimFeld;
        internal System.Windows.Forms.Button cmdOut;
        internal System.Windows.Forms.Button cmdEinDimFeld;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdReferenz;
        internal System.Windows.Forms.Button cmdKopie;
    }
}

