namespace MethodeOhneEreignis
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
            this.optHotel = new System.Windows.Forms.RadioButton();
            this.optAppartement = new System.Windows.Forms.RadioButton();
            this.optParis = new System.Windows.Forms.RadioButton();
            this.grpUnterkunft = new System.Windows.Forms.GroupBox();
            this.optPension = new System.Windows.Forms.RadioButton();
            this.optRom = new System.Windows.Forms.RadioButton();
            this.grpOrt = new System.Windows.Forms.GroupBox();
            this.optBerlin = new System.Windows.Forms.RadioButton();
            this.grpUnterkunft.SuspendLayout();
            this.grpOrt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(21, 19);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(77, 13);
            this.lblAnzeige.TabIndex = 20;
            this.lblAnzeige.Text = "Berlin, Pension";
            // 
            // optHotel
            // 
            this.optHotel.AutoSize = true;
            this.optHotel.Location = new System.Drawing.Point(17, 65);
            this.optHotel.Name = "optHotel";
            this.optHotel.Size = new System.Drawing.Size(50, 17);
            this.optHotel.TabIndex = 8;
            this.optHotel.Text = "Hotel";
            this.optHotel.UseVisualStyleBackColor = true;
            this.optHotel.Click += new System.EventHandler(this.optUnterkunft);
            // 
            // optAppartement
            // 
            this.optAppartement.AutoSize = true;
            this.optAppartement.Location = new System.Drawing.Point(17, 19);
            this.optAppartement.Name = "optAppartement";
            this.optAppartement.Size = new System.Drawing.Size(85, 17);
            this.optAppartement.TabIndex = 6;
            this.optAppartement.Text = "Appartement";
            this.optAppartement.UseVisualStyleBackColor = true;
            this.optAppartement.Click += new System.EventHandler(this.optUnterkunft);
            // 
            // optParis
            // 
            this.optParis.AutoSize = true;
            this.optParis.Location = new System.Drawing.Point(20, 42);
            this.optParis.Name = "optParis";
            this.optParis.Size = new System.Drawing.Size(48, 17);
            this.optParis.TabIndex = 4;
            this.optParis.Text = "Paris";
            this.optParis.UseVisualStyleBackColor = true;
            this.optParis.Click += new System.EventHandler(this.optUrlaubsort);
            // 
            // grpUnterkunft
            // 
            this.grpUnterkunft.Controls.Add(this.optHotel);
            this.grpUnterkunft.Controls.Add(this.optPension);
            this.grpUnterkunft.Controls.Add(this.optAppartement);
            this.grpUnterkunft.Location = new System.Drawing.Point(152, 49);
            this.grpUnterkunft.Name = "grpUnterkunft";
            this.grpUnterkunft.Size = new System.Drawing.Size(120, 100);
            this.grpUnterkunft.TabIndex = 21;
            this.grpUnterkunft.TabStop = false;
            this.grpUnterkunft.Text = "Unterkunft";
            // 
            // optPension
            // 
            this.optPension.AutoSize = true;
            this.optPension.Checked = true;
            this.optPension.Location = new System.Drawing.Point(17, 42);
            this.optPension.Name = "optPension";
            this.optPension.Size = new System.Drawing.Size(63, 17);
            this.optPension.TabIndex = 7;
            this.optPension.TabStop = true;
            this.optPension.Text = "Pension";
            this.optPension.UseVisualStyleBackColor = true;
            this.optPension.Click += new System.EventHandler(this.optUnterkunft);
            // 
            // optRom
            // 
            this.optRom.AutoSize = true;
            this.optRom.Location = new System.Drawing.Point(20, 65);
            this.optRom.Name = "optRom";
            this.optRom.Size = new System.Drawing.Size(47, 17);
            this.optRom.TabIndex = 5;
            this.optRom.Text = "Rom";
            this.optRom.UseVisualStyleBackColor = true;
            this.optRom.Click += new System.EventHandler(this.optUrlaubsort);
            // 
            // grpOrt
            // 
            this.grpOrt.Controls.Add(this.optRom);
            this.grpOrt.Controls.Add(this.optParis);
            this.grpOrt.Controls.Add(this.optBerlin);
            this.grpOrt.Location = new System.Drawing.Point(12, 49);
            this.grpOrt.Name = "grpOrt";
            this.grpOrt.Size = new System.Drawing.Size(120, 100);
            this.grpOrt.TabIndex = 19;
            this.grpOrt.TabStop = false;
            this.grpOrt.Text = "Urlaubsort";
            // 
            // optBerlin
            // 
            this.optBerlin.AutoSize = true;
            this.optBerlin.Checked = true;
            this.optBerlin.Location = new System.Drawing.Point(20, 19);
            this.optBerlin.Name = "optBerlin";
            this.optBerlin.Size = new System.Drawing.Size(51, 17);
            this.optBerlin.TabIndex = 3;
            this.optBerlin.TabStop = true;
            this.optBerlin.Text = "Berlin";
            this.optBerlin.UseVisualStyleBackColor = true;
            this.optBerlin.Click += new System.EventHandler(this.optUrlaubsort);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.grpUnterkunft);
            this.Controls.Add(this.grpOrt);
            this.Name = "Form1";
            this.Text = "Methode ohne Ereignis";
            this.grpUnterkunft.ResumeLayout(false);
            this.grpUnterkunft.PerformLayout();
            this.grpOrt.ResumeLayout(false);
            this.grpOrt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.RadioButton optHotel;
        internal System.Windows.Forms.RadioButton optAppartement;
        internal System.Windows.Forms.RadioButton optParis;
        internal System.Windows.Forms.GroupBox grpUnterkunft;
        internal System.Windows.Forms.RadioButton optPension;
        internal System.Windows.Forms.RadioButton optRom;
        internal System.Windows.Forms.GroupBox grpOrt;
        internal System.Windows.Forms.RadioButton optBerlin;
    }
}

