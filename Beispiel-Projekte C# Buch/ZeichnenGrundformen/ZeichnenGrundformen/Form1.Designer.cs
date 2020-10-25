namespace ZeichnenGrundformen
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
            this.chkFüllen = new System.Windows.Forms.CheckBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdLinie = new System.Windows.Forms.Button();
            this.cmdEllipse = new System.Windows.Forms.Button();
            this.lstFarbe = new System.Windows.Forms.ListBox();
            this.lblFarbe = new System.Windows.Forms.Label();
            this.lblDicke = new System.Windows.Forms.Label();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.cmdPolygon = new System.Windows.Forms.Button();
            this.cmdRechteck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // chkFüllen
            // 
            this.chkFüllen.AutoSize = true;
            this.chkFüllen.Location = new System.Drawing.Point(14, 235);
            this.chkFüllen.Name = "chkFüllen";
            this.chkFüllen.Size = new System.Drawing.Size(54, 17);
            this.chkFüllen.TabIndex = 49;
            this.chkFüllen.Text = "Füllen";
            this.chkFüllen.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(207, 231);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 48;
            this.cmdClear.Text = "Löschen";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdLinie
            // 
            this.cmdLinie.Location = new System.Drawing.Point(207, 12);
            this.cmdLinie.Name = "cmdLinie";
            this.cmdLinie.Size = new System.Drawing.Size(75, 23);
            this.cmdLinie.TabIndex = 47;
            this.cmdLinie.Text = "Linie";
            this.cmdLinie.UseVisualStyleBackColor = true;
            this.cmdLinie.Click += new System.EventHandler(this.cmdLinie_Click);
            // 
            // cmdEllipse
            // 
            this.cmdEllipse.Location = new System.Drawing.Point(207, 99);
            this.cmdEllipse.Name = "cmdEllipse";
            this.cmdEllipse.Size = new System.Drawing.Size(75, 23);
            this.cmdEllipse.TabIndex = 46;
            this.cmdEllipse.Text = "Ellipse";
            this.cmdEllipse.UseVisualStyleBackColor = true;
            this.cmdEllipse.Click += new System.EventHandler(this.cmdEllipse_Click);
            // 
            // lstFarbe
            // 
            this.lstFarbe.FormattingEnabled = true;
            this.lstFarbe.Location = new System.Drawing.Point(207, 180);
            this.lstFarbe.Name = "lstFarbe";
            this.lstFarbe.Size = new System.Drawing.Size(75, 43);
            this.lstFarbe.TabIndex = 45;
            this.lstFarbe.SelectedIndexChanged += new System.EventHandler(this.lstFarbe_SelectedIndexChanged);
            // 
            // lblFarbe
            // 
            this.lblFarbe.AutoSize = true;
            this.lblFarbe.Location = new System.Drawing.Point(207, 164);
            this.lblFarbe.Name = "lblFarbe";
            this.lblFarbe.Size = new System.Drawing.Size(37, 13);
            this.lblFarbe.TabIndex = 44;
            this.lblFarbe.Text = "Farbe:";
            // 
            // lblDicke
            // 
            this.lblDicke.AutoSize = true;
            this.lblDicke.Location = new System.Drawing.Point(206, 125);
            this.lblDicke.Name = "lblDicke";
            this.lblDicke.Size = new System.Drawing.Size(38, 13);
            this.lblDicke.TabIndex = 43;
            this.lblDicke.Text = "Dicke:";
            // 
            // numPenWidth
            // 
            this.numPenWidth.Location = new System.Drawing.Point(207, 141);
            this.numPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(75, 20);
            this.numPenWidth.TabIndex = 42;
            this.numPenWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPenWidth.ValueChanged += new System.EventHandler(this.numPenWidth_ValueChanged);
            // 
            // cmdPolygon
            // 
            this.cmdPolygon.Location = new System.Drawing.Point(207, 70);
            this.cmdPolygon.Name = "cmdPolygon";
            this.cmdPolygon.Size = new System.Drawing.Size(75, 23);
            this.cmdPolygon.TabIndex = 41;
            this.cmdPolygon.Text = "Polygon";
            this.cmdPolygon.UseVisualStyleBackColor = true;
            this.cmdPolygon.Click += new System.EventHandler(this.cmdPolygon_Click);
            // 
            // cmdRechteck
            // 
            this.cmdRechteck.Location = new System.Drawing.Point(207, 41);
            this.cmdRechteck.Name = "cmdRechteck";
            this.cmdRechteck.Size = new System.Drawing.Size(75, 23);
            this.cmdRechteck.TabIndex = 40;
            this.cmdRechteck.Text = "Rechteck";
            this.cmdRechteck.UseVisualStyleBackColor = true;
            this.cmdRechteck.Click += new System.EventHandler(this.cmdRechteck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.chkFüllen);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdLinie);
            this.Controls.Add(this.cmdEllipse);
            this.Controls.Add(this.lstFarbe);
            this.Controls.Add(this.lblFarbe);
            this.Controls.Add(this.lblDicke);
            this.Controls.Add(this.numPenWidth);
            this.Controls.Add(this.cmdPolygon);
            this.Controls.Add(this.cmdRechteck);
            this.Name = "Form1";
            this.Text = "Zeichnen, Grundformen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkFüllen;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Button cmdLinie;
        internal System.Windows.Forms.Button cmdEllipse;
        internal System.Windows.Forms.ListBox lstFarbe;
        internal System.Windows.Forms.Label lblFarbe;
        internal System.Windows.Forms.Label lblDicke;
        internal System.Windows.Forms.NumericUpDown numPenWidth;
        internal System.Windows.Forms.Button cmdPolygon;
        internal System.Windows.Forms.Button cmdRechteck;
    }
}

