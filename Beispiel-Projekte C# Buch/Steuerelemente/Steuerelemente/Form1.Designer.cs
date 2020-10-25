namespace Steuerelemente
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
            this.cmdFarbe = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.cmdGrößeAbs = new System.Windows.Forms.Button();
            this.cmdPositionAbs = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.cmdGrößeRel = new System.Windows.Forms.Button();
            this.cmdPositionRel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFarbe
            // 
            this.cmdFarbe.Location = new System.Drawing.Point(324, 120);
            this.cmdFarbe.Name = "cmdFarbe";
            this.cmdFarbe.Size = new System.Drawing.Size(75, 23);
            this.cmdFarbe.TabIndex = 39;
            this.cmdFarbe.Text = "Farbe";
            this.cmdFarbe.UseVisualStyleBackColor = true;
            this.cmdFarbe.Click += new System.EventHandler(this.cmdFarbe_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(321, 71);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 38;
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(324, 12);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige.TabIndex = 37;
            this.cmdAnzeige.Text = "Anzeige";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // cmdGrößeAbs
            // 
            this.cmdGrößeAbs.Location = new System.Drawing.Point(159, 66);
            this.cmdGrößeAbs.Name = "cmdGrößeAbs";
            this.cmdGrößeAbs.Size = new System.Drawing.Size(75, 23);
            this.cmdGrößeAbs.TabIndex = 36;
            this.cmdGrößeAbs.Text = "Größe Abs";
            this.cmdGrößeAbs.UseVisualStyleBackColor = true;
            this.cmdGrößeAbs.Click += new System.EventHandler(this.cmdGrößeAbs_Click);
            // 
            // cmdPositionAbs
            // 
            this.cmdPositionAbs.Location = new System.Drawing.Point(159, 12);
            this.cmdPositionAbs.Name = "cmdPositionAbs";
            this.cmdPositionAbs.Size = new System.Drawing.Size(75, 23);
            this.cmdPositionAbs.TabIndex = 35;
            this.cmdPositionAbs.Text = "Position Abs";
            this.cmdPositionAbs.UseVisualStyleBackColor = true;
            this.cmdPositionAbs.Click += new System.EventHandler(this.cmdPositionAbs_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(12, 120);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 34;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            // 
            // cmdGrößeRel
            // 
            this.cmdGrößeRel.Location = new System.Drawing.Point(12, 66);
            this.cmdGrößeRel.Name = "cmdGrößeRel";
            this.cmdGrößeRel.Size = new System.Drawing.Size(75, 23);
            this.cmdGrößeRel.TabIndex = 33;
            this.cmdGrößeRel.Text = "Größe Rel";
            this.cmdGrößeRel.UseVisualStyleBackColor = true;
            this.cmdGrößeRel.Click += new System.EventHandler(this.cmdGrößeRel_Click);
            // 
            // cmdPositionRel
            // 
            this.cmdPositionRel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPositionRel.Location = new System.Drawing.Point(12, 12);
            this.cmdPositionRel.Name = "cmdPositionRel";
            this.cmdPositionRel.Size = new System.Drawing.Size(75, 23);
            this.cmdPositionRel.TabIndex = 32;
            this.cmdPositionRel.Text = "Position Rel";
            this.cmdPositionRel.UseVisualStyleBackColor = false;
            this.cmdPositionRel.Click += new System.EventHandler(this.cmdPositionRel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.cmdFarbe);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.cmdGrößeAbs);
            this.Controls.Add(this.cmdPositionAbs);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.cmdGrößeRel);
            this.Controls.Add(this.cmdPositionRel);
            this.Name = "Form1";
            this.Text = "Position, Größe, Farbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdFarbe;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdAnzeige;
        internal System.Windows.Forms.Button cmdGrößeAbs;
        internal System.Windows.Forms.Button cmdPositionAbs;
        internal System.Windows.Forms.Button cmdTest;
        internal System.Windows.Forms.Button cmdGrößeRel;
        internal System.Windows.Forms.Button cmdPositionRel;
    }
}

