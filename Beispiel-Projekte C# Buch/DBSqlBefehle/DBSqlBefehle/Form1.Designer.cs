namespace DBSqlBefehle
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
            this.cmdFehlerEindeutigkeit = new System.Windows.Forms.Button();
            this.cmdFehlerDatum = new System.Windows.Forms.Button();
            this.cmdFehlerZeichen = new System.Windows.Forms.Button();
            this.cmdEingabeSuchzeichen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.cmdOriginalwerte = new System.Windows.Forms.Button();
            this.cmdEinfügen = new System.Windows.Forms.Button();
            this.cmdLöschenEinzeln = new System.Windows.Forms.Button();
            this.cmdÄndernEinzeln = new System.Windows.Forms.Button();
            this.cmdÄndernAlle = new System.Windows.Forms.Button();
            this.cmdEingabeSuchbegriff = new System.Windows.Forms.Button();
            this.cmdSortierungNachZweiFeldern = new System.Windows.Forms.Button();
            this.cmdSortierungFallend = new System.Windows.Forms.Button();
            this.cmdEinzelnerPlatzhalter = new System.Windows.Forms.Button();
            this.cmdZeichenKommtVor = new System.Windows.Forms.Button();
            this.cmdBeginntMitZeichen = new System.Windows.Forms.Button();
            this.cmdBedingungLogisch = new System.Windows.Forms.Button();
            this.cmdBedingungZeichen = new System.Windows.Forms.Button();
            this.cmdBedingungZahl = new System.Windows.Forms.Button();
            this.lstTab = new System.Windows.Forms.ListBox();
            this.cmdEinzelneFelder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFehlerEindeutigkeit
            // 
            this.cmdFehlerEindeutigkeit.Location = new System.Drawing.Point(324, 70);
            this.cmdFehlerEindeutigkeit.Name = "cmdFehlerEindeutigkeit";
            this.cmdFehlerEindeutigkeit.Size = new System.Drawing.Size(150, 23);
            this.cmdFehlerEindeutigkeit.TabIndex = 73;
            this.cmdFehlerEindeutigkeit.Text = "Fehler Eindeutigkeit";
            this.cmdFehlerEindeutigkeit.UseVisualStyleBackColor = true;
            this.cmdFehlerEindeutigkeit.Click += new System.EventHandler(this.cmdFehlerEindeutigkeit_Click);
            // 
            // cmdFehlerDatum
            // 
            this.cmdFehlerDatum.Location = new System.Drawing.Point(324, 41);
            this.cmdFehlerDatum.Name = "cmdFehlerDatum";
            this.cmdFehlerDatum.Size = new System.Drawing.Size(150, 23);
            this.cmdFehlerDatum.TabIndex = 72;
            this.cmdFehlerDatum.Text = "Fehler Datum";
            this.cmdFehlerDatum.UseVisualStyleBackColor = true;
            this.cmdFehlerDatum.Click += new System.EventHandler(this.cmdFehlerDatum_Click);
            // 
            // cmdFehlerZeichen
            // 
            this.cmdFehlerZeichen.Location = new System.Drawing.Point(324, 14);
            this.cmdFehlerZeichen.Name = "cmdFehlerZeichen";
            this.cmdFehlerZeichen.Size = new System.Drawing.Size(150, 23);
            this.cmdFehlerZeichen.TabIndex = 71;
            this.cmdFehlerZeichen.Text = "Fehler Zeichen";
            this.cmdFehlerZeichen.UseVisualStyleBackColor = true;
            this.cmdFehlerZeichen.Click += new System.EventHandler(this.cmdFehlerZeichen_Click);
            // 
            // cmdEingabeSuchzeichen
            // 
            this.cmdEingabeSuchzeichen.Location = new System.Drawing.Point(168, 70);
            this.cmdEingabeSuchzeichen.Name = "cmdEingabeSuchzeichen";
            this.cmdEingabeSuchzeichen.Size = new System.Drawing.Size(150, 23);
            this.cmdEingabeSuchzeichen.TabIndex = 70;
            this.cmdEingabeSuchzeichen.Text = "Eingabe Suchzeichen";
            this.cmdEingabeSuchzeichen.UseVisualStyleBackColor = true;
            this.cmdEingabeSuchzeichen.Click += new System.EventHandler(this.cmdEingabeSuchzeichen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(168, 14);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(150, 20);
            this.txtEingabe.TabIndex = 69;
            // 
            // cmdOriginalwerte
            // 
            this.cmdOriginalwerte.Location = new System.Drawing.Point(324, 244);
            this.cmdOriginalwerte.Name = "cmdOriginalwerte";
            this.cmdOriginalwerte.Size = new System.Drawing.Size(150, 23);
            this.cmdOriginalwerte.TabIndex = 68;
            this.cmdOriginalwerte.Text = "Originalwerte";
            this.cmdOriginalwerte.UseVisualStyleBackColor = true;
            this.cmdOriginalwerte.Click += new System.EventHandler(this.cmdOriginalwerte_Click);
            // 
            // cmdEinfügen
            // 
            this.cmdEinfügen.Location = new System.Drawing.Point(168, 215);
            this.cmdEinfügen.Name = "cmdEinfügen";
            this.cmdEinfügen.Size = new System.Drawing.Size(150, 23);
            this.cmdEinfügen.TabIndex = 67;
            this.cmdEinfügen.Text = "Einfügen";
            this.cmdEinfügen.UseVisualStyleBackColor = true;
            this.cmdEinfügen.Click += new System.EventHandler(this.cmdEinfügen_Click);
            // 
            // cmdLöschenEinzeln
            // 
            this.cmdLöschenEinzeln.Location = new System.Drawing.Point(168, 186);
            this.cmdLöschenEinzeln.Name = "cmdLöschenEinzeln";
            this.cmdLöschenEinzeln.Size = new System.Drawing.Size(150, 23);
            this.cmdLöschenEinzeln.TabIndex = 66;
            this.cmdLöschenEinzeln.Text = "Löschen einzeln";
            this.cmdLöschenEinzeln.UseVisualStyleBackColor = true;
            this.cmdLöschenEinzeln.Click += new System.EventHandler(this.cmdLöschenEinzeln_Click);
            // 
            // cmdÄndernEinzeln
            // 
            this.cmdÄndernEinzeln.Location = new System.Drawing.Point(168, 157);
            this.cmdÄndernEinzeln.Name = "cmdÄndernEinzeln";
            this.cmdÄndernEinzeln.Size = new System.Drawing.Size(150, 23);
            this.cmdÄndernEinzeln.TabIndex = 65;
            this.cmdÄndernEinzeln.Text = "Ändern einzeln";
            this.cmdÄndernEinzeln.UseVisualStyleBackColor = true;
            this.cmdÄndernEinzeln.Click += new System.EventHandler(this.cmdÄndernEinzeln_Click);
            // 
            // cmdÄndernAlle
            // 
            this.cmdÄndernAlle.Location = new System.Drawing.Point(168, 128);
            this.cmdÄndernAlle.Name = "cmdÄndernAlle";
            this.cmdÄndernAlle.Size = new System.Drawing.Size(150, 23);
            this.cmdÄndernAlle.TabIndex = 64;
            this.cmdÄndernAlle.Text = "Ändern alle";
            this.cmdÄndernAlle.UseVisualStyleBackColor = true;
            this.cmdÄndernAlle.Click += new System.EventHandler(this.cmdÄndernAlle_Click);
            // 
            // cmdEingabeSuchbegriff
            // 
            this.cmdEingabeSuchbegriff.Location = new System.Drawing.Point(168, 41);
            this.cmdEingabeSuchbegriff.Name = "cmdEingabeSuchbegriff";
            this.cmdEingabeSuchbegriff.Size = new System.Drawing.Size(150, 23);
            this.cmdEingabeSuchbegriff.TabIndex = 63;
            this.cmdEingabeSuchbegriff.Text = "Eingabe Suchbegriff";
            this.cmdEingabeSuchbegriff.UseVisualStyleBackColor = true;
            this.cmdEingabeSuchbegriff.Click += new System.EventHandler(this.cmdEingabeSuchbegriff_Click);
            // 
            // cmdSortierungNachZweiFeldern
            // 
            this.cmdSortierungNachZweiFeldern.Location = new System.Drawing.Point(12, 244);
            this.cmdSortierungNachZweiFeldern.Name = "cmdSortierungNachZweiFeldern";
            this.cmdSortierungNachZweiFeldern.Size = new System.Drawing.Size(150, 23);
            this.cmdSortierungNachZweiFeldern.TabIndex = 62;
            this.cmdSortierungNachZweiFeldern.Text = "Sortierung nach 2 Feldern";
            this.cmdSortierungNachZweiFeldern.UseVisualStyleBackColor = true;
            this.cmdSortierungNachZweiFeldern.Click += new System.EventHandler(this.cmdSortierungNachZweiFeldern_Click);
            // 
            // cmdSortierungFallend
            // 
            this.cmdSortierungFallend.Location = new System.Drawing.Point(12, 215);
            this.cmdSortierungFallend.Name = "cmdSortierungFallend";
            this.cmdSortierungFallend.Size = new System.Drawing.Size(150, 23);
            this.cmdSortierungFallend.TabIndex = 61;
            this.cmdSortierungFallend.Text = "Sortierung fallend";
            this.cmdSortierungFallend.UseVisualStyleBackColor = true;
            this.cmdSortierungFallend.Click += new System.EventHandler(this.cmdSortierungFallend_Click);
            // 
            // cmdEinzelnerPlatzhalter
            // 
            this.cmdEinzelnerPlatzhalter.Location = new System.Drawing.Point(12, 186);
            this.cmdEinzelnerPlatzhalter.Name = "cmdEinzelnerPlatzhalter";
            this.cmdEinzelnerPlatzhalter.Size = new System.Drawing.Size(150, 23);
            this.cmdEinzelnerPlatzhalter.TabIndex = 60;
            this.cmdEinzelnerPlatzhalter.Text = "Einzelner Platzhalter";
            this.cmdEinzelnerPlatzhalter.UseVisualStyleBackColor = true;
            this.cmdEinzelnerPlatzhalter.Click += new System.EventHandler(this.cmdEinzelnerPlatzhalter_Click);
            // 
            // cmdZeichenKommtVor
            // 
            this.cmdZeichenKommtVor.Location = new System.Drawing.Point(12, 157);
            this.cmdZeichenKommtVor.Name = "cmdZeichenKommtVor";
            this.cmdZeichenKommtVor.Size = new System.Drawing.Size(150, 23);
            this.cmdZeichenKommtVor.TabIndex = 59;
            this.cmdZeichenKommtVor.Text = "Zeichen kommt vor";
            this.cmdZeichenKommtVor.UseVisualStyleBackColor = true;
            this.cmdZeichenKommtVor.Click += new System.EventHandler(this.cmdZeichenKommtVor_Click);
            // 
            // cmdBeginntMitZeichen
            // 
            this.cmdBeginntMitZeichen.Location = new System.Drawing.Point(12, 128);
            this.cmdBeginntMitZeichen.Name = "cmdBeginntMitZeichen";
            this.cmdBeginntMitZeichen.Size = new System.Drawing.Size(150, 23);
            this.cmdBeginntMitZeichen.TabIndex = 58;
            this.cmdBeginntMitZeichen.Text = "Beginnt mit Zeichen";
            this.cmdBeginntMitZeichen.UseVisualStyleBackColor = true;
            this.cmdBeginntMitZeichen.Click += new System.EventHandler(this.cmdBeginntMitZeichen_Click);
            // 
            // cmdBedingungLogisch
            // 
            this.cmdBedingungLogisch.Location = new System.Drawing.Point(12, 99);
            this.cmdBedingungLogisch.Name = "cmdBedingungLogisch";
            this.cmdBedingungLogisch.Size = new System.Drawing.Size(150, 23);
            this.cmdBedingungLogisch.TabIndex = 57;
            this.cmdBedingungLogisch.Text = "Bedingung mit log. Operator";
            this.cmdBedingungLogisch.UseVisualStyleBackColor = true;
            this.cmdBedingungLogisch.Click += new System.EventHandler(this.cmdBedingungLogisch_Click);
            // 
            // cmdBedingungZeichen
            // 
            this.cmdBedingungZeichen.Location = new System.Drawing.Point(12, 70);
            this.cmdBedingungZeichen.Name = "cmdBedingungZeichen";
            this.cmdBedingungZeichen.Size = new System.Drawing.Size(150, 23);
            this.cmdBedingungZeichen.TabIndex = 56;
            this.cmdBedingungZeichen.Text = "Bedingung mit Zeichen";
            this.cmdBedingungZeichen.UseVisualStyleBackColor = true;
            this.cmdBedingungZeichen.Click += new System.EventHandler(this.cmdBedingungZeichen_Click);
            // 
            // cmdBedingungZahl
            // 
            this.cmdBedingungZahl.Location = new System.Drawing.Point(12, 41);
            this.cmdBedingungZahl.Name = "cmdBedingungZahl";
            this.cmdBedingungZahl.Size = new System.Drawing.Size(150, 23);
            this.cmdBedingungZahl.TabIndex = 55;
            this.cmdBedingungZahl.Text = "Bedingung mit Zahl";
            this.cmdBedingungZahl.UseVisualStyleBackColor = true;
            this.cmdBedingungZahl.Click += new System.EventHandler(this.cmdBedingungZahl_Click);
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.Location = new System.Drawing.Point(12, 302);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(306, 95);
            this.lstTab.TabIndex = 54;
            // 
            // cmdEinzelneFelder
            // 
            this.cmdEinzelneFelder.Location = new System.Drawing.Point(12, 12);
            this.cmdEinzelneFelder.Name = "cmdEinzelneFelder";
            this.cmdEinzelneFelder.Size = new System.Drawing.Size(150, 23);
            this.cmdEinzelneFelder.TabIndex = 53;
            this.cmdEinzelneFelder.Text = "Einzelne Felder";
            this.cmdEinzelneFelder.UseVisualStyleBackColor = true;
            this.cmdEinzelneFelder.Click += new System.EventHandler(this.cmdEinzelneFelder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.cmdFehlerEindeutigkeit);
            this.Controls.Add(this.cmdFehlerDatum);
            this.Controls.Add(this.cmdFehlerZeichen);
            this.Controls.Add(this.cmdEingabeSuchzeichen);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.cmdOriginalwerte);
            this.Controls.Add(this.cmdEinfügen);
            this.Controls.Add(this.cmdLöschenEinzeln);
            this.Controls.Add(this.cmdÄndernEinzeln);
            this.Controls.Add(this.cmdÄndernAlle);
            this.Controls.Add(this.cmdEingabeSuchbegriff);
            this.Controls.Add(this.cmdSortierungNachZweiFeldern);
            this.Controls.Add(this.cmdSortierungFallend);
            this.Controls.Add(this.cmdEinzelnerPlatzhalter);
            this.Controls.Add(this.cmdZeichenKommtVor);
            this.Controls.Add(this.cmdBeginntMitZeichen);
            this.Controls.Add(this.cmdBedingungLogisch);
            this.Controls.Add(this.cmdBedingungZeichen);
            this.Controls.Add(this.cmdBedingungZahl);
            this.Controls.Add(this.lstTab);
            this.Controls.Add(this.cmdEinzelneFelder);
            this.Name = "Form1";
            this.Text = "Datenbank, SQL-Befehle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdFehlerEindeutigkeit;
        internal System.Windows.Forms.Button cmdFehlerDatum;
        internal System.Windows.Forms.Button cmdFehlerZeichen;
        internal System.Windows.Forms.Button cmdEingabeSuchzeichen;
        internal System.Windows.Forms.TextBox txtEingabe;
        internal System.Windows.Forms.Button cmdOriginalwerte;
        internal System.Windows.Forms.Button cmdEinfügen;
        internal System.Windows.Forms.Button cmdLöschenEinzeln;
        internal System.Windows.Forms.Button cmdÄndernEinzeln;
        internal System.Windows.Forms.Button cmdÄndernAlle;
        internal System.Windows.Forms.Button cmdEingabeSuchbegriff;
        internal System.Windows.Forms.Button cmdSortierungNachZweiFeldern;
        internal System.Windows.Forms.Button cmdSortierungFallend;
        internal System.Windows.Forms.Button cmdEinzelnerPlatzhalter;
        internal System.Windows.Forms.Button cmdZeichenKommtVor;
        internal System.Windows.Forms.Button cmdBeginntMitZeichen;
        internal System.Windows.Forms.Button cmdBedingungLogisch;
        internal System.Windows.Forms.Button cmdBedingungZeichen;
        internal System.Windows.Forms.Button cmdBedingungZahl;
        internal System.Windows.Forms.ListBox lstTab;
        internal System.Windows.Forms.Button cmdEinzelneFelder;
    }
}

