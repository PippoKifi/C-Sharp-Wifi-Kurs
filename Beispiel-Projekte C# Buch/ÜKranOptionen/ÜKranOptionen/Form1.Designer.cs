namespace ÜKranOptionen
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
            this.components = new System.ComponentModel.Container();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.optKranEin = new System.Windows.Forms.RadioButton();
            this.optKranAus = new System.Windows.Forms.RadioButton();
            this.tim1 = new System.Windows.Forms.Timer(this.components);
            this.optKranLinks = new System.Windows.Forms.RadioButton();
            this.optKranRechts = new System.Windows.Forms.RadioButton();
            this.optAuslegerEin = new System.Windows.Forms.RadioButton();
            this.optAuslegerAus = new System.Windows.Forms.RadioButton();
            this.optHakenEin = new System.Windows.Forms.RadioButton();
            this.optHakenAus = new System.Windows.Forms.RadioButton();
            this.h = new System.Windows.Forms.Panel();
            this.s = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(214, 249);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 89;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(295, 249);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 88;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // optKranEin
            // 
            this.optKranEin.AutoSize = true;
            this.optKranEin.Location = new System.Drawing.Point(295, 215);
            this.optKranEin.Name = "optKranEin";
            this.optKranEin.Size = new System.Drawing.Size(64, 17);
            this.optKranEin.TabIndex = 87;
            this.optKranEin.Text = "Kran ein";
            this.optKranEin.UseVisualStyleBackColor = true;
            // 
            // optKranAus
            // 
            this.optKranAus.AutoSize = true;
            this.optKranAus.Location = new System.Drawing.Point(295, 186);
            this.optKranAus.Name = "optKranAus";
            this.optKranAus.Size = new System.Drawing.Size(67, 17);
            this.optKranAus.TabIndex = 86;
            this.optKranAus.Text = "Kran aus";
            this.optKranAus.UseVisualStyleBackColor = true;
            // 
            // tim1
            // 
            this.tim1.Interval = 500;
            this.tim1.Tick += new System.EventHandler(this.tim1_Tick);
            // 
            // optKranLinks
            // 
            this.optKranLinks.AutoSize = true;
            this.optKranLinks.Location = new System.Drawing.Point(295, 157);
            this.optKranLinks.Name = "optKranLinks";
            this.optKranLinks.Size = new System.Drawing.Size(71, 17);
            this.optKranLinks.TabIndex = 85;
            this.optKranLinks.Text = "Kran links";
            this.optKranLinks.UseVisualStyleBackColor = true;
            // 
            // optKranRechts
            // 
            this.optKranRechts.AutoSize = true;
            this.optKranRechts.Location = new System.Drawing.Point(295, 128);
            this.optKranRechts.Name = "optKranRechts";
            this.optKranRechts.Size = new System.Drawing.Size(79, 17);
            this.optKranRechts.TabIndex = 84;
            this.optKranRechts.Text = "Kran rechts";
            this.optKranRechts.UseVisualStyleBackColor = true;
            // 
            // optAuslegerEin
            // 
            this.optAuslegerEin.AutoSize = true;
            this.optAuslegerEin.Location = new System.Drawing.Point(295, 99);
            this.optAuslegerEin.Name = "optAuslegerEin";
            this.optAuslegerEin.Size = new System.Drawing.Size(83, 17);
            this.optAuslegerEin.TabIndex = 83;
            this.optAuslegerEin.Text = "Ausleger ein";
            this.optAuslegerEin.UseVisualStyleBackColor = true;
            // 
            // optAuslegerAus
            // 
            this.optAuslegerAus.AutoSize = true;
            this.optAuslegerAus.Location = new System.Drawing.Point(295, 70);
            this.optAuslegerAus.Name = "optAuslegerAus";
            this.optAuslegerAus.Size = new System.Drawing.Size(86, 17);
            this.optAuslegerAus.TabIndex = 82;
            this.optAuslegerAus.Text = "Ausleger aus";
            this.optAuslegerAus.UseVisualStyleBackColor = true;
            // 
            // optHakenEin
            // 
            this.optHakenEin.AutoSize = true;
            this.optHakenEin.Location = new System.Drawing.Point(295, 41);
            this.optHakenEin.Name = "optHakenEin";
            this.optHakenEin.Size = new System.Drawing.Size(74, 17);
            this.optHakenEin.TabIndex = 81;
            this.optHakenEin.Text = "Haken ein";
            this.optHakenEin.UseVisualStyleBackColor = true;
            // 
            // optHakenAus
            // 
            this.optHakenAus.AutoSize = true;
            this.optHakenAus.Checked = true;
            this.optHakenAus.Location = new System.Drawing.Point(295, 12);
            this.optHakenAus.Name = "optHakenAus";
            this.optHakenAus.Size = new System.Drawing.Size(77, 17);
            this.optHakenAus.TabIndex = 80;
            this.optHakenAus.TabStop = true;
            this.optHakenAus.Text = "Haken aus";
            this.optHakenAus.UseVisualStyleBackColor = true;
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.Fuchsia;
            this.h.Location = new System.Drawing.Point(102, 110);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(10, 20);
            this.h.TabIndex = 79;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Yellow;
            this.s.Location = new System.Drawing.Point(147, 100);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(20, 120);
            this.s.TabIndex = 77;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Blue;
            this.a.Location = new System.Drawing.Point(102, 100);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(50, 10);
            this.a.TabIndex = 78;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Red;
            this.f.Location = new System.Drawing.Point(132, 220);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(50, 10);
            this.f.TabIndex = 76;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.optKranEin);
            this.Controls.Add(this.optKranAus);
            this.Controls.Add(this.optKranLinks);
            this.Controls.Add(this.optKranRechts);
            this.Controls.Add(this.optAuslegerEin);
            this.Controls.Add(this.optAuslegerAus);
            this.Controls.Add(this.optHakenEin);
            this.Controls.Add(this.optHakenAus);
            this.Controls.Add(this.h);
            this.Controls.Add(this.s);
            this.Controls.Add(this.a);
            this.Controls.Add(this.f);
            this.Name = "Form1";
            this.Text = "Bewegung per Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdStart;
        internal System.Windows.Forms.Button cmdStop;
        internal System.Windows.Forms.RadioButton optKranEin;
        internal System.Windows.Forms.RadioButton optKranAus;
        internal System.Windows.Forms.Timer tim1;
        internal System.Windows.Forms.RadioButton optKranLinks;
        internal System.Windows.Forms.RadioButton optKranRechts;
        internal System.Windows.Forms.RadioButton optAuslegerEin;
        internal System.Windows.Forms.RadioButton optAuslegerAus;
        internal System.Windows.Forms.RadioButton optHakenEin;
        internal System.Windows.Forms.RadioButton optHakenAus;
        internal System.Windows.Forms.Panel h;
        internal System.Windows.Forms.Panel s;
        internal System.Windows.Forms.Panel a;
        internal System.Windows.Forms.Panel f;
    }
}

