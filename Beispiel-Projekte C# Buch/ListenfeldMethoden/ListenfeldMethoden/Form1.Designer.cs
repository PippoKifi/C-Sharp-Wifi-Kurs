namespace ListenfeldMethoden
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
            this.cmdAllesLöschen = new System.Windows.Forms.Button();
            this.lblEinfügen = new System.Windows.Forms.Label();
            this.lblNeu = new System.Windows.Forms.Label();
            this.lblAuswahl = new System.Windows.Forms.Label();
            this.cmdLöschen = new System.Windows.Forms.Button();
            this.txtErsetzen = new System.Windows.Forms.TextBox();
            this.cmdErsetzen = new System.Windows.Forms.Button();
            this.optAuswahl = new System.Windows.Forms.RadioButton();
            this.cmdEinfügen = new System.Windows.Forms.Button();
            this.optAnfang = new System.Windows.Forms.RadioButton();
            this.optEnde = new System.Windows.Forms.RadioButton();
            this.txtNeu = new System.Windows.Forms.TextBox();
            this.lstSpeisen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdAllesLöschen
            // 
            this.cmdAllesLöschen.Location = new System.Drawing.Point(171, 218);
            this.cmdAllesLöschen.Name = "cmdAllesLöschen";
            this.cmdAllesLöschen.Size = new System.Drawing.Size(97, 23);
            this.cmdAllesLöschen.TabIndex = 64;
            this.cmdAllesLöschen.Text = "Alles löschen";
            this.cmdAllesLöschen.UseVisualStyleBackColor = true;
            this.cmdAllesLöschen.Click += new System.EventHandler(this.cmdAllesLöschen_Click);
            // 
            // lblEinfügen
            // 
            this.lblEinfügen.AutoSize = true;
            this.lblEinfügen.Location = new System.Drawing.Point(168, 94);
            this.lblEinfügen.Name = "lblEinfügen";
            this.lblEinfügen.Size = new System.Drawing.Size(58, 13);
            this.lblEinfügen.TabIndex = 63;
            this.lblEinfügen.Text = "Einfügeort:";
            // 
            // lblNeu
            // 
            this.lblNeu.AutoSize = true;
            this.lblNeu.Location = new System.Drawing.Point(168, 12);
            this.lblNeu.Name = "lblNeu";
            this.lblNeu.Size = new System.Drawing.Size(82, 13);
            this.lblNeu.TabIndex = 62;
            this.lblNeu.Text = "Neues Element:";
            // 
            // lblAuswahl
            // 
            this.lblAuswahl.AutoSize = true;
            this.lblAuswahl.Location = new System.Drawing.Point(15, 146);
            this.lblAuswahl.Name = "lblAuswahl";
            this.lblAuswahl.Size = new System.Drawing.Size(117, 13);
            this.lblAuswahl.TabIndex = 61;
            this.lblAuswahl.Text = "Ausgewähltes Element:";
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Location = new System.Drawing.Point(18, 162);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(75, 23);
            this.cmdLöschen.TabIndex = 60;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // txtErsetzen
            // 
            this.txtErsetzen.Location = new System.Drawing.Point(18, 221);
            this.txtErsetzen.Name = "txtErsetzen";
            this.txtErsetzen.Size = new System.Drawing.Size(100, 20);
            this.txtErsetzen.TabIndex = 59;
            // 
            // cmdErsetzen
            // 
            this.cmdErsetzen.Location = new System.Drawing.Point(18, 191);
            this.cmdErsetzen.Name = "cmdErsetzen";
            this.cmdErsetzen.Size = new System.Drawing.Size(100, 23);
            this.cmdErsetzen.TabIndex = 58;
            this.cmdErsetzen.Text = "Ersetzen durch:";
            this.cmdErsetzen.UseVisualStyleBackColor = true;
            this.cmdErsetzen.Click += new System.EventHandler(this.cmdErsetzen_Click);
            // 
            // optAuswahl
            // 
            this.optAuswahl.AutoSize = true;
            this.optAuswahl.Location = new System.Drawing.Point(171, 156);
            this.optAuswahl.Name = "optAuswahl";
            this.optAuswahl.Size = new System.Drawing.Size(153, 17);
            this.optAuswahl.TabIndex = 57;
            this.optAuswahl.Text = "Vor ausgewähltem Element";
            this.optAuswahl.UseVisualStyleBackColor = true;
            // 
            // cmdEinfügen
            // 
            this.cmdEinfügen.Location = new System.Drawing.Point(168, 54);
            this.cmdEinfügen.Name = "cmdEinfügen";
            this.cmdEinfügen.Size = new System.Drawing.Size(75, 23);
            this.cmdEinfügen.TabIndex = 56;
            this.cmdEinfügen.Text = "Einfügen";
            this.cmdEinfügen.UseVisualStyleBackColor = true;
            this.cmdEinfügen.Click += new System.EventHandler(this.cmdEinfügen_Click);
            // 
            // optAnfang
            // 
            this.optAnfang.AutoSize = true;
            this.optAnfang.Location = new System.Drawing.Point(171, 133);
            this.optAnfang.Name = "optAnfang";
            this.optAnfang.Size = new System.Drawing.Size(120, 17);
            this.optAnfang.TabIndex = 55;
            this.optAnfang.Text = "Am Anfang der Liste";
            this.optAnfang.UseVisualStyleBackColor = true;
            // 
            // optEnde
            // 
            this.optEnde.AutoSize = true;
            this.optEnde.Checked = true;
            this.optEnde.Location = new System.Drawing.Point(171, 110);
            this.optEnde.Name = "optEnde";
            this.optEnde.Size = new System.Drawing.Size(111, 17);
            this.optEnde.TabIndex = 54;
            this.optEnde.TabStop = true;
            this.optEnde.Text = "Am Ende der Liste";
            this.optEnde.UseVisualStyleBackColor = true;
            // 
            // txtNeu
            // 
            this.txtNeu.Location = new System.Drawing.Point(168, 28);
            this.txtNeu.Name = "txtNeu";
            this.txtNeu.Size = new System.Drawing.Size(100, 20);
            this.txtNeu.TabIndex = 53;
            // 
            // lstSpeisen
            // 
            this.lstSpeisen.FormattingEnabled = true;
            this.lstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.lstSpeisen.Name = "lstSpeisen";
            this.lstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.lstSpeisen.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.cmdAllesLöschen);
            this.Controls.Add(this.lblEinfügen);
            this.Controls.Add(this.lblNeu);
            this.Controls.Add(this.lblAuswahl);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.txtErsetzen);
            this.Controls.Add(this.cmdErsetzen);
            this.Controls.Add(this.optAuswahl);
            this.Controls.Add(this.cmdEinfügen);
            this.Controls.Add(this.optAnfang);
            this.Controls.Add(this.optEnde);
            this.Controls.Add(this.txtNeu);
            this.Controls.Add(this.lstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Methoden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAllesLöschen;
        internal System.Windows.Forms.Label lblEinfügen;
        internal System.Windows.Forms.Label lblNeu;
        internal System.Windows.Forms.Label lblAuswahl;
        internal System.Windows.Forms.Button cmdLöschen;
        internal System.Windows.Forms.TextBox txtErsetzen;
        internal System.Windows.Forms.Button cmdErsetzen;
        internal System.Windows.Forms.RadioButton optAuswahl;
        internal System.Windows.Forms.Button cmdEinfügen;
        internal System.Windows.Forms.RadioButton optAnfang;
        internal System.Windows.Forms.RadioButton optEnde;
        internal System.Windows.Forms.TextBox txtNeu;
        internal System.Windows.Forms.ListBox lstSpeisen;
    }
}

