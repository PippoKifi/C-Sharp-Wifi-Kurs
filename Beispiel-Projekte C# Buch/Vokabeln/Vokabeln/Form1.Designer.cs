namespace Vokabeln
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
            this.mnuEndeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdStart = new System.Windows.Forms.Button();
            this.mnuDE = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRichtung = new System.Windows.Forms.Label();
            this.cmdPrüfen = new System.Windows.Forms.Button();
            this.mnuAllgemein = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEndeProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAntwort = new System.Windows.Forms.TextBox();
            this.mnuHaupt = new System.Windows.Forms.MenuStrip();
            this.mnuRichtung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuED = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnleitung = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFrage = new System.Windows.Forms.Label();
            this.mnuHaupt.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuEndeTest
            // 
            this.mnuEndeTest.Name = "mnuEndeTest";
            this.mnuEndeTest.Size = new System.Drawing.Size(180, 22);
            this.mnuEndeTest.Text = "Test beenden";
            this.mnuEndeTest.Click += new System.EventHandler(this.mnuEndeTest_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 196);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(100, 23);
            this.cmdStart.TabIndex = 21;
            this.cmdStart.Text = "Test starten";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // mnuDE
            // 
            this.mnuDE.Name = "mnuDE";
            this.mnuDE.Size = new System.Drawing.Size(186, 22);
            this.mnuDE.Text = "deutsch - englisch";
            this.mnuDE.Click += new System.EventHandler(this.mnuDE_Click);
            // 
            // lblRichtung
            // 
            this.lblRichtung.AutoSize = true;
            this.lblRichtung.Location = new System.Drawing.Point(14, 166);
            this.lblRichtung.Name = "lblRichtung";
            this.lblRichtung.Size = new System.Drawing.Size(89, 13);
            this.lblRichtung.TabIndex = 23;
            this.lblRichtung.Text = "englisch/deutsch";
            // 
            // cmdPrüfen
            // 
            this.cmdPrüfen.Enabled = false;
            this.cmdPrüfen.Location = new System.Drawing.Point(12, 226);
            this.cmdPrüfen.Name = "cmdPrüfen";
            this.cmdPrüfen.Size = new System.Drawing.Size(100, 23);
            this.cmdPrüfen.TabIndex = 20;
            this.cmdPrüfen.Text = "Prüfen / Nächster";
            this.cmdPrüfen.UseVisualStyleBackColor = true;
            this.cmdPrüfen.Click += new System.EventHandler(this.cmdPrüfen_Click);
            // 
            // mnuAllgemein
            // 
            this.mnuAllgemein.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEndeTest,
            this.mnuEndeProgramm});
            this.mnuAllgemein.Name = "mnuAllgemein";
            this.mnuAllgemein.Size = new System.Drawing.Size(73, 20);
            this.mnuAllgemein.Text = "Allgemein";
            // 
            // mnuEndeProgramm
            // 
            this.mnuEndeProgramm.Name = "mnuEndeProgramm";
            this.mnuEndeProgramm.Size = new System.Drawing.Size(180, 22);
            this.mnuEndeProgramm.Text = "Programm beenden";
            this.mnuEndeProgramm.Click += new System.EventHandler(this.mnuEndeProgramm_Click);
            // 
            // txtAntwort
            // 
            this.txtAntwort.Enabled = false;
            this.txtAntwort.Location = new System.Drawing.Point(156, 228);
            this.txtAntwort.Name = "txtAntwort";
            this.txtAntwort.Size = new System.Drawing.Size(100, 20);
            this.txtAntwort.TabIndex = 19;
            // 
            // mnuHaupt
            // 
            this.mnuHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAllgemein,
            this.mnuRichtung,
            this.mnuHilfe});
            this.mnuHaupt.Location = new System.Drawing.Point(0, 0);
            this.mnuHaupt.Name = "mnuHaupt";
            this.mnuHaupt.Size = new System.Drawing.Size(284, 24);
            this.mnuHaupt.TabIndex = 22;
            this.mnuHaupt.Text = "MenuStrip1";
            // 
            // mnuRichtung
            // 
            this.mnuRichtung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDE,
            this.mnuED,
            this.mnuDF,
            this.mnuFD});
            this.mnuRichtung.Name = "mnuRichtung";
            this.mnuRichtung.Size = new System.Drawing.Size(67, 20);
            this.mnuRichtung.Text = "Richtung";
            // 
            // mnuED
            // 
            this.mnuED.Checked = true;
            this.mnuED.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuED.Name = "mnuED";
            this.mnuED.Size = new System.Drawing.Size(186, 22);
            this.mnuED.Text = "englisch - deutsch";
            this.mnuED.Click += new System.EventHandler(this.mnuED_Click);
            // 
            // mnuDF
            // 
            this.mnuDF.Name = "mnuDF";
            this.mnuDF.Size = new System.Drawing.Size(186, 22);
            this.mnuDF.Text = "deutsch - französisch";
            this.mnuDF.Click += new System.EventHandler(this.mnuDF_Click);
            // 
            // mnuFD
            // 
            this.mnuFD.Name = "mnuFD";
            this.mnuFD.Size = new System.Drawing.Size(186, 22);
            this.mnuFD.Text = "französisch - deutsch";
            this.mnuFD.Click += new System.EventHandler(this.mnuFD_Click);
            // 
            // mnuHilfe
            // 
            this.mnuHilfe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnleitung});
            this.mnuHilfe.Name = "mnuHilfe";
            this.mnuHilfe.Size = new System.Drawing.Size(44, 20);
            this.mnuHilfe.Text = "Hilfe";
            // 
            // mnuAnleitung
            // 
            this.mnuAnleitung.Name = "mnuAnleitung";
            this.mnuAnleitung.Size = new System.Drawing.Size(126, 22);
            this.mnuAnleitung.Text = "Anleitung";
            this.mnuAnleitung.Click += new System.EventHandler(this.mnuAnleitung_Click);
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.Location = new System.Drawing.Point(159, 201);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(0, 13);
            this.lblFrage.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lblRichtung);
            this.Controls.Add(this.cmdPrüfen);
            this.Controls.Add(this.txtAntwort);
            this.Controls.Add(this.mnuHaupt);
            this.Controls.Add(this.lblFrage);
            this.Name = "Form1";
            this.Text = "Vokabeln";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuHaupt.ResumeLayout(false);
            this.mnuHaupt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem mnuEndeTest;
        internal System.Windows.Forms.Button cmdStart;
        internal System.Windows.Forms.ToolStripMenuItem mnuDE;
        internal System.Windows.Forms.Label lblRichtung;
        internal System.Windows.Forms.Button cmdPrüfen;
        internal System.Windows.Forms.ToolStripMenuItem mnuAllgemein;
        internal System.Windows.Forms.ToolStripMenuItem mnuEndeProgramm;
        internal System.Windows.Forms.TextBox txtAntwort;
        internal System.Windows.Forms.MenuStrip mnuHaupt;
        internal System.Windows.Forms.ToolStripMenuItem mnuRichtung;
        internal System.Windows.Forms.ToolStripMenuItem mnuED;
        internal System.Windows.Forms.ToolStripMenuItem mnuDF;
        internal System.Windows.Forms.ToolStripMenuItem mnuFD;
        internal System.Windows.Forms.ToolStripMenuItem mnuHilfe;
        internal System.Windows.Forms.ToolStripMenuItem mnuAnleitung;
        internal System.Windows.Forms.Label lblFrage;
    }
}

