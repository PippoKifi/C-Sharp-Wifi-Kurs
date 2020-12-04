
namespace Wifi.PlaylistEditor
{
    partial class Form_Main
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
            this.listView_PlayListElements = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_NeuePlalistAnlegen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_PlaylistTeilen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_PlaylistAutor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_playlistSpielzeit = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_playlistTitel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_PlaylistOverwie = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_PlayListElements
            // 
            this.listView_PlayListElements.AllowDrop = true;
            this.listView_PlayListElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_PlayListElements.BackColor = System.Drawing.SystemColors.Menu;
            this.listView_PlayListElements.HideSelection = false;
            this.listView_PlayListElements.Location = new System.Drawing.Point(173, 61);
            this.listView_PlayListElements.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.listView_PlayListElements.Name = "listView_PlayListElements";
            this.listView_PlayListElements.Size = new System.Drawing.Size(611, 375);
            this.listView_PlayListElements.TabIndex = 0;
            this.listView_PlayListElements.UseCompatibleStateImageBehavior = false;
            this.listView_PlayListElements.View = System.Windows.Forms.View.Details;
            this.listView_PlayListElements.SelectedIndexChanged += new System.EventHandler(this.listView_PlayListElements_SelectedIndexChanged);
            this.listView_PlayListElements.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.listView_PlayListElements_ControlAdded);
            this.listView_PlayListElements.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_PlayListElements_DragDrop);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe Print", 9.25F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.toolStripSeparator3,
            this.toolStripLabel5,
            this.toolStripSeparator6,
            this.toolStripLabel6,
            this.toolStripSeparator4,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 436);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(145, 22);
            this.toolStripLabel4.Text = "Artist: Max Mustermann";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(105, 22);
            this.toolStripLabel5.Text = "Titel: Cooler Song";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel6.Text = "Dauer: 00:05:25";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(206, 22);
            this.toolStripLabel2.Text = "C:\\Temp\\MySongs\\CoolerSong.mp3";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_NeuePlalistAnlegen,
            this.toolStripSeparator2,
            this.toolStripButton_PlaylistTeilen,
            this.toolStripButton3,
            this.toolStripSeparator7,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 34);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(42, 402);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_NeuePlalistAnlegen
            // 
            this.toolStripButton_NeuePlalistAnlegen.AutoSize = false;
            this.toolStripButton_NeuePlalistAnlegen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_NeuePlalistAnlegen.Image = global::Wifi.PlaylistEditor.Properties.Resources.Plalyst_Add;
            this.toolStripButton_NeuePlalistAnlegen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_NeuePlalistAnlegen.Name = "toolStripButton_NeuePlalistAnlegen";
            this.toolStripButton_NeuePlalistAnlegen.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_NeuePlalistAnlegen.ToolTipText = "Neue Playlist anlegen";
            this.toolStripButton_NeuePlalistAnlegen.Click += new System.EventHandler(this.toolStripButton_NeuePlalistAnlegen_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton_PlaylistTeilen
            // 
            this.toolStripButton_PlaylistTeilen.AutoSize = false;
            this.toolStripButton_PlaylistTeilen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PlaylistTeilen.Image = global::Wifi.PlaylistEditor.Properties.Resources.Load_PLaylist;
            this.toolStripButton_PlaylistTeilen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PlaylistTeilen.Name = "toolStripButton_PlaylistTeilen";
            this.toolStripButton_PlaylistTeilen.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_PlaylistTeilen.Text = "toolStripButton1";
            this.toolStripButton_PlaylistTeilen.ToolTipText = "Playlist laden";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Wifi.PlaylistEditor.Properties.Resources.Save;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton3.Text = "toolStripButton1";
            this.toolStripButton3.ToolTipText = "Playlist Sichern ";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Wifi.PlaylistEditor.Properties.Resources.Playlist_Add;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton4.Text = "toolStripButton1";
            this.toolStripButton4.ToolTipText = "Icon Hinzufügen";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Wifi.PlaylistEditor.Properties.Resources.File_Delete;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton5.Text = "toolStripButton1";
            this.toolStripButton5.ToolTipText = "Icon Löschen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Wifi.PlaylistEditor.Properties.Resources.GarbageCollector;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton6.Text = "toolStripButton1";
            this.toolStripButton6.ToolTipText = "Playlist leeren";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(622, 402);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(160, 32);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.toolStripLabel_PlaylistAutor,
            this.toolStripSeparator5,
            this.toolStripLabel9,
            this.lbl_playlistSpielzeit});
            this.toolStrip3.Location = new System.Drawing.Point(42, 34);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip3.Size = new System.Drawing.Size(742, 29);
            this.toolStrip3.TabIndex = 6;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(60, 26);
            this.toolStripLabel7.Text = "Autor:";
            // 
            // toolStripLabel_PlaylistAutor
            // 
            this.toolStripLabel_PlaylistAutor.Name = "toolStripLabel_PlaylistAutor";
            this.toolStripLabel_PlaylistAutor.Size = new System.Drawing.Size(186, 26);
            this.toolStripLabel_PlaylistAutor.Text = "Autor: Max Mustermann";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(145, 26);
            this.toolStripLabel9.Text = "Playlist Spielzeit: ";
            // 
            // lbl_playlistSpielzeit
            // 
            this.lbl_playlistSpielzeit.Name = "lbl_playlistSpielzeit";
            this.lbl_playlistSpielzeit.Size = new System.Drawing.Size(78, 26);
            this.lbl_playlistSpielzeit.Text = "00:00:00";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Font = new System.Drawing.Font("Segoe Print", 16.25F, System.Drawing.FontStyle.Bold);
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.lbl_playlistTitel,
            this.toolStripLabel3,
            this.toolStripLabel1});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip4.Size = new System.Drawing.Size(784, 34);
            this.toolStrip4.TabIndex = 7;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Arial Unicode MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(93, 31);
            this.toolStripLabel8.Text = "Playlist:";
            // 
            // lbl_playlistTitel
            // 
            this.lbl_playlistTitel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playlistTitel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_playlistTitel.Name = "lbl_playlistTitel";
            this.lbl_playlistTitel.Size = new System.Drawing.Size(298, 31);
            this.lbl_playlistTitel.Text = "Demoplaylist Charts 1980";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(85, 31);
            this.toolStripLabel3.Text = "@Philipp Kifner";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 31);
            this.toolStripLabel1.Text = "Version 1.0";
            // 
            // toolStripButton_PlaylistOverwie
            // 
            this.toolStripButton_PlaylistOverwie.AllowDrop = true;
            this.toolStripButton_PlaylistOverwie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStripButton_PlaylistOverwie.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripButton_PlaylistOverwie.HideSelection = false;
            this.toolStripButton_PlaylistOverwie.Location = new System.Drawing.Point(44, 61);
            this.toolStripButton_PlaylistOverwie.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.toolStripButton_PlaylistOverwie.Name = "toolStripButton_PlaylistOverwie";
            this.toolStripButton_PlaylistOverwie.Size = new System.Drawing.Size(130, 375);
            this.toolStripButton_PlaylistOverwie.TabIndex = 8;
            this.toolStripButton_PlaylistOverwie.UseCompatibleStateImageBehavior = false;
            this.toolStripButton_PlaylistOverwie.View = System.Windows.Forms.View.Details;
            // 
            // Form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toolStripButton_PlaylistOverwie);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listView_PlayListElements);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_Main";
            this.Text = "PlaylistEditor";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragOver);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_PlayListElements;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_PlaylistTeilen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton_NeuePlalistAnlegen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel lbl_playlistTitel;
        private System.Windows.Forms.ToolStripLabel lbl_playlistSpielzeit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_PlaylistAutor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ListView toolStripButton_PlaylistOverwie;
    }
}

