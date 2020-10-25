namespace WPFInForms
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
            this.ehost2 = new System.Windows.Forms.Integration.ElementHost();
            this.ehost1 = new System.Windows.Forms.Integration.ElementHost();
            this.WFO_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ehost2
            // 
            this.ehost2.Location = new System.Drawing.Point(11, 71);
            this.ehost2.Margin = new System.Windows.Forms.Padding(2);
            this.ehost2.Name = "ehost2";
            this.ehost2.Size = new System.Drawing.Size(160, 80);
            this.ehost2.TabIndex = 5;
            this.ehost2.Text = "elementHost2";
            this.ehost2.Child = null;
            // 
            // ehost1
            // 
            this.ehost1.Location = new System.Drawing.Point(11, 44);
            this.ehost1.Margin = new System.Windows.Forms.Padding(2);
            this.ehost1.Name = "ehost1";
            this.ehost1.Size = new System.Drawing.Size(160, 23);
            this.ehost1.TabIndex = 4;
            this.ehost1.Text = "elementHost1";
            this.ehost1.Child = null;
            // 
            // WFO_Button
            // 
            this.WFO_Button.Location = new System.Drawing.Point(11, 11);
            this.WFO_Button.Margin = new System.Windows.Forms.Padding(2);
            this.WFO_Button.Name = "WFO_Button";
            this.WFO_Button.Size = new System.Drawing.Size(160, 23);
            this.WFO_Button.TabIndex = 3;
            this.WFO_Button.Text = "Windows Forms Button";
            this.WFO_Button.UseVisualStyleBackColor = true;
            this.WFO_Button.Click += new System.EventHandler(this.WFO_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.ehost2);
            this.Controls.Add(this.ehost1);
            this.Controls.Add(this.WFO_Button);
            this.Name = "Form1";
            this.Text = "WPFInForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost ehost2;
        private System.Windows.Forms.Integration.ElementHost ehost1;
        private System.Windows.Forms.Button WFO_Button;

    }
}

