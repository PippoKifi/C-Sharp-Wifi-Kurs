namespace EreignisEnter
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
            this.optÜberweisung = new System.Windows.Forms.RadioButton();
            this.lstPaketdienst = new System.Windows.Forms.ListBox();
            this.lblHilfe = new System.Windows.Forms.Label();
            this.optLastschrift = new System.Windows.Forms.RadioButton();
            this.optKreditkarte = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkKunde = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // optÜberweisung
            // 
            this.optÜberweisung.AutoSize = true;
            this.optÜberweisung.Location = new System.Drawing.Point(12, 107);
            this.optÜberweisung.Name = "optÜberweisung";
            this.optÜberweisung.Size = new System.Drawing.Size(87, 17);
            this.optÜberweisung.TabIndex = 34;
            this.optÜberweisung.Text = "Überweisung";
            this.optÜberweisung.UseVisualStyleBackColor = true;
            this.optÜberweisung.CheckedChanged += new System.EventHandler(this.optZahlungsform_CheckedChanged);
            // 
            // lstPaketdienst
            // 
            this.lstPaketdienst.FormattingEnabled = true;
            this.lstPaketdienst.Location = new System.Drawing.Point(12, 130);
            this.lstPaketdienst.Name = "lstPaketdienst";
            this.lstPaketdienst.Size = new System.Drawing.Size(100, 56);
            this.lstPaketdienst.TabIndex = 33;
            this.lstPaketdienst.Enter += new System.EventHandler(this.lstPaketdienst_Enter);
            // 
            // lblHilfe
            // 
            this.lblHilfe.AutoSize = true;
            this.lblHilfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHilfe.ForeColor = System.Drawing.Color.Red;
            this.lblHilfe.Location = new System.Drawing.Point(21, 201);
            this.lblHilfe.Name = "lblHilfe";
            this.lblHilfe.Size = new System.Drawing.Size(0, 13);
            this.lblHilfe.TabIndex = 32;
            // 
            // optLastschrift
            // 
            this.optLastschrift.AutoSize = true;
            this.optLastschrift.Location = new System.Drawing.Point(12, 84);
            this.optLastschrift.Name = "optLastschrift";
            this.optLastschrift.Size = new System.Drawing.Size(73, 17);
            this.optLastschrift.TabIndex = 31;
            this.optLastschrift.Text = "Lastschrift";
            this.optLastschrift.UseVisualStyleBackColor = true;
            this.optLastschrift.CheckedChanged += new System.EventHandler(this.optZahlungsform_CheckedChanged);
            // 
            // optKreditkarte
            // 
            this.optKreditkarte.AutoSize = true;
            this.optKreditkarte.Checked = true;
            this.optKreditkarte.Location = new System.Drawing.Point(12, 61);
            this.optKreditkarte.Name = "optKreditkarte";
            this.optKreditkarte.Size = new System.Drawing.Size(76, 17);
            this.optKreditkarte.TabIndex = 30;
            this.optKreditkarte.TabStop = true;
            this.optKreditkarte.Text = "Kreditkarte";
            this.optKreditkarte.UseVisualStyleBackColor = true;
            this.optKreditkarte.CheckedChanged += new System.EventHandler(this.optZahlungsform_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 29;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // chkKunde
            // 
            this.chkKunde.AutoSize = true;
            this.chkKunde.Location = new System.Drawing.Point(14, 38);
            this.chkKunde.Name = "chkKunde";
            this.chkKunde.Size = new System.Drawing.Size(97, 17);
            this.chkKunde.TabIndex = 28;
            this.chkKunde.Text = "bereits Kunde?";
            this.chkKunde.UseVisualStyleBackColor = true;
            this.chkKunde.Enter += new System.EventHandler(this.chkKunde_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.optÜberweisung);
            this.Controls.Add(this.lstPaketdienst);
            this.Controls.Add(this.lblHilfe);
            this.Controls.Add(this.optLastschrift);
            this.Controls.Add(this.optKreditkarte);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chkKunde);
            this.Name = "Form1";
            this.Text = "Ereignis Enter";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton optÜberweisung;
        internal System.Windows.Forms.ListBox lstPaketdienst;
        internal System.Windows.Forms.Label lblHilfe;
        internal System.Windows.Forms.RadioButton optLastschrift;
        internal System.Windows.Forms.RadioButton optKreditkarte;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.CheckBox chkKunde;
    }
}

