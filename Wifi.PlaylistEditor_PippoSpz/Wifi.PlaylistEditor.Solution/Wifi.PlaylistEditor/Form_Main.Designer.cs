
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_NeuePlalistAnlegen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_DeletePlaylist = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SaveSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_FullDelete = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButton_MailForm_TopMost = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ListView_PlaylistOverwie = new System.Windows.Forms.ListView();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_DeleteSelectedPlaylistItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView_PlayListElements = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Duration = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Artist = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Titel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_ItemPath = new System.Windows.Forms.ToolStripLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip6.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_NeuePlalistAnlegen,
            this.toolStripSeparator2,
            this.toolStripButton_DeletePlaylist,
            this.toolStripButton_SaveSettings,
            this.toolStripSeparator7,
            this.toolStripButton_FullDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 34);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(42, 427);
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
            this.toolStripButton_NeuePlalistAnlegen.Click += new System.EventHandler(this.toolStripButton_NeuePlaylistAnlegen_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton_DeletePlaylist
            // 
            this.toolStripButton_DeletePlaylist.AutoSize = false;
            this.toolStripButton_DeletePlaylist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DeletePlaylist.Image = global::Wifi.PlaylistEditor.Properties.Resources.File_Delete;
            this.toolStripButton_DeletePlaylist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DeletePlaylist.Name = "toolStripButton_DeletePlaylist";
            this.toolStripButton_DeletePlaylist.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_DeletePlaylist.Text = "toolStripButton1";
            this.toolStripButton_DeletePlaylist.ToolTipText = "Icon Löschen";
            this.toolStripButton_DeletePlaylist.Click += new System.EventHandler(this.toolStripButton_DeletePlaylist_Click);
            // 
            // toolStripButton_SaveSettings
            // 
            this.toolStripButton_SaveSettings.AutoSize = false;
            this.toolStripButton_SaveSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_SaveSettings.Image = global::Wifi.PlaylistEditor.Properties.Resources.Save;
            this.toolStripButton_SaveSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SaveSettings.Name = "toolStripButton_SaveSettings";
            this.toolStripButton_SaveSettings.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_SaveSettings.Text = "toolStripButton1";
            this.toolStripButton_SaveSettings.ToolTipText = "Playlist Sichern ";
            this.toolStripButton_SaveSettings.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton_FullDelete
            // 
            this.toolStripButton_FullDelete.AutoSize = false;
            this.toolStripButton_FullDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_FullDelete.Image = global::Wifi.PlaylistEditor.Properties.Resources.GarbageCollector;
            this.toolStripButton_FullDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_FullDelete.Name = "toolStripButton_FullDelete";
            this.toolStripButton_FullDelete.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_FullDelete.ToolTipText = "Playlist leeren";
            this.toolStripButton_FullDelete.Click += new System.EventHandler(this.toolStripButton_FullDelete_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(582, 379);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(160, 32);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.toolStrip4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip4.Font = new System.Drawing.Font("Segoe Print", 16.25F, System.Drawing.FontStyle.Bold);
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.lbl_playlistTitel,
            this.toolStripButton_MailForm_TopMost,
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
            // toolStripButton_MailForm_TopMost
            // 
            this.toolStripButton_MailForm_TopMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_MailForm_TopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MailForm_TopMost.Image = global::Wifi.PlaylistEditor.Properties.Resources.pin2;
            this.toolStripButton_MailForm_TopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MailForm_TopMost.Name = "toolStripButton_MailForm_TopMost";
            this.toolStripButton_MailForm_TopMost.Size = new System.Drawing.Size(23, 31);
            this.toolStripButton_MailForm_TopMost.Text = "toolStripButton1";
            this.toolStripButton_MailForm_TopMost.Click += new System.EventHandler(this.toolStripButton_MailForm_TopMost_Click);
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
            // ListView_PlaylistOverwie
            // 
            this.ListView_PlaylistOverwie.AllowDrop = true;
            this.ListView_PlaylistOverwie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListView_PlaylistOverwie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListView_PlaylistOverwie.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.ListView_PlaylistOverwie.HideSelection = false;
            this.ListView_PlaylistOverwie.Location = new System.Drawing.Point(44, 63);
            this.ListView_PlaylistOverwie.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ListView_PlaylistOverwie.Name = "ListView_PlaylistOverwie";
            this.ListView_PlaylistOverwie.Size = new System.Drawing.Size(130, 349);
            this.ListView_PlaylistOverwie.TabIndex = 8;
            this.ListView_PlaylistOverwie.UseCompatibleStateImageBehavior = false;
            this.ListView_PlaylistOverwie.View = System.Windows.Forms.View.List;
            this.ListView_PlaylistOverwie.SelectedIndexChanged += new System.EventHandler(this.ListView_PlaylistOverwie_SelectedIndexChanged);
            // 
            // toolStrip5
            // 
            this.toolStrip5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip5.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripSeparator9,
            this.toolStripButton_DeleteSelectedPlaylistItem,
            this.toolStripSeparator10,
            this.toolStripButton10});
            this.toolStrip5.Location = new System.Drawing.Point(742, 63);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip5.Size = new System.Drawing.Size(42, 398);
            this.toolStrip5.TabIndex = 9;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Wifi.PlaylistEditor.Properties.Resources.Playlist_Add;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton8.Text = "toolStripButton1";
            this.toolStripButton8.ToolTipText = "Icon Hinzufügen";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton_DeleteSelectedPlaylistItem
            // 
            this.toolStripButton_DeleteSelectedPlaylistItem.AutoSize = false;
            this.toolStripButton_DeleteSelectedPlaylistItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DeleteSelectedPlaylistItem.Image = global::Wifi.PlaylistEditor.Properties.Resources.File_Delete;
            this.toolStripButton_DeleteSelectedPlaylistItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DeleteSelectedPlaylistItem.Name = "toolStripButton_DeleteSelectedPlaylistItem";
            this.toolStripButton_DeleteSelectedPlaylistItem.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_DeleteSelectedPlaylistItem.Text = "toolStripButton1";
            this.toolStripButton_DeleteSelectedPlaylistItem.ToolTipText = "Icon Löschen";
            this.toolStripButton_DeleteSelectedPlaylistItem.Click += new System.EventHandler(this.toolStripButton_DeleteSelectedPlaylistItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(37, 6);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = global::Wifi.PlaylistEditor.Properties.Resources.GarbageCollector;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton10.Text = "toolStripButton1";
            this.toolStripButton10.ToolTipText = "Playlist leeren";
            // 
            // ListView_PlayListElements
            // 
            this.ListView_PlayListElements.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_PlayListElements.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListView_PlayListElements.AllowDrop = true;
            this.ListView_PlayListElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_PlayListElements.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListView_PlayListElements.BackgroundImageTiled = true;
            this.ListView_PlayListElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_PlayListElements.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.ListView_PlayListElements.GridLines = true;
            this.ListView_PlayListElements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView_PlayListElements.HideSelection = false;
            this.ListView_PlayListElements.HoverSelection = true;
            this.ListView_PlayListElements.Location = new System.Drawing.Point(173, 63);
            this.ListView_PlayListElements.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ListView_PlayListElements.Name = "ListView_PlayListElements";
            this.ListView_PlayListElements.ShowItemToolTips = true;
            this.ListView_PlayListElements.Size = new System.Drawing.Size(569, 349);
            this.ListView_PlayListElements.TabIndex = 0;
            this.ListView_PlayListElements.UseCompatibleStateImageBehavior = false;
            this.ListView_PlayListElements.SelectedIndexChanged += new System.EventHandler(this.listView_PlayListElements_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Duration,
            this.toolStripLabel10,
            this.toolStripSeparator4,
            this.toolStripLabel_Artist,
            this.toolStripLabel11,
            this.toolStripSeparator6,
            this.toolStripLabel_Titel,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(42, 436);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_Duration
            // 
            this.toolStripLabel_Duration.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_Duration.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_Duration.Name = "toolStripLabel_Duration";
            this.toolStripLabel_Duration.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel_Duration.Text = "00:00:00";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel10.Text = "Dauer:";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Artist
            // 
            this.toolStripLabel_Artist.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_Artist.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_Artist.Name = "toolStripLabel_Artist";
            this.toolStripLabel_Artist.Size = new System.Drawing.Size(105, 22);
            this.toolStripLabel_Artist.Text = "Max Mustermann";
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel11.Text = "Artist:";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Titel
            // 
            this.toolStripLabel_Titel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_Titel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_Titel.Name = "toolStripLabel_Titel";
            this.toolStripLabel_Titel.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel_Titel.Text = "Cooler Song";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel4.Text = "Titel:";
            // 
            // toolStrip6
            // 
            this.toolStrip6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip6.Font = new System.Drawing.Font("Segoe Print", 6.25F, System.Drawing.FontStyle.Bold);
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_ItemPath});
            this.toolStrip6.Location = new System.Drawing.Point(42, 411);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip6.Size = new System.Drawing.Size(700, 25);
            this.toolStrip6.TabIndex = 11;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripLabel_ItemPath
            // 
            this.toolStripLabel_ItemPath.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_ItemPath.Font = new System.Drawing.Font("Segoe Print", 7.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel_ItemPath.Name = "toolStripLabel_ItemPath";
            this.toolStripLabel_ItemPath.Size = new System.Drawing.Size(187, 22);
            this.toolStripLabel_ItemPath.Text = "C:\\Temp\\MySongs\\CoolerSong.mp3";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // Form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toolStrip6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.ListView_PlaylistOverwie);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ListView_PlayListElements);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaylistEditor";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form_Main_DragOver);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_FullDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton_DeletePlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_SaveSettings;
        private System.Windows.Forms.ToolStripButton toolStripButton_NeuePlalistAnlegen;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel lbl_playlistTitel;
        private System.Windows.Forms.ToolStripLabel lbl_playlistSpielzeit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_PlaylistAutor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ListView ListView_PlaylistOverwie;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton_DeleteSelectedPlaylistItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView ListView_PlayListElements;
        private System.Windows.Forms.ToolStripButton toolStripButton_MailForm_TopMost;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Artist;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Titel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Duration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_ItemPath;
        private System.Windows.Forms.ImageList imageList1;
    }
}

