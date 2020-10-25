namespace TextfeldKoppeln
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
            this.lblProjektmappenname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProjektmappenname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProjektmappenname
            // 
            this.lblProjektmappenname.AutoSize = true;
            this.lblProjektmappenname.Location = new System.Drawing.Point(168, 38);
            this.lblProjektmappenname.Name = "lblProjektmappenname";
            this.lblProjektmappenname.Size = new System.Drawing.Size(104, 13);
            this.lblProjektmappenname.TabIndex = 15;
            this.lblProjektmappenname.Text = "Projektmappenname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(168, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtProjektmappenname
            // 
            this.txtProjektmappenname.Location = new System.Drawing.Point(12, 38);
            this.txtProjektmappenname.Name = "txtProjektmappenname";
            this.txtProjektmappenname.Size = new System.Drawing.Size(150, 20);
            this.txtProjektmappenname.TabIndex = 13;
            this.txtProjektmappenname.Text = "Standardtext";
            this.txtProjektmappenname.Click += new System.EventHandler(this.txtProjektmappenname_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "Standardtext";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lblProjektmappenname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtProjektmappenname);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Textfelder koppeln";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblProjektmappenname;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox txtProjektmappenname;
        internal System.Windows.Forms.TextBox txtName;
    }
}

