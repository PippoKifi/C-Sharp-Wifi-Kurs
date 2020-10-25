namespace Rechenoperatoren
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
            this.cmdModulo2 = new System.Windows.Forms.Button();
            this.cmdModulo1 = new System.Windows.Forms.Button();
            this.cmdAnzeigen3 = new System.Windows.Forms.Button();
            this.cmdAnzeigen2 = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdAnzeigen1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdModulo2
            // 
            this.cmdModulo2.Location = new System.Drawing.Point(197, 128);
            this.cmdModulo2.Name = "cmdModulo2";
            this.cmdModulo2.Size = new System.Drawing.Size(75, 23);
            this.cmdModulo2.TabIndex = 20;
            this.cmdModulo2.Text = "19.5 % 4.2";
            this.cmdModulo2.UseVisualStyleBackColor = true;
            this.cmdModulo2.Click += new System.EventHandler(this.cmdModulo2_Click);
            // 
            // cmdModulo1
            // 
            this.cmdModulo1.Location = new System.Drawing.Point(197, 99);
            this.cmdModulo1.Name = "cmdModulo1";
            this.cmdModulo1.Size = new System.Drawing.Size(75, 23);
            this.cmdModulo1.TabIndex = 19;
            this.cmdModulo1.Text = "19 % 4";
            this.cmdModulo1.UseVisualStyleBackColor = true;
            this.cmdModulo1.Click += new System.EventHandler(this.cmdModulo1_Click);
            // 
            // cmdAnzeigen3
            // 
            this.cmdAnzeigen3.Location = new System.Drawing.Point(197, 70);
            this.cmdAnzeigen3.Name = "cmdAnzeigen3";
            this.cmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen3.TabIndex = 18;
            this.cmdAnzeigen3.Text = "++x";
            this.cmdAnzeigen3.UseVisualStyleBackColor = true;
            this.cmdAnzeigen3.Click += new System.EventHandler(this.cmdAnzeigen3_Click);
            // 
            // cmdAnzeigen2
            // 
            this.cmdAnzeigen2.Location = new System.Drawing.Point(197, 41);
            this.cmdAnzeigen2.Name = "cmdAnzeigen2";
            this.cmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen2.TabIndex = 17;
            this.cmdAnzeigen2.Text = "x++";
            this.cmdAnzeigen2.UseVisualStyleBackColor = true;
            this.cmdAnzeigen2.Click += new System.EventHandler(this.cmdAnzeigen2_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 16;
            // 
            // cmdAnzeigen1
            // 
            this.cmdAnzeigen1.Location = new System.Drawing.Point(197, 12);
            this.cmdAnzeigen1.Name = "cmdAnzeigen1";
            this.cmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen1.TabIndex = 15;
            this.cmdAnzeigen1.Text = "alle 3";
            this.cmdAnzeigen1.UseVisualStyleBackColor = true;
            this.cmdAnzeigen1.Click += new System.EventHandler(this.cmdAnzeigen1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdModulo2);
            this.Controls.Add(this.cmdModulo1);
            this.Controls.Add(this.cmdAnzeigen3);
            this.Controls.Add(this.cmdAnzeigen2);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdAnzeigen1);
            this.Name = "Form1";
            this.Text = "Rechenoperatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdModulo2;
        internal System.Windows.Forms.Button cmdModulo1;
        internal System.Windows.Forms.Button cmdAnzeigen3;
        internal System.Windows.Forms.Button cmdAnzeigen2;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdAnzeigen1;
    }
}

