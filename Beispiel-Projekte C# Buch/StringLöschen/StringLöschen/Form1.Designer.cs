namespace StringLöschen
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
            this.lblZeichen = new System.Windows.Forms.Label();
            this.numAnzahl = new System.Windows.Forms.NumericUpDown();
            this.lblPosition = new System.Windows.Forms.Label();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.lblLöschen = new System.Windows.Forms.Label();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdLöschen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZeichen
            // 
            this.lblZeichen.AutoSize = true;
            this.lblZeichen.Location = new System.Drawing.Point(118, 139);
            this.lblZeichen.Name = "lblZeichen";
            this.lblZeichen.Size = new System.Drawing.Size(46, 13);
            this.lblZeichen.TabIndex = 64;
            this.lblZeichen.Text = "Zeichen";
            // 
            // numAnzahl
            // 
            this.numAnzahl.Location = new System.Drawing.Point(12, 132);
            this.numAnzahl.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numAnzahl.Name = "numAnzahl";
            this.numAnzahl.Size = new System.Drawing.Size(100, 20);
            this.numAnzahl.TabIndex = 63;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 155);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(62, 13);
            this.lblPosition.TabIndex = 62;
            this.lblPosition.Text = "ab Position:";
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(12, 171);
            this.numPosition.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(100, 20);
            this.numPosition.TabIndex = 61;
            this.numPosition.ValueChanged += new System.EventHandler(this.numPosition_ValueChanged);
            // 
            // lblLöschen
            // 
            this.lblLöschen.AutoSize = true;
            this.lblLöschen.Location = new System.Drawing.Point(12, 116);
            this.lblLöschen.Name = "lblLöschen";
            this.lblLöschen.Size = new System.Drawing.Size(45, 13);
            this.lblLöschen.TabIndex = 60;
            this.lblLöschen.Text = "Lösche:";
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(12, 9);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(49, 13);
            this.lblEingabe.TabIndex = 59;
            this.lblEingabe.Text = "Eingabe:";
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 61);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 58;
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Location = new System.Drawing.Point(12, 197);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(75, 23);
            this.cmdLöschen.TabIndex = 57;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 25);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(150, 20);
            this.txtEingabe.TabIndex = 56;
            this.txtEingabe.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblZeichen);
            this.Controls.Add(this.numAnzahl);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.lblLöschen);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Löschen";
            ((System.ComponentModel.ISupportInitialize)(this.numAnzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblZeichen;
        internal System.Windows.Forms.NumericUpDown numAnzahl;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.NumericUpDown numPosition;
        internal System.Windows.Forms.Label lblLöschen;
        internal System.Windows.Forms.Label lblEingabe;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdLöschen;
        internal System.Windows.Forms.TextBox txtEingabe;
    }
}

