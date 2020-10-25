namespace DataGrid
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
            this.cmdInfoSpalte = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.cmdMittelwert = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdInfoSpalte
            // 
            this.cmdInfoSpalte.Location = new System.Drawing.Point(12, 171);
            this.cmdInfoSpalte.Name = "cmdInfoSpalte";
            this.cmdInfoSpalte.Size = new System.Drawing.Size(75, 23);
            this.cmdInfoSpalte.TabIndex = 11;
            this.cmdInfoSpalte.Text = "Info Spalte";
            this.cmdInfoSpalte.UseVisualStyleBackColor = true;
            this.cmdInfoSpalte.Click += new System.EventHandler(this.cmdInfoSpalte_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(133, 176);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 13);
            this.lblA.TabIndex = 10;
            // 
            // cmdMittelwert
            // 
            this.cmdMittelwert.Location = new System.Drawing.Point(12, 200);
            this.cmdMittelwert.Name = "cmdMittelwert";
            this.cmdMittelwert.Size = new System.Drawing.Size(75, 23);
            this.cmdMittelwert.TabIndex = 9;
            this.cmdMittelwert.Text = "Mittelwert";
            this.cmdMittelwert.UseVisualStyleBackColor = true;
            this.cmdMittelwert.Click += new System.EventHandler(this.cmdMittelwert_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(460, 150);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.cmdInfoSpalte);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmdMittelwert);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdInfoSpalte;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Button cmdMittelwert;
        internal System.Windows.Forms.DataGridView dgv;
    }
}

