﻿namespace DatenfeldVerzweigt
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
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(197, 12);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige.TabIndex = 3;
            this.cmdAnzeige.Text = "Anzeigen";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(7, 52);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Datenfeld, verzweigt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAnzeige;
        private System.Windows.Forms.Label lblA;
    }
}
