﻿namespace ListenfeldEreignis
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
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdEreignis = new System.Windows.Forms.Button();
            this.lstSpeisen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 125);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 11;
            // 
            // cmdEreignis
            // 
            this.cmdEreignis.Location = new System.Drawing.Point(197, 12);
            this.cmdEreignis.Name = "cmdEreignis";
            this.cmdEreignis.Size = new System.Drawing.Size(75, 23);
            this.cmdEreignis.TabIndex = 10;
            this.cmdEreignis.Text = "Ereignis";
            this.cmdEreignis.UseVisualStyleBackColor = true;
            this.cmdEreignis.Click += new System.EventHandler(this.cmdEreignis_Click);
            // 
            // lstSpeisen
            // 
            this.lstSpeisen.FormattingEnabled = true;
            this.lstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.lstSpeisen.Name = "lstSpeisen";
            this.lstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.lstSpeisen.TabIndex = 9;
            this.lstSpeisen.SelectedIndexChanged += new System.EventHandler(this.lstSpeisen_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdEreignis);
            this.Controls.Add(this.lstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Ereignis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdEreignis;
        internal System.Windows.Forms.ListBox lstSpeisen;
    }
}

