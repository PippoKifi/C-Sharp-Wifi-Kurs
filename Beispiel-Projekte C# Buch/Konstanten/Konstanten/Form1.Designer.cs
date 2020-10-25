namespace Konstanten
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
            this.cmdEnumeration2 = new System.Windows.Forms.Button();
            this.cmdEnumeration1 = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdKonstanten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdEnumeration2
            // 
            this.cmdEnumeration2.Location = new System.Drawing.Point(172, 70);
            this.cmdEnumeration2.Name = "cmdEnumeration2";
            this.cmdEnumeration2.Size = new System.Drawing.Size(100, 23);
            this.cmdEnumeration2.TabIndex = 15;
            this.cmdEnumeration2.Text = "Enumeration 2";
            this.cmdEnumeration2.UseVisualStyleBackColor = true;
            this.cmdEnumeration2.Click += new System.EventHandler(this.cmdEnumeration2_Click);
            // 
            // cmdEnumeration1
            // 
            this.cmdEnumeration1.Location = new System.Drawing.Point(172, 41);
            this.cmdEnumeration1.Name = "cmdEnumeration1";
            this.cmdEnumeration1.Size = new System.Drawing.Size(100, 23);
            this.cmdEnumeration1.TabIndex = 14;
            this.cmdEnumeration1.Text = "Enumeration 1";
            this.cmdEnumeration1.UseVisualStyleBackColor = true;
            this.cmdEnumeration1.Click += new System.EventHandler(this.cmdEnumeration1_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(9, 17);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 13;
            // 
            // cmdKonstanten
            // 
            this.cmdKonstanten.Location = new System.Drawing.Point(172, 12);
            this.cmdKonstanten.Name = "cmdKonstanten";
            this.cmdKonstanten.Size = new System.Drawing.Size(100, 23);
            this.cmdKonstanten.TabIndex = 12;
            this.cmdKonstanten.Text = "Konstanten";
            this.cmdKonstanten.UseVisualStyleBackColor = true;
            this.cmdKonstanten.Click += new System.EventHandler(this.cmdKonstanten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdEnumeration2);
            this.Controls.Add(this.cmdEnumeration1);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdKonstanten);
            this.Name = "Form1";
            this.Text = "Konstanten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdEnumeration2;
        internal System.Windows.Forms.Button cmdEnumeration1;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdKonstanten;
    }
}

