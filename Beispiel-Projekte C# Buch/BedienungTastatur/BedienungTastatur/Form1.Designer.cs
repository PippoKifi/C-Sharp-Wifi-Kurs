namespace BedienungTastatur
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
            this.chkMietwagen = new System.Windows.Forms.CheckBox();
            this.optPrag = new System.Windows.Forms.RadioButton();
            this.optParis = new System.Windows.Forms.RadioButton();
            this.optBerlin = new System.Windows.Forms.RadioButton();
            this.cmdBestellen = new System.Windows.Forms.Button();
            this.txtEingabe4 = new System.Windows.Forms.TextBox();
            this.txtEingabe3 = new System.Windows.Forms.TextBox();
            this.txtEingabe2 = new System.Windows.Forms.TextBox();
            this.txtEingabe1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkMietwagen
            // 
            this.chkMietwagen.AutoSize = true;
            this.chkMietwagen.Location = new System.Drawing.Point(182, 113);
            this.chkMietwagen.Name = "chkMietwagen";
            this.chkMietwagen.Size = new System.Drawing.Size(78, 17);
            this.chkMietwagen.TabIndex = 17;
            this.chkMietwagen.Text = "Miet&wagen";
            this.chkMietwagen.UseVisualStyleBackColor = true;
            // 
            // optPrag
            // 
            this.optPrag.AutoSize = true;
            this.optPrag.Location = new System.Drawing.Point(182, 85);
            this.optPrag.Name = "optPrag";
            this.optPrag.Size = new System.Drawing.Size(47, 17);
            this.optPrag.TabIndex = 16;
            this.optPrag.TabStop = true;
            this.optPrag.Text = "P&rag";
            this.optPrag.UseVisualStyleBackColor = true;
            // 
            // optParis
            // 
            this.optParis.AutoSize = true;
            this.optParis.Location = new System.Drawing.Point(182, 62);
            this.optParis.Name = "optParis";
            this.optParis.Size = new System.Drawing.Size(48, 17);
            this.optParis.TabIndex = 15;
            this.optParis.TabStop = true;
            this.optParis.Text = "&Paris";
            this.optParis.UseVisualStyleBackColor = true;
            // 
            // optBerlin
            // 
            this.optBerlin.AutoSize = true;
            this.optBerlin.Checked = true;
            this.optBerlin.Location = new System.Drawing.Point(182, 39);
            this.optBerlin.Name = "optBerlin";
            this.optBerlin.Size = new System.Drawing.Size(51, 17);
            this.optBerlin.TabIndex = 14;
            this.optBerlin.TabStop = true;
            this.optBerlin.Text = "Berl&in";
            this.optBerlin.UseVisualStyleBackColor = true;
            // 
            // cmdBestellen
            // 
            this.cmdBestellen.Location = new System.Drawing.Point(197, 10);
            this.cmdBestellen.Name = "cmdBestellen";
            this.cmdBestellen.Size = new System.Drawing.Size(75, 23);
            this.cmdBestellen.TabIndex = 13;
            this.cmdBestellen.Text = "&Bestellen";
            this.cmdBestellen.UseVisualStyleBackColor = true;
            this.cmdBestellen.Click += new System.EventHandler(this.cmdBestellen_Click);
            // 
            // txtEingabe4
            // 
            this.txtEingabe4.Location = new System.Drawing.Point(12, 90);
            this.txtEingabe4.Name = "txtEingabe4";
            this.txtEingabe4.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe4.TabIndex = 11;
            // 
            // txtEingabe3
            // 
            this.txtEingabe3.Location = new System.Drawing.Point(12, 64);
            this.txtEingabe3.Name = "txtEingabe3";
            this.txtEingabe3.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe3.TabIndex = 10;
            this.txtEingabe3.TabStop = false;
            // 
            // txtEingabe2
            // 
            this.txtEingabe2.Location = new System.Drawing.Point(12, 38);
            this.txtEingabe2.Name = "txtEingabe2";
            this.txtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe2.TabIndex = 12;
            // 
            // txtEingabe1
            // 
            this.txtEingabe1.Location = new System.Drawing.Point(12, 12);
            this.txtEingabe1.Name = "txtEingabe1";
            this.txtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkMietwagen);
            this.Controls.Add(this.optPrag);
            this.Controls.Add(this.optParis);
            this.Controls.Add(this.optBerlin);
            this.Controls.Add(this.cmdBestellen);
            this.Controls.Add(this.txtEingabe4);
            this.Controls.Add(this.txtEingabe3);
            this.Controls.Add(this.txtEingabe2);
            this.Controls.Add(this.txtEingabe1);
            this.Name = "Form1";
            this.Text = "Bedienung per Tastatur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkMietwagen;
        internal System.Windows.Forms.RadioButton optPrag;
        internal System.Windows.Forms.RadioButton optParis;
        internal System.Windows.Forms.RadioButton optBerlin;
        internal System.Windows.Forms.Button cmdBestellen;
        internal System.Windows.Forms.TextBox txtEingabe4;
        internal System.Windows.Forms.TextBox txtEingabe3;
        internal System.Windows.Forms.TextBox txtEingabe2;
        internal System.Windows.Forms.TextBox txtEingabe1;
    }
}

