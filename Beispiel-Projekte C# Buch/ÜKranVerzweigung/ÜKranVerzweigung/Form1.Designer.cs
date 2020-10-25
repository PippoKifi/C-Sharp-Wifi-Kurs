namespace ÜKranVerzweigung
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
            this.cmdKranEin = new System.Windows.Forms.Button();
            this.cmdKranAus = new System.Windows.Forms.Button();
            this.cmdKranLinks = new System.Windows.Forms.Button();
            this.cmdKranRechts = new System.Windows.Forms.Button();
            this.cmdAuslegerEin = new System.Windows.Forms.Button();
            this.cmdAuslegerAus = new System.Windows.Forms.Button();
            this.cmdHakenEin = new System.Windows.Forms.Button();
            this.cmdHakenAus = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Panel();
            this.s = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdKranEin
            // 
            this.cmdKranEin.Location = new System.Drawing.Point(272, 215);
            this.cmdKranEin.Name = "cmdKranEin";
            this.cmdKranEin.Size = new System.Drawing.Size(100, 23);
            this.cmdKranEin.TabIndex = 61;
            this.cmdKranEin.Text = "Kran ein";
            this.cmdKranEin.UseVisualStyleBackColor = true;
            this.cmdKranEin.Click += new System.EventHandler(this.cmdKranEin_Click);
            // 
            // cmdKranAus
            // 
            this.cmdKranAus.Location = new System.Drawing.Point(272, 186);
            this.cmdKranAus.Name = "cmdKranAus";
            this.cmdKranAus.Size = new System.Drawing.Size(100, 23);
            this.cmdKranAus.TabIndex = 60;
            this.cmdKranAus.Text = "Kran aus";
            this.cmdKranAus.UseVisualStyleBackColor = true;
            this.cmdKranAus.Click += new System.EventHandler(this.cmdKranAus_Click);
            // 
            // cmdKranLinks
            // 
            this.cmdKranLinks.Location = new System.Drawing.Point(272, 157);
            this.cmdKranLinks.Name = "cmdKranLinks";
            this.cmdKranLinks.Size = new System.Drawing.Size(100, 23);
            this.cmdKranLinks.TabIndex = 59;
            this.cmdKranLinks.Text = "Kran links";
            this.cmdKranLinks.UseVisualStyleBackColor = true;
            this.cmdKranLinks.Click += new System.EventHandler(this.cmdKranLinks_Click);
            // 
            // cmdKranRechts
            // 
            this.cmdKranRechts.Location = new System.Drawing.Point(272, 128);
            this.cmdKranRechts.Name = "cmdKranRechts";
            this.cmdKranRechts.Size = new System.Drawing.Size(100, 23);
            this.cmdKranRechts.TabIndex = 58;
            this.cmdKranRechts.Text = "Kran rechts";
            this.cmdKranRechts.UseVisualStyleBackColor = true;
            this.cmdKranRechts.Click += new System.EventHandler(this.cmdKranRechts_Click);
            // 
            // cmdAuslegerEin
            // 
            this.cmdAuslegerEin.Location = new System.Drawing.Point(272, 99);
            this.cmdAuslegerEin.Name = "cmdAuslegerEin";
            this.cmdAuslegerEin.Size = new System.Drawing.Size(100, 23);
            this.cmdAuslegerEin.TabIndex = 57;
            this.cmdAuslegerEin.Text = "Ausleger ein";
            this.cmdAuslegerEin.UseVisualStyleBackColor = true;
            this.cmdAuslegerEin.Click += new System.EventHandler(this.cmdAuslegerEin_Click);
            // 
            // cmdAuslegerAus
            // 
            this.cmdAuslegerAus.Location = new System.Drawing.Point(272, 70);
            this.cmdAuslegerAus.Name = "cmdAuslegerAus";
            this.cmdAuslegerAus.Size = new System.Drawing.Size(100, 23);
            this.cmdAuslegerAus.TabIndex = 56;
            this.cmdAuslegerAus.Text = "Ausleger aus";
            this.cmdAuslegerAus.UseVisualStyleBackColor = true;
            this.cmdAuslegerAus.Click += new System.EventHandler(this.cmdAuslegerAus_Click);
            // 
            // cmdHakenEin
            // 
            this.cmdHakenEin.Location = new System.Drawing.Point(272, 41);
            this.cmdHakenEin.Name = "cmdHakenEin";
            this.cmdHakenEin.Size = new System.Drawing.Size(100, 23);
            this.cmdHakenEin.TabIndex = 55;
            this.cmdHakenEin.Text = "Haken ein";
            this.cmdHakenEin.UseVisualStyleBackColor = true;
            this.cmdHakenEin.Click += new System.EventHandler(this.cmdHakenEin_Click);
            // 
            // cmdHakenAus
            // 
            this.cmdHakenAus.Location = new System.Drawing.Point(272, 12);
            this.cmdHakenAus.Name = "cmdHakenAus";
            this.cmdHakenAus.Size = new System.Drawing.Size(100, 23);
            this.cmdHakenAus.TabIndex = 51;
            this.cmdHakenAus.Text = "Haken aus";
            this.cmdHakenAus.UseVisualStyleBackColor = true;
            this.cmdHakenAus.Click += new System.EventHandler(this.cmdHakenAus_Click);
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.Fuchsia;
            this.h.Location = new System.Drawing.Point(102, 110);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(10, 20);
            this.h.TabIndex = 54;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Yellow;
            this.s.Location = new System.Drawing.Point(147, 100);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(20, 120);
            this.s.TabIndex = 52;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Blue;
            this.a.Location = new System.Drawing.Point(102, 100);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(50, 10);
            this.a.TabIndex = 53;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Red;
            this.f.Location = new System.Drawing.Point(132, 220);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(50, 10);
            this.f.TabIndex = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.cmdKranEin);
            this.Controls.Add(this.cmdKranAus);
            this.Controls.Add(this.cmdKranLinks);
            this.Controls.Add(this.cmdKranRechts);
            this.Controls.Add(this.cmdAuslegerEin);
            this.Controls.Add(this.cmdAuslegerAus);
            this.Controls.Add(this.cmdHakenEin);
            this.Controls.Add(this.cmdHakenAus);
            this.Controls.Add(this.h);
            this.Controls.Add(this.s);
            this.Controls.Add(this.a);
            this.Controls.Add(this.f);
            this.Name = "Form1";
            this.Text = "Bewegung begrenzen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdKranEin;
        internal System.Windows.Forms.Button cmdKranAus;
        internal System.Windows.Forms.Button cmdKranLinks;
        internal System.Windows.Forms.Button cmdKranRechts;
        internal System.Windows.Forms.Button cmdAuslegerEin;
        internal System.Windows.Forms.Button cmdAuslegerAus;
        internal System.Windows.Forms.Button cmdHakenEin;
        internal System.Windows.Forms.Button cmdHakenAus;
        internal System.Windows.Forms.Panel h;
        internal System.Windows.Forms.Panel s;
        internal System.Windows.Forms.Panel a;
        internal System.Windows.Forms.Panel f;
    }
}

