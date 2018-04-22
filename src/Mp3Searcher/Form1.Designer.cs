namespace Mp3Searcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkFullScan = new System.Windows.Forms.LinkLabel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lnkOptions = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripSplitButton();
            this.searchTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idMp3FileLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMp3FileLinkByTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nSearcherDataSet = new Mp3Searcher.NSearcherDataSet();
            this.getMp3FileLinkByTitleTableAdapter = new Mp3Searcher.NSearcherDataSetTableAdapters.GetMp3FileLinkByTitleTableAdapter();
            this.cmbSearchText = new System.Windows.Forms.ComboBox();
            this.notifyMenu.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.dataGridMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMp3FileLinkByTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSearcherDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Preserved Head";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(105, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(101, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lnkFullScan
            // 
            this.lnkFullScan.AutoSize = true;
            this.lnkFullScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkFullScan.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFullScan.Location = new System.Drawing.Point(326, 45);
            this.lnkFullScan.Name = "lnkFullScan";
            this.lnkFullScan.Size = new System.Drawing.Size(39, 12);
            this.lnkFullScan.TabIndex = 2;
            this.lnkFullScan.TabStop = true;
            this.lnkFullScan.Text = "Full Scan";
            this.lnkFullScan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOptions_LinkClicked);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cmbSearchText);
            this.pnlSearch.Controls.Add(this.toolStrip);
            this.pnlSearch.Controls.Add(this.lnkOptions);
            this.pnlSearch.Controls.Add(this.lnkFullScan);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(372, 67);
            this.pnlSearch.TabIndex = 4;
            // 
            // lnkOptions
            // 
            this.lnkOptions.AutoSize = true;
            this.lnkOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkOptions.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOptions.Location = new System.Drawing.Point(281, 45);
            this.lnkOptions.Name = "lnkOptions";
            this.lnkOptions.Size = new System.Drawing.Size(36, 12);
            this.lnkOptions.TabIndex = 5;
            this.lnkOptions.TabStop = true;
            this.lnkOptions.Text = "Options";
            this.lnkOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOptions_LinkClicked_1);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 44);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(357, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 100);
            this.panel1.TabIndex = 6;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMp3FileLinkDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGrid.ContextMenuStrip = this.dataGridMenu;
            this.dataGrid.DataSource = this.getMp3FileLinkByTitleBindingSource;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(372, 100);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem3});
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem4.Text = "Play file";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "File Info";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(268, 12);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(98, 25);
            this.toolStrip.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchTitleToolStripMenuItem,
            this.searchAlbumToolStripMenuItem,
            this.searchArtistToolStripMenuItem});
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 22);
            this.btnSearch.Text = "Search Title";
            this.btnSearch.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // searchTitleToolStripMenuItem
            // 
            this.searchTitleToolStripMenuItem.Name = "searchTitleToolStripMenuItem";
            this.searchTitleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchTitleToolStripMenuItem.Text = "Search Title";
            this.searchTitleToolStripMenuItem.Click += new System.EventHandler(this.searchTitleToolStripMenuItem_Click);
            // 
            // searchAlbumToolStripMenuItem
            // 
            this.searchAlbumToolStripMenuItem.Name = "searchAlbumToolStripMenuItem";
            this.searchAlbumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchAlbumToolStripMenuItem.Text = "Search Album";
            this.searchAlbumToolStripMenuItem.Click += new System.EventHandler(this.searchAlbumToolStripMenuItem_Click);
            // 
            // searchArtistToolStripMenuItem
            // 
            this.searchArtistToolStripMenuItem.Name = "searchArtistToolStripMenuItem";
            this.searchArtistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchArtistToolStripMenuItem.Text = "Search Artist";
            this.searchArtistToolStripMenuItem.Click += new System.EventHandler(this.searchArtistToolStripMenuItem_Click);
            // 
            // idMp3FileLinkDataGridViewTextBoxColumn
            // 
            this.idMp3FileLinkDataGridViewTextBoxColumn.DataPropertyName = "IdMp3FileLink";
            this.idMp3FileLinkDataGridViewTextBoxColumn.HeaderText = "IdMp3FileLink";
            this.idMp3FileLinkDataGridViewTextBoxColumn.Name = "idMp3FileLinkDataGridViewTextBoxColumn";
            this.idMp3FileLinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMp3FileLinkDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Album";
            this.dataGridViewTextBoxColumn3.HeaderText = "Album";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // getMp3FileLinkByTitleBindingSource
            // 
            this.getMp3FileLinkByTitleBindingSource.DataMember = "GetMp3FileLinkByTitle";
            this.getMp3FileLinkByTitleBindingSource.DataSource = this.nSearcherDataSet;
            // 
            // nSearcherDataSet
            // 
            this.nSearcherDataSet.DataSetName = "NSearcherDataSet";
            this.nSearcherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMp3FileLinkByTitleTableAdapter
            // 
            this.getMp3FileLinkByTitleTableAdapter.ClearBeforeFill = true;
            // 
            // cmbSearchText
            // 
            this.cmbSearchText.FormattingEnabled = true;
            this.cmbSearchText.Location = new System.Drawing.Point(3, 14);
            this.cmbSearchText.Name = "cmbSearchText";
            this.cmbSearchText.Size = new System.Drawing.Size(262, 21);
            this.cmbSearchText.TabIndex = 7;
            this.cmbSearchText.TextChanged += new System.EventHandler(this.cmbSearchText_TextChanged);
            this.cmbSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearchText_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 66);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preserved Head";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notifyMenu.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.dataGridMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMp3FileLinkByTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSearcherDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.LinkLabel lnkFullScan;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getMp3FileLinkByTitleBindingSource;
        private NSearcherDataSet nSearcherDataSet;
        private Mp3Searcher.NSearcherDataSetTableAdapters.GetMp3FileLinkByTitleTableAdapter getMp3FileLinkByTitleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMp3FileLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip dataGridMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.LinkLabel lnkOptions;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton btnSearch;
        private System.Windows.Forms.ToolStripMenuItem searchTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchArtistToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSearchText;
    }
}

