namespace Listenansicht
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
            this.optTile = new System.Windows.Forms.RadioButton();
            this.optSmallIcon = new System.Windows.Forms.RadioButton();
            this.optList = new System.Windows.Forms.RadioButton();
            this.optLargeIcon = new System.Windows.Forms.RadioButton();
            this.optDetails = new System.Windows.Forms.RadioButton();
            this.lView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // optTile
            // 
            this.optTile.AutoSize = true;
            this.optTile.Location = new System.Drawing.Point(340, 99);
            this.optTile.Margin = new System.Windows.Forms.Padding(2);
            this.optTile.Name = "optTile";
            this.optTile.Size = new System.Drawing.Size(42, 17);
            this.optTile.TabIndex = 17;
            this.optTile.Text = "Tile";
            this.optTile.UseVisualStyleBackColor = true;
            this.optTile.CheckedChanged += new System.EventHandler(this.optView_CheckedChanged);
            // 
            // optSmallIcon
            // 
            this.optSmallIcon.AutoSize = true;
            this.optSmallIcon.Location = new System.Drawing.Point(340, 77);
            this.optSmallIcon.Margin = new System.Windows.Forms.Padding(2);
            this.optSmallIcon.Name = "optSmallIcon";
            this.optSmallIcon.Size = new System.Drawing.Size(71, 17);
            this.optSmallIcon.TabIndex = 16;
            this.optSmallIcon.Text = "SmallIcon";
            this.optSmallIcon.UseVisualStyleBackColor = true;
            this.optSmallIcon.CheckedChanged += new System.EventHandler(this.optView_CheckedChanged);
            // 
            // optList
            // 
            this.optList.AutoSize = true;
            this.optList.Location = new System.Drawing.Point(340, 55);
            this.optList.Margin = new System.Windows.Forms.Padding(2);
            this.optList.Name = "optList";
            this.optList.Size = new System.Drawing.Size(41, 17);
            this.optList.TabIndex = 15;
            this.optList.Text = "List";
            this.optList.UseVisualStyleBackColor = true;
            this.optList.CheckedChanged += new System.EventHandler(this.optView_CheckedChanged);
            // 
            // optLargeIcon
            // 
            this.optLargeIcon.AutoSize = true;
            this.optLargeIcon.Location = new System.Drawing.Point(340, 33);
            this.optLargeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.optLargeIcon.Name = "optLargeIcon";
            this.optLargeIcon.Size = new System.Drawing.Size(73, 17);
            this.optLargeIcon.TabIndex = 14;
            this.optLargeIcon.Text = "LargeIcon";
            this.optLargeIcon.UseVisualStyleBackColor = true;
            this.optLargeIcon.CheckedChanged += new System.EventHandler(this.optView_CheckedChanged);
            // 
            // optDetails
            // 
            this.optDetails.AutoSize = true;
            this.optDetails.Checked = true;
            this.optDetails.Location = new System.Drawing.Point(340, 11);
            this.optDetails.Margin = new System.Windows.Forms.Padding(2);
            this.optDetails.Name = "optDetails";
            this.optDetails.Size = new System.Drawing.Size(57, 17);
            this.optDetails.TabIndex = 13;
            this.optDetails.TabStop = true;
            this.optDetails.Text = "Details";
            this.optDetails.UseVisualStyleBackColor = true;
            this.optDetails.CheckedChanged += new System.EventHandler(this.optView_CheckedChanged);
            // 
            // lView
            // 
            this.lView.Location = new System.Drawing.Point(11, 11);
            this.lView.Margin = new System.Windows.Forms.Padding(2);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(307, 123);
            this.lView.TabIndex = 12;
            this.lView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 161);
            this.Controls.Add(this.optTile);
            this.Controls.Add(this.optSmallIcon);
            this.Controls.Add(this.optList);
            this.Controls.Add(this.optLargeIcon);
            this.Controls.Add(this.optDetails);
            this.Controls.Add(this.lView);
            this.Name = "Form1";
            this.Text = "Listenansicht";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton optTile;
        internal System.Windows.Forms.RadioButton optSmallIcon;
        internal System.Windows.Forms.RadioButton optList;
        internal System.Windows.Forms.RadioButton optLargeIcon;
        internal System.Windows.Forms.RadioButton optDetails;
        internal System.Windows.Forms.ListView lView;
    }
}

