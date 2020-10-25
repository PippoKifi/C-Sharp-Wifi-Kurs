namespace ÜSteuerbetrag
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
            this.lblSteuerbetrag = new System.Windows.Forms.Label();
            this.lblGehalt = new System.Windows.Forms.Label();
            this.txtGehalt = new System.Windows.Forms.TextBox();
            this.cmdBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSteuerbetrag
            // 
            this.lblSteuerbetrag.AutoSize = true;
            this.lblSteuerbetrag.Location = new System.Drawing.Point(125, 29);
            this.lblSteuerbetrag.Name = "lblSteuerbetrag";
            this.lblSteuerbetrag.Size = new System.Drawing.Size(0, 13);
            this.lblSteuerbetrag.TabIndex = 21;
            // 
            // lblGehalt
            // 
            this.lblGehalt.AutoSize = true;
            this.lblGehalt.Location = new System.Drawing.Point(12, 9);
            this.lblGehalt.Name = "lblGehalt";
            this.lblGehalt.Size = new System.Drawing.Size(41, 13);
            this.lblGehalt.TabIndex = 20;
            this.lblGehalt.Text = "Gehalt:";
            // 
            // txtGehalt
            // 
            this.txtGehalt.Location = new System.Drawing.Point(12, 25);
            this.txtGehalt.Name = "txtGehalt";
            this.txtGehalt.Size = new System.Drawing.Size(100, 20);
            this.txtGehalt.TabIndex = 19;
            this.txtGehalt.Text = "0";
            // 
            // cmdBerechnen
            // 
            this.cmdBerechnen.Location = new System.Drawing.Point(12, 60);
            this.cmdBerechnen.Name = "cmdBerechnen";
            this.cmdBerechnen.Size = new System.Drawing.Size(100, 23);
            this.cmdBerechnen.TabIndex = 18;
            this.cmdBerechnen.Text = "Berechnen";
            this.cmdBerechnen.UseVisualStyleBackColor = true;
            this.cmdBerechnen.Click += new System.EventHandler(this.cmdBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.lblSteuerbetrag);
            this.Controls.Add(this.lblGehalt);
            this.Controls.Add(this.txtGehalt);
            this.Controls.Add(this.cmdBerechnen);
            this.Name = "Form1";
            this.Text = "Steuerbetrag berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblSteuerbetrag;
        internal System.Windows.Forms.Label lblGehalt;
        internal System.Windows.Forms.TextBox txtGehalt;
        internal System.Windows.Forms.Button cmdBerechnen;
    }
}

