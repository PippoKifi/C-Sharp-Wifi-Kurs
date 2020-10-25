namespace MenüSymbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.symHaupt = new System.Windows.Forms.ToolStrip();
            this.symFett = new System.Windows.Forms.ToolStripButton();
            this.symKursiv = new System.Windows.Forms.ToolStripButton();
            this.symLblSchriftgröße = new System.Windows.Forms.ToolStripLabel();
            this.cboSymSchriftgröße = new System.Windows.Forms.ToolStripComboBox();
            this.mnuHaupt = new System.Windows.Forms.MenuStrip();
            this.mnuBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKopieren = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnde = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnsicht = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHintergrund = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGelb = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSchriftart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSchriftgröße = new System.Windows.Forms.ToolStripComboBox();
            this.mnuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFett = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKursiv = new System.Windows.Forms.ToolStripMenuItem();
            this.txtE = new System.Windows.Forms.TextBox();
            this.conTxtMenü = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conTxtReadOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.conTxtMultiline = new System.Windows.Forms.ToolStripMenuItem();
            this.conLblFett = new System.Windows.Forms.ToolStripMenuItem();
            this.conLblMenü = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblA = new System.Windows.Forms.Label();
            this.symHaupt.SuspendLayout();
            this.mnuHaupt.SuspendLayout();
            this.conTxtMenü.SuspendLayout();
            this.conLblMenü.SuspendLayout();
            this.SuspendLayout();
            // 
            // symHaupt
            // 
            this.symHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symFett,
            this.symKursiv,
            this.symLblSchriftgröße,
            this.cboSymSchriftgröße});
            this.symHaupt.Location = new System.Drawing.Point(0, 24);
            this.symHaupt.Name = "symHaupt";
            this.symHaupt.Size = new System.Drawing.Size(284, 25);
            this.symHaupt.TabIndex = 21;
            this.symHaupt.Text = "ToolStrip1";
            // 
            // symFett
            // 
            this.symFett.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.symFett.Image = ((System.Drawing.Image)(resources.GetObject("symFett.Image")));
            this.symFett.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.symFett.Name = "symFett";
            this.symFett.Size = new System.Drawing.Size(23, 22);
            this.symFett.Text = "ToolStripButton1";
            this.symFett.Click += new System.EventHandler(this.mnuFett_Click);
            // 
            // symKursiv
            // 
            this.symKursiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.symKursiv.Image = ((System.Drawing.Image)(resources.GetObject("symKursiv.Image")));
            this.symKursiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.symKursiv.Name = "symKursiv";
            this.symKursiv.Size = new System.Drawing.Size(23, 22);
            this.symKursiv.Text = "ToolStripButton1";
            this.symKursiv.Click += new System.EventHandler(this.mnuKursiv_Click);
            // 
            // symLblSchriftgröße
            // 
            this.symLblSchriftgröße.Name = "symLblSchriftgröße";
            this.symLblSchriftgröße.Size = new System.Drawing.Size(75, 22);
            this.symLblSchriftgröße.Text = "Schriftgröße:";
            // 
            // cboSymSchriftgröße
            // 
            this.cboSymSchriftgröße.Name = "cboSymSchriftgröße";
            this.cboSymSchriftgröße.Size = new System.Drawing.Size(121, 25);
            this.cboSymSchriftgröße.TextChanged += new System.EventHandler(this.Schriftgröße_TextChanged);
            // 
            // mnuHaupt
            // 
            this.mnuHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBearbeiten,
            this.mnuAnsicht});
            this.mnuHaupt.Location = new System.Drawing.Point(0, 0);
            this.mnuHaupt.Name = "mnuHaupt";
            this.mnuHaupt.Size = new System.Drawing.Size(284, 24);
            this.mnuHaupt.TabIndex = 18;
            this.mnuHaupt.Text = "MenuStrip1";
            // 
            // mnuBearbeiten
            // 
            this.mnuBearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKopieren,
            this.mnuEnde});
            this.mnuBearbeiten.Name = "mnuBearbeiten";
            this.mnuBearbeiten.Size = new System.Drawing.Size(75, 20);
            this.mnuBearbeiten.Text = "&Bearbeiten";
            // 
            // mnuKopieren
            // 
            this.mnuKopieren.Name = "mnuKopieren";
            this.mnuKopieren.Size = new System.Drawing.Size(121, 22);
            this.mnuKopieren.Text = "&Kopieren";
            this.mnuKopieren.Click += new System.EventHandler(this.mnuKopieren_Click);
            // 
            // mnuEnde
            // 
            this.mnuEnde.Name = "mnuEnde";
            this.mnuEnde.Size = new System.Drawing.Size(121, 22);
            this.mnuEnde.Text = "&Ende";
            this.mnuEnde.Click += new System.EventHandler(this.mnuEnde_Click);
            // 
            // mnuAnsicht
            // 
            this.mnuAnsicht.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHintergrund,
            this.mnuSep1,
            this.mnuSchriftart,
            this.cboSchriftgröße,
            this.mnuSep2,
            this.mnuFett,
            this.mnuKursiv});
            this.mnuAnsicht.Name = "mnuAnsicht";
            this.mnuAnsicht.Size = new System.Drawing.Size(59, 20);
            this.mnuAnsicht.Text = "&Ansicht";
            // 
            // mnuHintergrund
            // 
            this.mnuHintergrund.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGelb,
            this.mnuBlau,
            this.mnuRot});
            this.mnuHintergrund.Name = "mnuHintergrund";
            this.mnuHintergrund.Size = new System.Drawing.Size(181, 22);
            this.mnuHintergrund.Text = "Hintergrund";
            // 
            // mnuGelb
            // 
            this.mnuGelb.Checked = true;
            this.mnuGelb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuGelb.Name = "mnuGelb";
            this.mnuGelb.Size = new System.Drawing.Size(98, 22);
            this.mnuGelb.Text = "Gelb";
            this.mnuGelb.Click += new System.EventHandler(this.mnuGelb_Click);
            // 
            // mnuBlau
            // 
            this.mnuBlau.Name = "mnuBlau";
            this.mnuBlau.Size = new System.Drawing.Size(98, 22);
            this.mnuBlau.Text = "Blau";
            this.mnuBlau.Click += new System.EventHandler(this.mnuBlau_Click);
            // 
            // mnuRot
            // 
            this.mnuRot.Name = "mnuRot";
            this.mnuRot.Size = new System.Drawing.Size(98, 22);
            this.mnuRot.Text = "Rot";
            this.mnuRot.Click += new System.EventHandler(this.mnuRot_Click);
            // 
            // mnuSep1
            // 
            this.mnuSep1.Name = "mnuSep1";
            this.mnuSep1.Size = new System.Drawing.Size(178, 6);
            // 
            // mnuSchriftart
            // 
            this.mnuSchriftart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCourierNew,
            this.mnuSymbol,
            this.mnuArial});
            this.mnuSchriftart.Name = "mnuSchriftart";
            this.mnuSchriftart.Size = new System.Drawing.Size(181, 22);
            this.mnuSchriftart.Text = "Schriftart";
            // 
            // mnuCourierNew
            // 
            this.mnuCourierNew.Checked = true;
            this.mnuCourierNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuCourierNew.Name = "mnuCourierNew";
            this.mnuCourierNew.Size = new System.Drawing.Size(140, 22);
            this.mnuCourierNew.Text = "Courier New";
            this.mnuCourierNew.Click += new System.EventHandler(this.mnuCourierNew_Click);
            // 
            // mnuSymbol
            // 
            this.mnuSymbol.Name = "mnuSymbol";
            this.mnuSymbol.Size = new System.Drawing.Size(140, 22);
            this.mnuSymbol.Text = "Symbol";
            this.mnuSymbol.Click += new System.EventHandler(this.mnuSymbol_Click);
            // 
            // mnuArial
            // 
            this.mnuArial.Name = "mnuArial";
            this.mnuArial.Size = new System.Drawing.Size(140, 22);
            this.mnuArial.Text = "Arial";
            this.mnuArial.Click += new System.EventHandler(this.mnuArial_Click);
            // 
            // cboSchriftgröße
            // 
            this.cboSchriftgröße.Name = "cboSchriftgröße";
            this.cboSchriftgröße.Size = new System.Drawing.Size(121, 23);
            this.cboSchriftgröße.TextChanged += new System.EventHandler(this.Schriftgröße_TextChanged);
            // 
            // mnuSep2
            // 
            this.mnuSep2.Name = "mnuSep2";
            this.mnuSep2.Size = new System.Drawing.Size(178, 6);
            // 
            // mnuFett
            // 
            this.mnuFett.Name = "mnuFett";
            this.mnuFett.Size = new System.Drawing.Size(181, 22);
            this.mnuFett.Text = "Fett";
            this.mnuFett.Click += new System.EventHandler(this.mnuFett_Click);
            // 
            // mnuKursiv
            // 
            this.mnuKursiv.Name = "mnuKursiv";
            this.mnuKursiv.Size = new System.Drawing.Size(181, 22);
            this.mnuKursiv.Text = "Kursiv";
            this.mnuKursiv.Click += new System.EventHandler(this.mnuKursiv_Click);
            // 
            // txtE
            // 
            this.txtE.ContextMenuStrip = this.conTxtMenü;
            this.txtE.Location = new System.Drawing.Point(12, 191);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 20);
            this.txtE.TabIndex = 19;
            // 
            // conTxtMenü
            // 
            this.conTxtMenü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conTxtReadOnly,
            this.conTxtMultiline});
            this.conTxtMenü.Name = "conTxtE";
            this.conTxtMenü.Size = new System.Drawing.Size(126, 48);
            // 
            // conTxtReadOnly
            // 
            this.conTxtReadOnly.Name = "conTxtReadOnly";
            this.conTxtReadOnly.Size = new System.Drawing.Size(125, 22);
            this.conTxtReadOnly.Text = "ReadOnly";
            this.conTxtReadOnly.Click += new System.EventHandler(this.conTxtReadOnly_Click);
            // 
            // conTxtMultiline
            // 
            this.conTxtMultiline.Name = "conTxtMultiline";
            this.conTxtMultiline.Size = new System.Drawing.Size(125, 22);
            this.conTxtMultiline.Text = "Multiline";
            this.conTxtMultiline.Click += new System.EventHandler(this.conTxtMultiline_Click);
            // 
            // conLblFett
            // 
            this.conLblFett.Name = "conLblFett";
            this.conLblFett.Size = new System.Drawing.Size(152, 22);
            this.conLblFett.Text = "Fett";
            this.conLblFett.Click += new System.EventHandler(this.mnuFett_Click);
            // 
            // conLblMenü
            // 
            this.conLblMenü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conLblFett});
            this.conLblMenü.Name = "conLblMenü";
            this.conLblMenü.Size = new System.Drawing.Size(153, 48);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Yellow;
            this.lblA.ContextMenuStrip = this.conLblMenü;
            this.lblA.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(12, 223);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(49, 14);
            this.lblA.TabIndex = 20;
            this.lblA.Text = "(leer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.symHaupt);
            this.Controls.Add(this.mnuHaupt);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Symbolleiste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.symHaupt.ResumeLayout(false);
            this.symHaupt.PerformLayout();
            this.mnuHaupt.ResumeLayout(false);
            this.mnuHaupt.PerformLayout();
            this.conTxtMenü.ResumeLayout(false);
            this.conLblMenü.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip symHaupt;
        internal System.Windows.Forms.ToolStripButton symFett;
        internal System.Windows.Forms.ToolStripButton symKursiv;
        internal System.Windows.Forms.ToolStripLabel symLblSchriftgröße;
        internal System.Windows.Forms.ToolStripComboBox cboSymSchriftgröße;
        internal System.Windows.Forms.MenuStrip mnuHaupt;
        internal System.Windows.Forms.ToolStripMenuItem mnuBearbeiten;
        internal System.Windows.Forms.ToolStripMenuItem mnuKopieren;
        internal System.Windows.Forms.ToolStripMenuItem mnuEnde;
        internal System.Windows.Forms.ToolStripMenuItem mnuAnsicht;
        internal System.Windows.Forms.ToolStripMenuItem mnuHintergrund;
        internal System.Windows.Forms.ToolStripMenuItem mnuGelb;
        internal System.Windows.Forms.ToolStripMenuItem mnuBlau;
        internal System.Windows.Forms.ToolStripMenuItem mnuRot;
        internal System.Windows.Forms.ToolStripSeparator mnuSep1;
        internal System.Windows.Forms.ToolStripMenuItem mnuSchriftart;
        internal System.Windows.Forms.ToolStripMenuItem mnuCourierNew;
        internal System.Windows.Forms.ToolStripMenuItem mnuSymbol;
        internal System.Windows.Forms.ToolStripMenuItem mnuArial;
        internal System.Windows.Forms.ToolStripComboBox cboSchriftgröße;
        internal System.Windows.Forms.ToolStripSeparator mnuSep2;
        internal System.Windows.Forms.ToolStripMenuItem mnuFett;
        internal System.Windows.Forms.ToolStripMenuItem mnuKursiv;
        internal System.Windows.Forms.TextBox txtE;
        internal System.Windows.Forms.ContextMenuStrip conTxtMenü;
        internal System.Windows.Forms.ToolStripMenuItem conTxtReadOnly;
        internal System.Windows.Forms.ToolStripMenuItem conTxtMultiline;
        internal System.Windows.Forms.ToolStripMenuItem conLblFett;
        internal System.Windows.Forms.ContextMenuStrip conLblMenü;
        internal System.Windows.Forms.Label lblA;
    }
}

