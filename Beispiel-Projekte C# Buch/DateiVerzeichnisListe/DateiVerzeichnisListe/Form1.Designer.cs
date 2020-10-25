namespace DateiVerzeichnisListe
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
            this.lblCurDir = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdNachOben = new System.Windows.Forms.Button();
            this.cmdInVerzeichnis = new System.Windows.Forms.Button();
            this.cmdSystemeinträge = new System.Windows.Forms.Button();
            this.lstA = new System.Windows.Forms.ListBox();
            this.cmdDateiliste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurDir
            // 
            this.lblCurDir.AutoSize = true;
            this.lblCurDir.Location = new System.Drawing.Point(19, 46);
            this.lblCurDir.Name = "lblCurDir";
            this.lblCurDir.Size = new System.Drawing.Size(0, 13);
            this.lblCurDir.TabIndex = 29;
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(17, 240);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 28;
            // 
            // cmdNachOben
            // 
            this.cmdNachOben.Location = new System.Drawing.Point(300, 12);
            this.cmdNachOben.Name = "cmdNachOben";
            this.cmdNachOben.Size = new System.Drawing.Size(80, 23);
            this.cmdNachOben.TabIndex = 27;
            this.cmdNachOben.Text = "nach oben";
            this.cmdNachOben.UseVisualStyleBackColor = true;
            this.cmdNachOben.Click += new System.EventHandler(this.cmdNachOben_Click);
            // 
            // cmdInVerzeichnis
            // 
            this.cmdInVerzeichnis.Location = new System.Drawing.Point(214, 12);
            this.cmdInVerzeichnis.Name = "cmdInVerzeichnis";
            this.cmdInVerzeichnis.Size = new System.Drawing.Size(80, 23);
            this.cmdInVerzeichnis.TabIndex = 26;
            this.cmdInVerzeichnis.Text = "in Verzeichnis";
            this.cmdInVerzeichnis.UseVisualStyleBackColor = true;
            this.cmdInVerzeichnis.Click += new System.EventHandler(this.cmdInVerzeichnis_Click);
            // 
            // cmdSystemeinträge
            // 
            this.cmdSystemeinträge.Location = new System.Drawing.Point(98, 12);
            this.cmdSystemeinträge.Name = "cmdSystemeinträge";
            this.cmdSystemeinträge.Size = new System.Drawing.Size(90, 23);
            this.cmdSystemeinträge.TabIndex = 25;
            this.cmdSystemeinträge.Text = "Systemeinträge";
            this.cmdSystemeinträge.UseVisualStyleBackColor = true;
            this.cmdSystemeinträge.Click += new System.EventHandler(this.cmdSystemeinträge_Click);
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(12, 70);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(368, 160);
            this.lstA.TabIndex = 24;
            this.lstA.SelectedIndexChanged += new System.EventHandler(this.lstA_SelectedIndexChanged);
            // 
            // cmdDateiliste
            // 
            this.cmdDateiliste.Location = new System.Drawing.Point(12, 12);
            this.cmdDateiliste.Name = "cmdDateiliste";
            this.cmdDateiliste.Size = new System.Drawing.Size(80, 23);
            this.cmdDateiliste.TabIndex = 23;
            this.cmdDateiliste.Text = "Dateiliste";
            this.cmdDateiliste.UseVisualStyleBackColor = true;
            this.cmdDateiliste.Click += new System.EventHandler(this.cmdDateiliste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 321);
            this.Controls.Add(this.lblCurDir);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdNachOben);
            this.Controls.Add(this.cmdInVerzeichnis);
            this.Controls.Add(this.cmdSystemeinträge);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.cmdDateiliste);
            this.Name = "Form1";
            this.Text = "Datei- und Verzeichnisliste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCurDir;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdNachOben;
        internal System.Windows.Forms.Button cmdInVerzeichnis;
        internal System.Windows.Forms.Button cmdSystemeinträge;
        internal System.Windows.Forms.ListBox lstA;
        internal System.Windows.Forms.Button cmdDateiliste;
    }
}

