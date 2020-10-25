namespace ReferenzenVergleicheTypen
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
            this.cmdKlasseVergleichen = new System.Windows.Forms.Button();
            this.cmdKlasseErmitteln = new System.Windows.Forms.Button();
            this.cmdObjekteVergleichen = new System.Windows.Forms.Button();
            this.cmdReferenzenVergleichen = new System.Windows.Forms.Button();
            this.cmdReferenzZuweisen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdKlasseVergleichen
            // 
            this.cmdKlasseVergleichen.Location = new System.Drawing.Point(12, 129);
            this.cmdKlasseVergleichen.Name = "cmdKlasseVergleichen";
            this.cmdKlasseVergleichen.Size = new System.Drawing.Size(135, 23);
            this.cmdKlasseVergleichen.TabIndex = 26;
            this.cmdKlasseVergleichen.Text = "Klasse vergleichen";
            this.cmdKlasseVergleichen.UseVisualStyleBackColor = true;
            this.cmdKlasseVergleichen.Click += new System.EventHandler(this.cmdKlasseVergleichen_Click);
            // 
            // cmdKlasseErmitteln
            // 
            this.cmdKlasseErmitteln.Location = new System.Drawing.Point(12, 99);
            this.cmdKlasseErmitteln.Name = "cmdKlasseErmitteln";
            this.cmdKlasseErmitteln.Size = new System.Drawing.Size(135, 23);
            this.cmdKlasseErmitteln.TabIndex = 25;
            this.cmdKlasseErmitteln.Text = "Klasse ermitteln";
            this.cmdKlasseErmitteln.UseVisualStyleBackColor = true;
            this.cmdKlasseErmitteln.Click += new System.EventHandler(this.cmdKlasseErmitteln_Click);
            // 
            // cmdObjekteVergleichen
            // 
            this.cmdObjekteVergleichen.Location = new System.Drawing.Point(12, 70);
            this.cmdObjekteVergleichen.Name = "cmdObjekteVergleichen";
            this.cmdObjekteVergleichen.Size = new System.Drawing.Size(135, 23);
            this.cmdObjekteVergleichen.TabIndex = 24;
            this.cmdObjekteVergleichen.Text = "Objekte vergleichen";
            this.cmdObjekteVergleichen.UseVisualStyleBackColor = true;
            this.cmdObjekteVergleichen.Click += new System.EventHandler(this.cmdObjekteVergleichen_Click);
            // 
            // cmdReferenzenVergleichen
            // 
            this.cmdReferenzenVergleichen.Location = new System.Drawing.Point(12, 41);
            this.cmdReferenzenVergleichen.Name = "cmdReferenzenVergleichen";
            this.cmdReferenzenVergleichen.Size = new System.Drawing.Size(135, 23);
            this.cmdReferenzenVergleichen.TabIndex = 23;
            this.cmdReferenzenVergleichen.Text = "Referenzen vergleichen";
            this.cmdReferenzenVergleichen.UseVisualStyleBackColor = true;
            this.cmdReferenzenVergleichen.Click += new System.EventHandler(this.cmdReferenzenVergleichen_Click);
            // 
            // cmdReferenzZuweisen
            // 
            this.cmdReferenzZuweisen.Location = new System.Drawing.Point(12, 12);
            this.cmdReferenzZuweisen.Name = "cmdReferenzZuweisen";
            this.cmdReferenzZuweisen.Size = new System.Drawing.Size(135, 23);
            this.cmdReferenzZuweisen.TabIndex = 22;
            this.cmdReferenzZuweisen.Text = "Referenz zuweisen";
            this.cmdReferenzZuweisen.UseVisualStyleBackColor = true;
            this.cmdReferenzZuweisen.Click += new System.EventHandler(this.cmdReferenzZuweisen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.cmdKlasseVergleichen);
            this.Controls.Add(this.cmdKlasseErmitteln);
            this.Controls.Add(this.cmdObjekteVergleichen);
            this.Controls.Add(this.cmdReferenzenVergleichen);
            this.Controls.Add(this.cmdReferenzZuweisen);
            this.Name = "Form1";
            this.Text = "Referenzen, Vergleiche, Typen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdKlasseVergleichen;
        internal System.Windows.Forms.Button cmdKlasseErmitteln;
        internal System.Windows.Forms.Button cmdObjekteVergleichen;
        internal System.Windows.Forms.Button cmdReferenzenVergleichen;
        internal System.Windows.Forms.Button cmdReferenzZuweisen;
    }
}

