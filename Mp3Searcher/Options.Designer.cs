namespace Mp3Searcher
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlFolders = new System.Windows.Forms.Panel();
            this.pnlScanType = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.chkLstPaths = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFolders.SuspendLayout();
            this.pnlScanType.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Folders",
            "Scan Type"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pnlFolders
            // 
            this.pnlFolders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFolders.Controls.Add(this.btnAdd);
            this.pnlFolders.Controls.Add(this.txtNewPath);
            this.pnlFolders.Controls.Add(this.chkLstPaths);
            this.pnlFolders.Controls.Add(this.pnlScanType);
            this.pnlFolders.Location = new System.Drawing.Point(112, 12);
            this.pnlFolders.Name = "pnlFolders";
            this.pnlFolders.Size = new System.Drawing.Size(367, 238);
            this.pnlFolders.TabIndex = 1;
            // 
            // pnlScanType
            // 
            this.pnlScanType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScanType.Controls.Add(this.radioButton3);
            this.pnlScanType.Controls.Add(this.radioButton2);
            this.pnlScanType.Controls.Add(this.radioButton1);
            this.pnlScanType.Location = new System.Drawing.Point(-1, -1);
            this.pnlScanType.Name = "pnlScanType";
            this.pnlScanType.Size = new System.Drawing.Size(367, 238);
            this.pnlScanType.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Check for new folders";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Only new hosts";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Full Scan";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(13, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(13, 170);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(349, 22);
            this.txtNewPath.TabIndex = 5;
            this.txtNewPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkLstPaths
            // 
            this.chkLstPaths.FormattingEnabled = true;
            this.chkLstPaths.Items.AddRange(new object[] {
            "C:\\Documents and Settings",
            "C:\\Musica",
            "C:\\Music",
            "C:\\Mp3"});
            this.chkLstPaths.Location = new System.Drawing.Point(13, 24);
            this.chkLstPaths.Name = "chkLstPaths";
            this.chkLstPaths.Size = new System.Drawing.Size(198, 140);
            this.chkLstPaths.TabIndex = 4;
            this.chkLstPaths.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(323, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 287);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlFolders);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.pnlFolders.ResumeLayout(false);
            this.pnlFolders.PerformLayout();
            this.pnlScanType.ResumeLayout(false);
            this.pnlScanType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Panel pnlFolders;
        private System.Windows.Forms.CheckedListBox chkLstPaths;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Panel pnlScanType;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}