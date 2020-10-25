namespace ZeichnenText
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
            this.lstSchriftart = new System.Windows.Forms.ListBox();
            this.lblSchriftart = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.cmdAnzeigen = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lstFarbe = new System.Windows.Forms.ListBox();
            this.lblFarbe = new System.Windows.Forms.Label();
            this.lblSchriftgröße = new System.Windows.Forms.Label();
            this.numSchriftgröße = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSchriftgröße)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSchriftart
            // 
            this.lstSchriftart.FormattingEnabled = true;
            this.lstSchriftart.Location = new System.Drawing.Point(207, 55);
            this.lstSchriftart.Name = "lstSchriftart";
            this.lstSchriftart.Size = new System.Drawing.Size(75, 56);
            this.lstSchriftart.TabIndex = 49;
            this.lstSchriftart.SelectedIndexChanged += new System.EventHandler(this.lstSchriftart_SelectedIndexChanged);
            // 
            // lblSchriftart
            // 
            this.lblSchriftart.AutoSize = true;
            this.lblSchriftart.Location = new System.Drawing.Point(205, 39);
            this.lblSchriftart.Name = "lblSchriftart";
            this.lblSchriftart.Size = new System.Drawing.Size(52, 13);
            this.lblSchriftart.TabIndex = 48;
            this.lblSchriftart.Text = "Schriftart:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(14, 234);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(174, 20);
            this.txtE.TabIndex = 47;
            // 
            // cmdAnzeigen
            // 
            this.cmdAnzeigen.Location = new System.Drawing.Point(207, 12);
            this.cmdAnzeigen.Name = "cmdAnzeigen";
            this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen.TabIndex = 46;
            this.cmdAnzeigen.Text = "Anzeigen";
            this.cmdAnzeigen.UseVisualStyleBackColor = true;
            this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(207, 231);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 45;
            this.cmdClear.Text = "Löschen";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lstFarbe
            // 
            this.lstFarbe.FormattingEnabled = true;
            this.lstFarbe.Location = new System.Drawing.Point(207, 169);
            this.lstFarbe.Name = "lstFarbe";
            this.lstFarbe.Size = new System.Drawing.Size(75, 56);
            this.lstFarbe.TabIndex = 44;
            this.lstFarbe.SelectedIndexChanged += new System.EventHandler(this.lstFarbe_SelectedIndexChanged);
            // 
            // lblFarbe
            // 
            this.lblFarbe.AutoSize = true;
            this.lblFarbe.Location = new System.Drawing.Point(205, 153);
            this.lblFarbe.Name = "lblFarbe";
            this.lblFarbe.Size = new System.Drawing.Size(37, 13);
            this.lblFarbe.TabIndex = 43;
            this.lblFarbe.Text = "Farbe:";
            // 
            // lblSchriftgröße
            // 
            this.lblSchriftgröße.AutoSize = true;
            this.lblSchriftgröße.Location = new System.Drawing.Point(204, 114);
            this.lblSchriftgröße.Name = "lblSchriftgröße";
            this.lblSchriftgröße.Size = new System.Drawing.Size(67, 13);
            this.lblSchriftgröße.TabIndex = 42;
            this.lblSchriftgröße.Text = "Schriftgröße:";
            // 
            // numSchriftgröße
            // 
            this.numSchriftgröße.Location = new System.Drawing.Point(207, 130);
            this.numSchriftgröße.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numSchriftgröße.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numSchriftgröße.Name = "numSchriftgröße";
            this.numSchriftgröße.Size = new System.Drawing.Size(75, 20);
            this.numSchriftgröße.TabIndex = 41;
            this.numSchriftgröße.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numSchriftgröße.ValueChanged += new System.EventHandler(this.numSchriftgröße_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.lstSchriftart);
            this.Controls.Add(this.lblSchriftart);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.cmdAnzeigen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.lstFarbe);
            this.Controls.Add(this.lblFarbe);
            this.Controls.Add(this.lblSchriftgröße);
            this.Controls.Add(this.numSchriftgröße);
            this.Name = "Form1";
            this.Text = "Zeichnen, Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSchriftgröße)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstSchriftart;
        internal System.Windows.Forms.Label lblSchriftart;
        internal System.Windows.Forms.TextBox txtE;
        internal System.Windows.Forms.Button cmdAnzeigen;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.ListBox lstFarbe;
        internal System.Windows.Forms.Label lblFarbe;
        internal System.Windows.Forms.Label lblSchriftgröße;
        internal System.Windows.Forms.NumericUpDown numSchriftgröße;
    }
}

