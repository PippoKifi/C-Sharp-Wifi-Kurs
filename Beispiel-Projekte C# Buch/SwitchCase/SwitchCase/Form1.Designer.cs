﻿namespace SwitchCase
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
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.cmdAnzeigen2 = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdAnzeigen1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.SuspendLayout();
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(197, 12);
            this.numX.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(75, 20);
            this.numX.TabIndex = 7;
            this.numX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmdAnzeigen2
            // 
            this.cmdAnzeigen2.Location = new System.Drawing.Point(197, 67);
            this.cmdAnzeigen2.Name = "cmdAnzeigen2";
            this.cmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen2.TabIndex = 6;
            this.cmdAnzeigen2.Text = "Anzeigen 2";
            this.cmdAnzeigen2.UseVisualStyleBackColor = true;
            this.cmdAnzeigen2.Click += new System.EventHandler(this.cmdAnzeigen2_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 17);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 5;
            // 
            // cmdAnzeigen1
            // 
            this.cmdAnzeigen1.Location = new System.Drawing.Point(197, 38);
            this.cmdAnzeigen1.Name = "cmdAnzeigen1";
            this.cmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen1.TabIndex = 4;
            this.cmdAnzeigen1.Text = "Anzeigen 1";
            this.cmdAnzeigen1.UseVisualStyleBackColor = true;
            this.cmdAnzeigen1.Click += new System.EventHandler(this.cmdAnzeigen1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.cmdAnzeigen2);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdAnzeigen1);
            this.Name = "Form1";
            this.Text = "Switch Case";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Button cmdAnzeigen2;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button cmdAnzeigen1;
    }
}
