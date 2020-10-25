namespace DatumPicker
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
            this.lblPlusTag = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.datPicker4 = new System.Windows.Forms.DateTimePicker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.datPicker3 = new System.Windows.Forms.DateTimePicker();
            this.datPicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.datPicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblPlusTag
            // 
            this.lblPlusTag.AutoSize = true;
            this.lblPlusTag.Location = new System.Drawing.Point(190, 121);
            this.lblPlusTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlusTag.Name = "lblPlusTag";
            this.lblPlusTag.Size = new System.Drawing.Size(0, 13);
            this.lblPlusTag.TabIndex = 30;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(11, 76);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(43, 13);
            this.lbl4.TabIndex = 29;
            this.lbl4.Text = "Uhrzeit:";
            // 
            // datPicker4
            // 
            this.datPicker4.Location = new System.Drawing.Point(92, 76);
            this.datPicker4.Margin = new System.Windows.Forms.Padding(2);
            this.datPicker4.Name = "datPicker4";
            this.datPicker4.Size = new System.Drawing.Size(100, 20);
            this.datPicker4.TabIndex = 28;
            this.datPicker4.ValueChanged += new System.EventHandler(this.datPicker_ValueChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(11, 55);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 13);
            this.lbl3.TabIndex = 27;
            this.lbl3.Text = "UpDown:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(11, 32);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(63, 13);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "Eig. Format:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(11, 9);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 13);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "Standard:";
            // 
            // datPicker3
            // 
            this.datPicker3.Location = new System.Drawing.Point(92, 55);
            this.datPicker3.Margin = new System.Windows.Forms.Padding(2);
            this.datPicker3.Name = "datPicker3";
            this.datPicker3.Size = new System.Drawing.Size(100, 20);
            this.datPicker3.TabIndex = 24;
            this.datPicker3.ValueChanged += new System.EventHandler(this.datPicker_ValueChanged);
            // 
            // datPicker2
            // 
            this.datPicker2.Location = new System.Drawing.Point(92, 32);
            this.datPicker2.Margin = new System.Windows.Forms.Padding(2);
            this.datPicker2.Name = "datPicker2";
            this.datPicker2.Size = new System.Drawing.Size(100, 20);
            this.datPicker2.TabIndex = 23;
            this.datPicker2.ValueChanged += new System.EventHandler(this.datPicker_ValueChanged);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(190, 97);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 22;
            // 
            // datPicker1
            // 
            this.datPicker1.Location = new System.Drawing.Point(92, 9);
            this.datPicker1.Margin = new System.Windows.Forms.Padding(2);
            this.datPicker1.Name = "datPicker1";
            this.datPicker1.Size = new System.Drawing.Size(200, 20);
            this.datPicker1.TabIndex = 21;
            this.datPicker1.ValueChanged += new System.EventHandler(this.datPicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 161);
            this.Controls.Add(this.lblPlusTag);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.datPicker4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.datPicker3);
            this.Controls.Add(this.datPicker2);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.datPicker1);
            this.Name = "Form1";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPlusTag;
        internal System.Windows.Forms.Label lbl4;
        internal System.Windows.Forms.DateTimePicker datPicker4;
        internal System.Windows.Forms.Label lbl3;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.Label lbl1;
        internal System.Windows.Forms.DateTimePicker datPicker3;
        internal System.Windows.Forms.DateTimePicker datPicker2;
        internal System.Windows.Forms.Label lblDatum;
        internal System.Windows.Forms.DateTimePicker datPicker1;
    }
}

