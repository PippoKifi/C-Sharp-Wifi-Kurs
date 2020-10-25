namespace DBMehrereTabellen
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
            this.cmdAlleProjekteZeitsumme = new System.Windows.Forms.Button();
            this.cmdAlleProjekteAllePersonenzeiten = new System.Windows.Forms.Button();
            this.cmdAllePersonenZeitsumme = new System.Windows.Forms.Button();
            this.cmdAllePersonenAlleProjektzeiten = new System.Windows.Forms.Button();
            this.cmdAlleKundenAlleProjekte = new System.Windows.Forms.Button();
            this.cmdAnzahlKunden = new System.Windows.Forms.Button();
            this.cmdAllePersonen = new System.Windows.Forms.Button();
            this.lstTab = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdAlleProjekteZeitsumme
            // 
            this.cmdAlleProjekteZeitsumme.Location = new System.Drawing.Point(22, 185);
            this.cmdAlleProjekteZeitsumme.Name = "cmdAlleProjekteZeitsumme";
            this.cmdAlleProjekteZeitsumme.Size = new System.Drawing.Size(300, 23);
            this.cmdAlleProjekteZeitsumme.TabIndex = 56;
            this.cmdAlleProjekteZeitsumme.Text = "Alle Projekte mit Zeitsumme";
            this.cmdAlleProjekteZeitsumme.UseVisualStyleBackColor = true;
            this.cmdAlleProjekteZeitsumme.Click += new System.EventHandler(this.cmdAlleProjekteZeitsumme_Click);
            // 
            // cmdAlleProjekteAllePersonenzeiten
            // 
            this.cmdAlleProjekteAllePersonenzeiten.Location = new System.Drawing.Point(22, 156);
            this.cmdAlleProjekteAllePersonenzeiten.Name = "cmdAlleProjekteAllePersonenzeiten";
            this.cmdAlleProjekteAllePersonenzeiten.Size = new System.Drawing.Size(300, 23);
            this.cmdAlleProjekteAllePersonenzeiten.TabIndex = 55;
            this.cmdAlleProjekteAllePersonenzeiten.Text = "Alle Projekte mit allen Personenzeiten";
            this.cmdAlleProjekteAllePersonenzeiten.UseVisualStyleBackColor = true;
            this.cmdAlleProjekteAllePersonenzeiten.Click += new System.EventHandler(this.cmdAlleProjekteAllePersonenzeiten_Click);
            // 
            // cmdAllePersonenZeitsumme
            // 
            this.cmdAllePersonenZeitsumme.Location = new System.Drawing.Point(22, 127);
            this.cmdAllePersonenZeitsumme.Name = "cmdAllePersonenZeitsumme";
            this.cmdAllePersonenZeitsumme.Size = new System.Drawing.Size(300, 23);
            this.cmdAllePersonenZeitsumme.TabIndex = 54;
            this.cmdAllePersonenZeitsumme.Text = "Alle Personen mit Zeitsumme";
            this.cmdAllePersonenZeitsumme.UseVisualStyleBackColor = true;
            this.cmdAllePersonenZeitsumme.Click += new System.EventHandler(this.cmdAllePersonenZeitsumme_Click);
            // 
            // cmdAllePersonenAlleProjektzeiten
            // 
            this.cmdAllePersonenAlleProjektzeiten.Location = new System.Drawing.Point(22, 98);
            this.cmdAllePersonenAlleProjektzeiten.Name = "cmdAllePersonenAlleProjektzeiten";
            this.cmdAllePersonenAlleProjektzeiten.Size = new System.Drawing.Size(300, 23);
            this.cmdAllePersonenAlleProjektzeiten.TabIndex = 53;
            this.cmdAllePersonenAlleProjektzeiten.Text = "Alle Personen mit allen Projektzeiten";
            this.cmdAllePersonenAlleProjektzeiten.UseVisualStyleBackColor = true;
            this.cmdAllePersonenAlleProjektzeiten.Click += new System.EventHandler(this.cmdAllePersonenAlleProjektzeiten_Click);
            // 
            // cmdAlleKundenAlleProjekte
            // 
            this.cmdAlleKundenAlleProjekte.Location = new System.Drawing.Point(22, 69);
            this.cmdAlleKundenAlleProjekte.Name = "cmdAlleKundenAlleProjekte";
            this.cmdAlleKundenAlleProjekte.Size = new System.Drawing.Size(300, 23);
            this.cmdAlleKundenAlleProjekte.TabIndex = 52;
            this.cmdAlleKundenAlleProjekte.Text = "Alle Kunden mit allen Projekten";
            this.cmdAlleKundenAlleProjekte.UseVisualStyleBackColor = true;
            this.cmdAlleKundenAlleProjekte.Click += new System.EventHandler(this.cmdAlleKundenAlleProjekte_Click);
            // 
            // cmdAnzahlKunden
            // 
            this.cmdAnzahlKunden.Location = new System.Drawing.Point(22, 40);
            this.cmdAnzahlKunden.Name = "cmdAnzahlKunden";
            this.cmdAnzahlKunden.Size = new System.Drawing.Size(300, 23);
            this.cmdAnzahlKunden.TabIndex = 51;
            this.cmdAnzahlKunden.Text = "Anzahl der Kunden";
            this.cmdAnzahlKunden.UseVisualStyleBackColor = true;
            this.cmdAnzahlKunden.Click += new System.EventHandler(this.cmdAnzahlKunden_Click);
            // 
            // cmdAllePersonen
            // 
            this.cmdAllePersonen.Location = new System.Drawing.Point(22, 11);
            this.cmdAllePersonen.Name = "cmdAllePersonen";
            this.cmdAllePersonen.Size = new System.Drawing.Size(300, 23);
            this.cmdAllePersonen.TabIndex = 50;
            this.cmdAllePersonen.Text = "Alle Personen";
            this.cmdAllePersonen.UseVisualStyleBackColor = true;
            this.cmdAllePersonen.Click += new System.EventHandler(this.cmdAllePersonen_Click);
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.Location = new System.Drawing.Point(22, 214);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(300, 95);
            this.lstTab.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.cmdAlleProjekteZeitsumme);
            this.Controls.Add(this.cmdAlleProjekteAllePersonenzeiten);
            this.Controls.Add(this.cmdAllePersonenZeitsumme);
            this.Controls.Add(this.cmdAllePersonenAlleProjektzeiten);
            this.Controls.Add(this.cmdAlleKundenAlleProjekte);
            this.Controls.Add(this.cmdAnzahlKunden);
            this.Controls.Add(this.cmdAllePersonen);
            this.Controls.Add(this.lstTab);
            this.Name = "Form1";
            this.Text = "Datenbank, mehrere Tabellen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdAlleProjekteZeitsumme;
        internal System.Windows.Forms.Button cmdAlleProjekteAllePersonenzeiten;
        internal System.Windows.Forms.Button cmdAllePersonenZeitsumme;
        internal System.Windows.Forms.Button cmdAllePersonenAlleProjektzeiten;
        internal System.Windows.Forms.Button cmdAlleKundenAlleProjekte;
        internal System.Windows.Forms.Button cmdAnzahlKunden;
        internal System.Windows.Forms.Button cmdAllePersonen;
        internal System.Windows.Forms.ListBox lstTab;
    }
}

