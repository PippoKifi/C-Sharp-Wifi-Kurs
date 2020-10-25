namespace Lokalisierung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdEins = new System.Windows.Forms.Button();
            this.cmdZwei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdEins
            // 
            resources.ApplyResources(this.cmdEins, "cmdEins");
            this.cmdEins.Name = "cmdEins";
            this.cmdEins.UseVisualStyleBackColor = true;
            this.cmdEins.Click += new System.EventHandler(this.cmdEins_Click);
            // 
            // cmdZwei
            // 
            resources.ApplyResources(this.cmdZwei, "cmdZwei");
            this.cmdZwei.Name = "cmdZwei";
            this.cmdZwei.UseVisualStyleBackColor = true;
            this.cmdZwei.Click += new System.EventHandler(this.cmdZwei_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdZwei);
            this.Controls.Add(this.cmdEins);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdEins;
        private System.Windows.Forms.Button cmdZwei;
    }
}

