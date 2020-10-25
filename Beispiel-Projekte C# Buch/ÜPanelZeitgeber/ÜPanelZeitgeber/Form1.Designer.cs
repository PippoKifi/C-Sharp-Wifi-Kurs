namespace ÜPanelZeitgeber
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
            this.components = new System.ComponentModel.Container();
            this.cmdStart = new System.Windows.Forms.Button();
            this.pan4 = new System.Windows.Forms.Panel();
            this.tim1 = new System.Windows.Forms.Timer(this.components);
            this.pan3 = new System.Windows.Forms.Panel();
            this.pan2 = new System.Windows.Forms.Panel();
            this.pan1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(95, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 13;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // pan4
            // 
            this.pan4.BackColor = System.Drawing.Color.Green;
            this.pan4.Location = new System.Drawing.Point(134, 125);
            this.pan4.Name = "pan4";
            this.pan4.Size = new System.Drawing.Size(20, 20);
            this.pan4.TabIndex = 15;
            // 
            // tim1
            // 
            this.tim1.Interval = 300;
            this.tim1.Tick += new System.EventHandler(this.tim1_Tick);
            // 
            // pan3
            // 
            this.pan3.BackColor = System.Drawing.Color.Yellow;
            this.pan3.Location = new System.Drawing.Point(108, 125);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(20, 20);
            this.pan3.TabIndex = 14;
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.Blue;
            this.pan2.Location = new System.Drawing.Point(134, 99);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(20, 20);
            this.pan2.TabIndex = 16;
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.Red;
            this.pan1.Location = new System.Drawing.Point(108, 99);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(20, 20);
            this.pan1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.pan4);
            this.Controls.Add(this.pan3);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Name = "Form1";
            this.Text = "Zeitgeber";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdStart;
        internal System.Windows.Forms.Panel pan4;
        internal System.Windows.Forms.Timer tim1;
        internal System.Windows.Forms.Panel pan3;
        internal System.Windows.Forms.Panel pan2;
        internal System.Windows.Forms.Panel pan1;
    }
}

