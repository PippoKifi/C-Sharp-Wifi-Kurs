
namespace Wifi.PlaylistEditor
{
    partial class Form_Question_DummyForCloning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Question_DummyForCloning));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_FinishToAnwer__ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fragen an den EndUser";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button_FinishToAnwer__
            // 
            this.button_FinishToAnwer__.Location = new System.Drawing.Point(6, 49);
            this.button_FinishToAnwer__.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_FinishToAnwer__.Name = "button_FinishToAnwer__";
            this.button_FinishToAnwer__.Size = new System.Drawing.Size(75, 31);
            this.button_FinishToAnwer__.TabIndex = 2;
            this.button_FinishToAnwer__.Text = "Fertig";
            this.button_FinishToAnwer__.UseVisualStyleBackColor = true;
            // 
            // Form_Question_DummyForCloning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 81);
            this.Controls.Add(this.button_FinishToAnwer__);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Question_DummyForCloning";
            this.Text = "Form_Question_DummyForCloning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_FinishToAnwer__;
    }
}