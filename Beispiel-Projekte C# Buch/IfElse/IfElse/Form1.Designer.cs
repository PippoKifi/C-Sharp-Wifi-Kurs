namespace IfElse
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
            this.cmdAnzeige6 = new System.Windows.Forms.Button();
            this.cmdAnzeige5 = new System.Windows.Forms.Button();
            this.cmdAnzeige4 = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.cmdAnzeige3 = new System.Windows.Forms.Button();
            this.cmdAnzeige2 = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdAnzeige1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAnzeige6
            // 
            this.cmdAnzeige6.Location = new System.Drawing.Point(12, 197);
            this.cmdAnzeige6.Name = "cmdAnzeige6";
            this.cmdAnzeige6.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige6.TabIndex = 25;
            this.cmdAnzeige6.Text = "log. exkl. Oder";
            this.cmdAnzeige6.UseVisualStyleBackColor = true;
            this.cmdAnzeige6.Click += new System.EventHandler(this.cmdAnzeige6_Click);
            // 
            // cmdAnzeige5
            // 
            this.cmdAnzeige5.Location = new System.Drawing.Point(12, 168);
            this.cmdAnzeige5.Name = "cmdAnzeige5";
            this.cmdAnzeige5.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige5.TabIndex = 24;
            this.cmdAnzeige5.Text = "log. Oder";
            this.cmdAnzeige5.UseVisualStyleBackColor = true;
            this.cmdAnzeige5.Click += new System.EventHandler(this.cmdAnzeige5_Click);
            // 
            // cmdAnzeige4
            // 
            this.cmdAnzeige4.Location = new System.Drawing.Point(12, 139);
            this.cmdAnzeige4.Name = "cmdAnzeige4";
            this.cmdAnzeige4.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige4.TabIndex = 23;
            this.cmdAnzeige4.Text = "log. Und";
            this.cmdAnzeige4.UseVisualStyleBackColor = true;
            this.cmdAnzeige4.Click += new System.EventHandler(this.cmdAnzeige4_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(156, 83);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 13);
            this.lblY.TabIndex = 22;
            this.lblY.Text = "y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(156, 57);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "x:";
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(197, 81);
            this.numY.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(75, 20);
            this.numY.TabIndex = 20;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(197, 55);
            this.numX.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(75, 20);
            this.numX.TabIndex = 19;
            // 
            // cmdAnzeige3
            // 
            this.cmdAnzeige3.Location = new System.Drawing.Point(12, 110);
            this.cmdAnzeige3.Name = "cmdAnzeige3";
            this.cmdAnzeige3.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige3.TabIndex = 18;
            this.cmdAnzeige3.Text = "if else if";
            this.cmdAnzeige3.UseVisualStyleBackColor = true;
            this.cmdAnzeige3.Click += new System.EventHandler(this.cmdAnzeige3_Click);
            // 
            // cmdAnzeige2
            // 
            this.cmdAnzeige2.Location = new System.Drawing.Point(12, 81);
            this.cmdAnzeige2.Name = "cmdAnzeige2";
            this.cmdAnzeige2.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige2.TabIndex = 17;
            this.cmdAnzeige2.Text = "if else";
            this.cmdAnzeige2.UseVisualStyleBackColor = true;
            this.cmdAnzeige2.Click += new System.EventHandler(this.cmdAnzeige2_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(23, 21);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 16;
            // 
            // cmdAnzeige1
            // 
            this.cmdAnzeige1.Location = new System.Drawing.Point(12, 52);
            this.cmdAnzeige1.Name = "cmdAnzeige1";
            this.cmdAnzeige1.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige1.TabIndex = 15;
            this.cmdAnzeige1.Text = "if";
            this.cmdAnzeige1.UseVisualStyleBackColor = true;
            this.cmdAnzeige1.Click += new System.EventHandler(this.cmdAnzeige1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdAnzeige6);
            this.Controls.Add(this.cmdAnzeige5);
            this.Controls.Add(this.cmdAnzeige4);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.cmdAnzeige3);
            this.Controls.Add(this.cmdAnzeige2);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeige1);
            this.Name = "Form1";
            this.Text = "if else";
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAnzeige6;
        internal System.Windows.Forms.Button cmdAnzeige5;
        internal System.Windows.Forms.Button cmdAnzeige4;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        internal System.Windows.Forms.Button cmdAnzeige3;
        internal System.Windows.Forms.Button cmdAnzeige2;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdAnzeige1;
    }
}

