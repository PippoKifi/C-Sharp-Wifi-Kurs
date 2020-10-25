namespace Zahlenauswahlfeld
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
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.numEingabe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEingabe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(158, 14);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAusgabe.TabIndex = 7;
            // 
            // numEingabe
            // 
            this.numEingabe.DecimalPlaces = 1;
            this.numEingabe.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEingabe.Location = new System.Drawing.Point(12, 12);
            this.numEingabe.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numEingabe.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numEingabe.Name = "numEingabe";
            this.numEingabe.Size = new System.Drawing.Size(120, 20);
            this.numEingabe.TabIndex = 6;
            this.numEingabe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEingabe.ValueChanged += new System.EventHandler(this.numEingabe_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.numEingabe);
            this.Name = "Form1";
            this.Text = "Zahlenauswahlfeld";
            ((System.ComponentModel.ISupportInitialize)(this.numEingabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAusgabe;
        internal System.Windows.Forms.NumericUpDown numEingabe;
    }
}

