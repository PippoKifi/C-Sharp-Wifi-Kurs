namespace StringGrundlagen
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
            this.cmdSplitten = new System.Windows.Forms.Button();
            this.cmdTrimmen = new System.Windows.Forms.Button();
            this.cmdSucheAlle = new System.Windows.Forms.Button();
            this.cmdSucheEins = new System.Windows.Forms.Button();
            this.lblSuche = new System.Windows.Forms.Label();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.cmdZeichen = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdLänge = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdSplitten
            // 
            this.cmdSplitten.Location = new System.Drawing.Point(197, 99);
            this.cmdSplitten.Name = "cmdSplitten";
            this.cmdSplitten.Size = new System.Drawing.Size(75, 23);
            this.cmdSplitten.TabIndex = 47;
            this.cmdSplitten.Text = "Splitten";
            this.cmdSplitten.UseVisualStyleBackColor = true;
            this.cmdSplitten.Click += new System.EventHandler(this.cmdSplitten_Click);
            // 
            // cmdTrimmen
            // 
            this.cmdTrimmen.Location = new System.Drawing.Point(197, 70);
            this.cmdTrimmen.Name = "cmdTrimmen";
            this.cmdTrimmen.Size = new System.Drawing.Size(75, 23);
            this.cmdTrimmen.TabIndex = 46;
            this.cmdTrimmen.Text = "Trimmen";
            this.cmdTrimmen.UseVisualStyleBackColor = true;
            this.cmdTrimmen.Click += new System.EventHandler(this.cmdTrimmen_Click);
            // 
            // cmdSucheAlle
            // 
            this.cmdSucheAlle.Location = new System.Drawing.Point(197, 198);
            this.cmdSucheAlle.Name = "cmdSucheAlle";
            this.cmdSucheAlle.Size = new System.Drawing.Size(75, 23);
            this.cmdSucheAlle.TabIndex = 45;
            this.cmdSucheAlle.Text = "Suche alle";
            this.cmdSucheAlle.UseVisualStyleBackColor = true;
            this.cmdSucheAlle.Click += new System.EventHandler(this.cmdSucheAlle_Click);
            // 
            // cmdSucheEins
            // 
            this.cmdSucheEins.Location = new System.Drawing.Point(197, 169);
            this.cmdSucheEins.Name = "cmdSucheEins";
            this.cmdSucheEins.Size = new System.Drawing.Size(75, 23);
            this.cmdSucheEins.TabIndex = 44;
            this.cmdSucheEins.Text = "Suche eins";
            this.cmdSucheEins.UseVisualStyleBackColor = true;
            this.cmdSucheEins.Click += new System.EventHandler(this.cmdSucheEins_Click);
            // 
            // lblSuche
            // 
            this.lblSuche.AutoSize = true;
            this.lblSuche.Location = new System.Drawing.Point(127, 147);
            this.lblSuche.Name = "lblSuche";
            this.lblSuche.Size = new System.Drawing.Size(41, 13);
            this.lblSuche.TabIndex = 43;
            this.lblSuche.Text = "Suche:";
            // 
            // txtSuche
            // 
            this.txtSuche.Location = new System.Drawing.Point(172, 143);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(100, 20);
            this.txtSuche.TabIndex = 42;
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(9, 17);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(49, 13);
            this.lblEingabe.TabIndex = 41;
            this.lblEingabe.Text = "Eingabe:";
            // 
            // cmdZeichen
            // 
            this.cmdZeichen.Location = new System.Drawing.Point(197, 41);
            this.cmdZeichen.Name = "cmdZeichen";
            this.cmdZeichen.Size = new System.Drawing.Size(75, 23);
            this.cmdZeichen.TabIndex = 40;
            this.cmdZeichen.Text = "Zeichen";
            this.cmdZeichen.UseVisualStyleBackColor = true;
            this.cmdZeichen.Click += new System.EventHandler(this.cmdZeichen_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(9, 70);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 39;
            // 
            // cmdLänge
            // 
            this.cmdLänge.Location = new System.Drawing.Point(197, 12);
            this.cmdLänge.Name = "cmdLänge";
            this.cmdLänge.Size = new System.Drawing.Size(75, 23);
            this.cmdLänge.TabIndex = 38;
            this.cmdLänge.Text = "Länge";
            this.cmdLänge.UseVisualStyleBackColor = true;
            this.cmdLänge.Click += new System.EventHandler(this.cmdLänge_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(9, 33);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(150, 20);
            this.txtEingabe.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdSplitten);
            this.Controls.Add(this.cmdTrimmen);
            this.Controls.Add(this.cmdSucheAlle);
            this.Controls.Add(this.cmdSucheEins);
            this.Controls.Add(this.lblSuche);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.cmdZeichen);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdLänge);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Grundlagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdSplitten;
        internal System.Windows.Forms.Button cmdTrimmen;
        internal System.Windows.Forms.Button cmdSucheAlle;
        internal System.Windows.Forms.Button cmdSucheEins;
        internal System.Windows.Forms.Label lblSuche;
        internal System.Windows.Forms.TextBox txtSuche;
        internal System.Windows.Forms.Label lblEingabe;
        internal System.Windows.Forms.Button cmdZeichen;
        internal System.Windows.Forms.Label lblAnzeige;
        internal System.Windows.Forms.Button cmdLänge;
        internal System.Windows.Forms.TextBox txtEingabe;
    }
}

