namespace DatenfeldDynamisch
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
            this.numGröße = new System.Windows.Forms.NumericUpDown();
            this.cmdNeu2 = new System.Windows.Forms.Button();
            this.cmdOriginal = new System.Windows.Forms.Button();
            this.lstFeld = new System.Windows.Forms.ListBox();
            this.cmdNeu1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGröße)).BeginInit();
            this.SuspendLayout();
            // 
            // numGröße
            // 
            this.numGröße.Location = new System.Drawing.Point(197, 99);
            this.numGröße.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGröße.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGröße.Name = "numGröße";
            this.numGröße.Size = new System.Drawing.Size(75, 20);
            this.numGröße.TabIndex = 26;
            this.numGröße.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // cmdNeu2
            // 
            this.cmdNeu2.Location = new System.Drawing.Point(197, 125);
            this.cmdNeu2.Name = "cmdNeu2";
            this.cmdNeu2.Size = new System.Drawing.Size(75, 23);
            this.cmdNeu2.TabIndex = 25;
            this.cmdNeu2.Text = "Feld neu 2";
            this.cmdNeu2.UseVisualStyleBackColor = true;
            this.cmdNeu2.Click += new System.EventHandler(this.cmdNeu2_Click);
            // 
            // cmdOriginal
            // 
            this.cmdOriginal.Location = new System.Drawing.Point(197, 12);
            this.cmdOriginal.Name = "cmdOriginal";
            this.cmdOriginal.Size = new System.Drawing.Size(75, 23);
            this.cmdOriginal.TabIndex = 24;
            this.cmdOriginal.Text = "Feld original";
            this.cmdOriginal.UseVisualStyleBackColor = true;
            this.cmdOriginal.Click += new System.EventHandler(this.cmdOriginal_Click);
            // 
            // lstFeld
            // 
            this.lstFeld.FormattingEnabled = true;
            this.lstFeld.Location = new System.Drawing.Point(12, 12);
            this.lstFeld.Name = "lstFeld";
            this.lstFeld.Size = new System.Drawing.Size(109, 238);
            this.lstFeld.TabIndex = 23;
            // 
            // cmdNeu1
            // 
            this.cmdNeu1.Location = new System.Drawing.Point(197, 41);
            this.cmdNeu1.Name = "cmdNeu1";
            this.cmdNeu1.Size = new System.Drawing.Size(75, 23);
            this.cmdNeu1.TabIndex = 22;
            this.cmdNeu1.Text = "Feld neu 1";
            this.cmdNeu1.UseVisualStyleBackColor = true;
            this.cmdNeu1.Click += new System.EventHandler(this.cmdNeu1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numGröße);
            this.Controls.Add(this.cmdNeu2);
            this.Controls.Add(this.cmdOriginal);
            this.Controls.Add(this.lstFeld);
            this.Controls.Add(this.cmdNeu1);
            this.Name = "Form1";
            this.Text = "Datenfeld, dynamisch";
            ((System.ComponentModel.ISupportInitialize)(this.numGröße)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGröße;
        internal System.Windows.Forms.Button cmdNeu2;
        internal System.Windows.Forms.Button cmdOriginal;
        internal System.Windows.Forms.ListBox lstFeld;
        internal System.Windows.Forms.Button cmdNeu1;
    }
}

