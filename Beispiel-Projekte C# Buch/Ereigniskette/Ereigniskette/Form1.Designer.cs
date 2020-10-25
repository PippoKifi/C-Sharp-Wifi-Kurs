namespace Ereigniskette
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
            this.cmdEreignis3 = new System.Windows.Forms.Button();
            this.cmdLöschen = new System.Windows.Forms.Button();
            this.lblAnzeige2 = new System.Windows.Forms.Label();
            this.lblAnzeige1 = new System.Windows.Forms.Label();
            this.cmdEreignis2 = new System.Windows.Forms.Button();
            this.cmdEreignis1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdEreignis3
            // 
            this.cmdEreignis3.Location = new System.Drawing.Point(197, 83);
            this.cmdEreignis3.Name = "cmdEreignis3";
            this.cmdEreignis3.Size = new System.Drawing.Size(75, 23);
            this.cmdEreignis3.TabIndex = 23;
            this.cmdEreignis3.Text = "Ereignis 1+2";
            this.cmdEreignis3.UseVisualStyleBackColor = true;
            this.cmdEreignis3.Click += new System.EventHandler(this.cmdEreignis3_Click);
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Location = new System.Drawing.Point(197, 112);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(75, 23);
            this.cmdLöschen.TabIndex = 22;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // lblAnzeige2
            // 
            this.lblAnzeige2.AutoSize = true;
            this.lblAnzeige2.Location = new System.Drawing.Point(12, 59);
            this.lblAnzeige2.Name = "lblAnzeige2";
            this.lblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige2.TabIndex = 21;
            // 
            // lblAnzeige1
            // 
            this.lblAnzeige1.AutoSize = true;
            this.lblAnzeige1.Location = new System.Drawing.Point(12, 30);
            this.lblAnzeige1.Name = "lblAnzeige1";
            this.lblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige1.TabIndex = 20;
            // 
            // cmdEreignis2
            // 
            this.cmdEreignis2.Location = new System.Drawing.Point(197, 54);
            this.cmdEreignis2.Name = "cmdEreignis2";
            this.cmdEreignis2.Size = new System.Drawing.Size(75, 23);
            this.cmdEreignis2.TabIndex = 19;
            this.cmdEreignis2.Text = "Ereignis 2";
            this.cmdEreignis2.UseVisualStyleBackColor = true;
            this.cmdEreignis2.Click += new System.EventHandler(this.cmdEreignis2_Click);
            // 
            // cmdEreignis1
            // 
            this.cmdEreignis1.Location = new System.Drawing.Point(197, 25);
            this.cmdEreignis1.Name = "cmdEreignis1";
            this.cmdEreignis1.Size = new System.Drawing.Size(75, 23);
            this.cmdEreignis1.TabIndex = 18;
            this.cmdEreignis1.Text = "Ereignis 1";
            this.cmdEreignis1.UseVisualStyleBackColor = true;
            this.cmdEreignis1.Click += new System.EventHandler(this.cmdEreignis1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdEreignis3);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.lblAnzeige2);
            this.Controls.Add(this.lblAnzeige1);
            this.Controls.Add(this.cmdEreignis2);
            this.Controls.Add(this.cmdEreignis1);
            this.Name = "Form1";
            this.Text = "Ereigniskette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdEreignis3;
        internal System.Windows.Forms.Button cmdLöschen;
        internal System.Windows.Forms.Label lblAnzeige2;
        internal System.Windows.Forms.Label lblAnzeige1;
        internal System.Windows.Forms.Button cmdEreignis2;
        internal System.Windows.Forms.Button cmdEreignis1;
    }
}

