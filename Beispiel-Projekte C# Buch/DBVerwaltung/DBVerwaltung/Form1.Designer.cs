namespace DBVerwaltung
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
            this.cmdNameSuchen = new System.Windows.Forms.Button();
            this.lblGeburtstag = new System.Windows.Forms.Label();
            this.lblGehalt = new System.Windows.Forms.Label();
            this.lblPersonalnummer = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGeburtstag = new System.Windows.Forms.TextBox();
            this.txtGehalt = new System.Windows.Forms.TextBox();
            this.txtPersonalnummer = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstTab = new System.Windows.Forms.ListBox();
            this.cmdLöschen = new System.Windows.Forms.Button();
            this.cmdÄndern = new System.Windows.Forms.Button();
            this.cmdEinfügen = new System.Windows.Forms.Button();
            this.cmdAlleSehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNameSuchen
            // 
            this.cmdNameSuchen.Location = new System.Drawing.Point(304, 13);
            this.cmdNameSuchen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNameSuchen.Name = "cmdNameSuchen";
            this.cmdNameSuchen.Size = new System.Drawing.Size(133, 28);
            this.cmdNameSuchen.TabIndex = 95;
            this.cmdNameSuchen.Text = "Name suchen";
            this.cmdNameSuchen.UseVisualStyleBackColor = true;
            this.cmdNameSuchen.Click += new System.EventHandler(this.cmdNameSuchen_Click);
            // 
            // lblGeburtstag
            // 
            this.lblGeburtstag.AutoSize = true;
            this.lblGeburtstag.Location = new System.Drawing.Point(178, 180);
            this.lblGeburtstag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeburtstag.Name = "lblGeburtstag";
            this.lblGeburtstag.Size = new System.Drawing.Size(83, 17);
            this.lblGeburtstag.TabIndex = 94;
            this.lblGeburtstag.Text = "Geburtstag:";
            // 
            // lblGehalt
            // 
            this.lblGehalt.AutoSize = true;
            this.lblGehalt.Location = new System.Drawing.Point(178, 148);
            this.lblGehalt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGehalt.Name = "lblGehalt";
            this.lblGehalt.Size = new System.Drawing.Size(54, 17);
            this.lblGehalt.TabIndex = 93;
            this.lblGehalt.Text = "Gehalt:";
            // 
            // lblPersonalnummer
            // 
            this.lblPersonalnummer.AutoSize = true;
            this.lblPersonalnummer.Location = new System.Drawing.Point(178, 116);
            this.lblPersonalnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalnummer.Name = "lblPersonalnummer";
            this.lblPersonalnummer.Size = new System.Drawing.Size(119, 17);
            this.lblPersonalnummer.TabIndex = 92;
            this.lblPersonalnummer.Text = "Personalnummer:";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(178, 84);
            this.lblVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(69, 17);
            this.lblVorname.TabIndex = 91;
            this.lblVorname.Text = "Vorname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(178, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 90;
            this.lblName.Text = "Name:";
            // 
            // txtGeburtstag
            // 
            this.txtGeburtstag.Location = new System.Drawing.Point(304, 176);
            this.txtGeburtstag.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeburtstag.Name = "txtGeburtstag";
            this.txtGeburtstag.Size = new System.Drawing.Size(132, 22);
            this.txtGeburtstag.TabIndex = 89;
            // 
            // txtGehalt
            // 
            this.txtGehalt.Location = new System.Drawing.Point(304, 144);
            this.txtGehalt.Margin = new System.Windows.Forms.Padding(4);
            this.txtGehalt.Name = "txtGehalt";
            this.txtGehalt.Size = new System.Drawing.Size(132, 22);
            this.txtGehalt.TabIndex = 88;
            // 
            // txtPersonalnummer
            // 
            this.txtPersonalnummer.Location = new System.Drawing.Point(304, 112);
            this.txtPersonalnummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonalnummer.Name = "txtPersonalnummer";
            this.txtPersonalnummer.Size = new System.Drawing.Size(132, 22);
            this.txtPersonalnummer.TabIndex = 87;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(304, 80);
            this.txtVorname.Margin = new System.Windows.Forms.Padding(4);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(132, 22);
            this.txtVorname.TabIndex = 86;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(304, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 85;
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.ItemHeight = 16;
            this.lstTab.Location = new System.Drawing.Point(13, 223);
            this.lstTab.Margin = new System.Windows.Forms.Padding(4);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(423, 148);
            this.lstTab.TabIndex = 84;
            this.lstTab.SelectedIndexChanged += new System.EventHandler(this.lstTab_SelectedIndexChanged);
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Location = new System.Drawing.Point(13, 120);
            this.cmdLöschen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(100, 28);
            this.cmdLöschen.TabIndex = 83;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // cmdÄndern
            // 
            this.cmdÄndern.Location = new System.Drawing.Point(13, 84);
            this.cmdÄndern.Margin = new System.Windows.Forms.Padding(4);
            this.cmdÄndern.Name = "cmdÄndern";
            this.cmdÄndern.Size = new System.Drawing.Size(100, 28);
            this.cmdÄndern.TabIndex = 82;
            this.cmdÄndern.Text = "Ändern";
            this.cmdÄndern.UseVisualStyleBackColor = true;
            this.cmdÄndern.Click += new System.EventHandler(this.cmdÄndern_Click);
            // 
            // cmdEinfügen
            // 
            this.cmdEinfügen.Location = new System.Drawing.Point(13, 48);
            this.cmdEinfügen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEinfügen.Name = "cmdEinfügen";
            this.cmdEinfügen.Size = new System.Drawing.Size(100, 28);
            this.cmdEinfügen.TabIndex = 81;
            this.cmdEinfügen.Text = "Einfügen";
            this.cmdEinfügen.UseVisualStyleBackColor = true;
            this.cmdEinfügen.Click += new System.EventHandler(this.cmdEinfügen_Click);
            // 
            // cmdAlleSehen
            // 
            this.cmdAlleSehen.Location = new System.Drawing.Point(13, 13);
            this.cmdAlleSehen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAlleSehen.Name = "cmdAlleSehen";
            this.cmdAlleSehen.Size = new System.Drawing.Size(100, 28);
            this.cmdAlleSehen.TabIndex = 80;
            this.cmdAlleSehen.Text = "Alle sehen";
            this.cmdAlleSehen.UseVisualStyleBackColor = true;
            this.cmdAlleSehen.Click += new System.EventHandler(this.cmdAlleSehen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 395);
            this.Controls.Add(this.cmdNameSuchen);
            this.Controls.Add(this.lblGeburtstag);
            this.Controls.Add(this.lblGehalt);
            this.Controls.Add(this.lblPersonalnummer);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtGeburtstag);
            this.Controls.Add(this.txtGehalt);
            this.Controls.Add(this.txtPersonalnummer);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstTab);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.cmdÄndern);
            this.Controls.Add(this.cmdEinfügen);
            this.Controls.Add(this.cmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Datenbank, Verwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdNameSuchen;
        internal System.Windows.Forms.Label lblGeburtstag;
        internal System.Windows.Forms.Label lblGehalt;
        internal System.Windows.Forms.Label lblPersonalnummer;
        internal System.Windows.Forms.Label lblVorname;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox txtGeburtstag;
        internal System.Windows.Forms.TextBox txtGehalt;
        internal System.Windows.Forms.TextBox txtPersonalnummer;
        internal System.Windows.Forms.TextBox txtVorname;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ListBox lstTab;
        internal System.Windows.Forms.Button cmdLöschen;
        internal System.Windows.Forms.Button cmdÄndern;
        internal System.Windows.Forms.Button cmdEinfügen;
        internal System.Windows.Forms.Button cmdAlleSehen;
    }
}

