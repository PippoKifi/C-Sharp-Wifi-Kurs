namespace StringTeilzeichenkette
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
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.lblLänge = new System.Windows.Forms.Label();
            this.numLänge = new System.Windows.Forms.NumericUpDown();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdAnzeigen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLänge)).BeginInit();
            this.SuspendLayout();
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(12, 132);
            this.numPosition.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(100, 20);
            this.numPosition.TabIndex = 69;
            this.numPosition.ValueChanged += new System.EventHandler(this.numPosition_ValueChanged);
            // 
            // lblLänge
            // 
            this.lblLänge.AutoSize = true;
            this.lblLänge.Location = new System.Drawing.Point(12, 155);
            this.lblLänge.Name = "lblLänge";
            this.lblLänge.Size = new System.Drawing.Size(40, 13);
            this.lblLänge.TabIndex = 68;
            this.lblLänge.Text = "Länge:";
            // 
            // numLänge
            // 
            this.numLänge.Location = new System.Drawing.Point(12, 171);
            this.numLänge.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numLänge.Name = "numLänge";
            this.numLänge.Size = new System.Drawing.Size(100, 20);
            this.numLänge.TabIndex = 67;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 116);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(107, 13);
            this.lblPosition.TabIndex = 66;
            this.lblPosition.Text = "Teilstring ab Position:";
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(12, 9);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(49, 13);
            this.lblEingabe.TabIndex = 65;
            this.lblEingabe.Text = "Eingabe:";
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 61);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 64;
            // 
            // cmdAnzeigen
            // 
            this.cmdAnzeigen.Location = new System.Drawing.Point(12, 197);
            this.cmdAnzeigen.Name = "cmdAnzeigen";
            this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen.TabIndex = 63;
            this.cmdAnzeigen.Text = "Anzeigen";
            this.cmdAnzeigen.UseVisualStyleBackColor = true;
            this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 25);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(150, 20);
            this.txtEingabe.TabIndex = 62;
            this.txtEingabe.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.lblLänge);
            this.Controls.Add(this.numLänge);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeigen);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Teilzeichenkette";
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLänge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown numPosition;
        internal System.Windows.Forms.Label lblLänge;
        internal System.Windows.Forms.NumericUpDown numLänge;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label lblEingabe;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdAnzeigen;
        internal System.Windows.Forms.TextBox txtEingabe;
    }
}

