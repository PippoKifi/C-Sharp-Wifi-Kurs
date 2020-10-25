namespace XMLDatei
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
            this.cmdObjekteAus = new System.Windows.Forms.Button();
            this.cmdObjekteIn = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdLesen = new System.Windows.Forms.Button();
            this.cmdSchreiben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdObjekteAus
            // 
            this.cmdObjekteAus.Location = new System.Drawing.Point(203, 127);
            this.cmdObjekteAus.Margin = new System.Windows.Forms.Padding(2);
            this.cmdObjekteAus.Name = "cmdObjekteAus";
            this.cmdObjekteAus.Size = new System.Drawing.Size(150, 24);
            this.cmdObjekteAus.TabIndex = 14;
            this.cmdObjekteAus.Text = "Objekte aus XML-Datei";
            this.cmdObjekteAus.UseVisualStyleBackColor = true;
            this.cmdObjekteAus.Click += new System.EventHandler(this.cmdObjekteAus_Click);
            // 
            // cmdObjekteIn
            // 
            this.cmdObjekteIn.Location = new System.Drawing.Point(203, 98);
            this.cmdObjekteIn.Margin = new System.Windows.Forms.Padding(2);
            this.cmdObjekteIn.Name = "cmdObjekteIn";
            this.cmdObjekteIn.Size = new System.Drawing.Size(150, 24);
            this.cmdObjekteIn.TabIndex = 13;
            this.cmdObjekteIn.Text = "Objekte in XML-Datei";
            this.cmdObjekteIn.UseVisualStyleBackColor = true;
            this.cmdObjekteIn.Click += new System.EventHandler(this.cmdObjekteIn_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(10, 8);
            this.lblAnzeige.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.lblAnzeige.TabIndex = 12;
            this.lblAnzeige.Text = "(leer)";
            // 
            // cmdLesen
            // 
            this.cmdLesen.Location = new System.Drawing.Point(241, 40);
            this.cmdLesen.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLesen.Name = "cmdLesen";
            this.cmdLesen.Size = new System.Drawing.Size(112, 24);
            this.cmdLesen.TabIndex = 11;
            this.cmdLesen.Text = "XML-Datei lesen";
            this.cmdLesen.UseVisualStyleBackColor = true;
            this.cmdLesen.Click += new System.EventHandler(this.cmdLesen_Click);
            // 
            // cmdSchreiben
            // 
            this.cmdSchreiben.Location = new System.Drawing.Point(241, 11);
            this.cmdSchreiben.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSchreiben.Name = "cmdSchreiben";
            this.cmdSchreiben.Size = new System.Drawing.Size(112, 24);
            this.cmdSchreiben.TabIndex = 10;
            this.cmdSchreiben.Text = "XML-Datei schreiben";
            this.cmdSchreiben.UseVisualStyleBackColor = true;
            this.cmdSchreiben.Click += new System.EventHandler(this.cmdSchreiben_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 291);
            this.Controls.Add(this.cmdObjekteAus);
            this.Controls.Add(this.cmdObjekteIn);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdLesen);
            this.Controls.Add(this.cmdSchreiben);
            this.Name = "Form1";
            this.Text = "XML-Dateien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdObjekteAus;
        internal System.Windows.Forms.Button cmdObjekteIn;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdLesen;
        internal System.Windows.Forms.Button cmdSchreiben;
    }
}

