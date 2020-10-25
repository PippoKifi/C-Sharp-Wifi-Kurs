namespace MehrereFormulare
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUnter = new System.Windows.Forms.TextBox();
            this.chkUnter = new System.Windows.Forms.CheckBox();
            this.cmdEndeUnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnter
            // 
            this.txtUnter.Location = new System.Drawing.Point(12, 40);
            this.txtUnter.Name = "txtUnter";
            this.txtUnter.Size = new System.Drawing.Size(100, 20);
            this.txtUnter.TabIndex = 10;
            // 
            // chkUnter
            // 
            this.chkUnter.AutoSize = true;
            this.chkUnter.Location = new System.Drawing.Point(12, 66);
            this.chkUnter.Name = "chkUnter";
            this.chkUnter.Size = new System.Drawing.Size(141, 17);
            this.chkUnter.TabIndex = 9;
            this.chkUnter.Text = "CheckBox Unterformular";
            this.chkUnter.UseVisualStyleBackColor = true;
            // 
            // cmdEndeUnter
            // 
            this.cmdEndeUnter.Location = new System.Drawing.Point(12, 89);
            this.cmdEndeUnter.Name = "cmdEndeUnter";
            this.cmdEndeUnter.Size = new System.Drawing.Size(150, 23);
            this.cmdEndeUnter.TabIndex = 8;
            this.cmdEndeUnter.Text = "Ende Unterformular";
            this.cmdEndeUnter.UseVisualStyleBackColor = true;
            this.cmdEndeUnter.Click += new System.EventHandler(this.cmdEndeUnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.txtUnter);
            this.Controls.Add(this.chkUnter);
            this.Controls.Add(this.cmdEndeUnter);
            this.Name = "Form2";
            this.Text = "Unterformular";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnter;
        private System.Windows.Forms.CheckBox chkUnter;
        private System.Windows.Forms.Button cmdEndeUnter;
    }
}