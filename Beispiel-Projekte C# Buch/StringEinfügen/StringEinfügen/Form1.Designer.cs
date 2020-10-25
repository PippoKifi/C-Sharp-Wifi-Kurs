namespace StringEinfügen
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
            this.lblEinfügen2 = new System.Windows.Forms.Label();
            this.numEinfügen = new System.Windows.Forms.NumericUpDown();
            this.lblEinfügen1 = new System.Windows.Forms.Label();
            this.txtEinfügen = new System.Windows.Forms.TextBox();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdEinfügen = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEinfügen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEinfügen2
            // 
            this.lblEinfügen2.AutoSize = true;
            this.lblEinfügen2.Location = new System.Drawing.Point(12, 155);
            this.lblEinfügen2.Name = "lblEinfügen2";
            this.lblEinfügen2.Size = new System.Drawing.Size(64, 13);
            this.lblEinfügen2.TabIndex = 51;
            this.lblEinfügen2.Text = "bei Position:";
            // 
            // numEinfügen
            // 
            this.numEinfügen.Location = new System.Drawing.Point(12, 171);
            this.numEinfügen.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numEinfügen.Name = "numEinfügen";
            this.numEinfügen.Size = new System.Drawing.Size(100, 20);
            this.numEinfügen.TabIndex = 50;
            // 
            // lblEinfügen1
            // 
            this.lblEinfügen1.AutoSize = true;
            this.lblEinfügen1.Location = new System.Drawing.Point(12, 116);
            this.lblEinfügen1.Name = "lblEinfügen1";
            this.lblEinfügen1.Size = new System.Drawing.Size(51, 13);
            this.lblEinfügen1.TabIndex = 49;
            this.lblEinfügen1.Text = "Füge ein:";
            // 
            // txtEinfügen
            // 
            this.txtEinfügen.Location = new System.Drawing.Point(12, 132);
            this.txtEinfügen.Name = "txtEinfügen";
            this.txtEinfügen.Size = new System.Drawing.Size(100, 20);
            this.txtEinfügen.TabIndex = 48;
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(12, 9);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(49, 13);
            this.lblEingabe.TabIndex = 47;
            this.lblEingabe.Text = "Eingabe:";
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 61);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 46;
            // 
            // cmdEinfügen
            // 
            this.cmdEinfügen.Location = new System.Drawing.Point(12, 197);
            this.cmdEinfügen.Name = "cmdEinfügen";
            this.cmdEinfügen.Size = new System.Drawing.Size(75, 23);
            this.cmdEinfügen.TabIndex = 45;
            this.cmdEinfügen.Text = "Einfügen";
            this.cmdEinfügen.UseVisualStyleBackColor = true;
            this.cmdEinfügen.Click += new System.EventHandler(this.cmdEinfügen_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 25);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(150, 20);
            this.txtEingabe.TabIndex = 44;
            this.txtEingabe.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEinfügen2);
            this.Controls.Add(this.numEinfügen);
            this.Controls.Add(this.lblEinfügen1);
            this.Controls.Add(this.txtEinfügen);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdEinfügen);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Einfügen";
            ((System.ComponentModel.ISupportInitialize)(this.numEinfügen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblEinfügen2;
        internal System.Windows.Forms.NumericUpDown numEinfügen;
        internal System.Windows.Forms.Label lblEinfügen1;
        internal System.Windows.Forms.TextBox txtEinfügen;
        internal System.Windows.Forms.Label lblEingabe;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdEinfügen;
        internal System.Windows.Forms.TextBox txtEingabe;
    }
}

