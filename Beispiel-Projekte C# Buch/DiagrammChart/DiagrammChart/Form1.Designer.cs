namespace DiagrammChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdDrucken = new System.Windows.Forms.Button();
            this.dChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Location = new System.Drawing.Point(398, 38);
            this.cmdSpeichern.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(75, 23);
            this.cmdSpeichern.TabIndex = 6;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // cmdDrucken
            // 
            this.cmdDrucken.Location = new System.Drawing.Point(398, 11);
            this.cmdDrucken.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDrucken.Name = "cmdDrucken";
            this.cmdDrucken.Size = new System.Drawing.Size(75, 23);
            this.cmdDrucken.TabIndex = 5;
            this.cmdDrucken.Text = "Drucken";
            this.cmdDrucken.UseVisualStyleBackColor = true;
            this.cmdDrucken.Click += new System.EventHandler(this.cmdDrucken_Click);
            // 
            // dChart
            // 
            chartArea3.Name = "ChartArea1";
            this.dChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.dChart.Legends.Add(legend3);
            this.dChart.Location = new System.Drawing.Point(11, 11);
            this.dChart.Margin = new System.Windows.Forms.Padding(2);
            this.dChart.Name = "dChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.dChart.Series.Add(series3);
            this.dChart.Size = new System.Drawing.Size(338, 244);
            this.dChart.TabIndex = 7;
            this.dChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.dChart);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdDrucken);
            this.Name = "Form1";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdSpeichern;
        internal System.Windows.Forms.Button cmdDrucken;
        private System.Windows.Forms.DataVisualization.Charting.Chart dChart;
    }
}

