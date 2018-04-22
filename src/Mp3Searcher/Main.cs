using Mp3Searcher.Model;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mp3Searcher
{
    public partial class Main : Form
    {
        private delegate void SearchMethod();
        private Mp3SearchEngine engine;
        private bool closeApplication = false;
        private Options options = null;
        private SearchMethod searchMethod = null;

        public Main()
        {
            InitializeComponent();
            engine = Mp3SearchEngine.Instance;
            searchMethod = new SearchMethod(SearchTitle);
        }

        private void lnkOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("This process will override all the information stored in the DB. Are you sure to continue?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmbSearchText.Text = string.Empty;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon.BalloonTipTitle = this.Text;
                notifyIcon.BalloonTipText = "Full Scan started";
                notifyIcon.ShowBalloonTip(3000);
                int filesAdded = engine.FullScan();
                notifyIcon.BalloonTipTitle = this.Text;
                notifyIcon.BalloonTipText = "Full Scan finished, total files added: "+filesAdded.ToString();
                notifyIcon.ShowBalloonTip(3000);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            closeApplication = true;
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            cmbSearchText.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeApplication)
            {
                e.Cancel = true;
                cmbSearchText.Text = string.Empty;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void ShowResults()
        {
            //85 - 245
            this.Height = pnlSearch.Height + dataGrid.Height + statusStrip.Height + 23;
            statusStrip.Visible = true;
            statusStrip.Items[0].Text = string.Format("Total {0} files found",dataGrid.RowCount);
        }

        private void HideResults()
        {
            //85 - 245
            this.Height = pnlSearch.Height + 23;
            statusStrip.Visible = false;
        }

        private void SearchTitle()
        {
            dataGrid.DataSource = engine.SearchTitle(cmbSearchText.Text);
            ShowResults();
        }

        private void SearchArtist()
        {
            dataGrid.DataSource = engine.SearchArtist(cmbSearchText.Text);
            ShowResults();
        }
        
        private void SearchAlbum()
        {
            dataGrid.DataSource = engine.SearchAlbum(cmbSearchText.Text);
            ShowResults();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTitle();
        }

        private void cmbSearchText_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchText.Text.Length == 0)
            {
                HideResults();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            cmbSearchText.Focus();
        }

        private void Search()
        {
            //execute delegate
            if (searchMethod != null)
            {
                searchMethod();
            }
        }

        private void cmbSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSearchText.Text) && e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void PlayFile(int index)
        {
            string filePath = engine.GetFilePath(index);
            if (!string.IsNullOrEmpty(filePath))
            {
                Process p = new Process();
                p.StartInfo.FileName = filePath;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.Dispose();
            }
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PlayFile(Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            cmbSearchText.Focus();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PlayFile(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Mp3File mp3File = engine.GetMp3File(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value));
            if (mp3File != null)
            {
                FileInfo fileInfo = new FileInfo();
                fileInfo.ShowInfo(mp3File);
                fileInfo.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataRow dr = NetworkHostServiceData.Instance.GetNetworkHost();
            //if (dr != null)
            //{
            //    NetworkHost nh = new NetworkHost();
            //    nh.MapData(dr);
            //    if (!string.IsNullOrEmpty(nh.Path))
            //    {
            //        DialogResult dialog = MessageBox.Show(this.Text + " detect that a previous Scan was not successfully finished, do you want to continue and finish this Scan?. If you press No then you will be prompted the next time you start the application, if you press Cancel the unfinished Scan will be discarded", this.Text, MessageBoxButtons.YesNoCancel);
            //        if (dialog == DialogResult.Yes)
            //        {
            //            engine.ResumeFullScan(nh.HostName);
            //        }
            //        else
            //        {
            //            if (dialog == DialogResult.Cancel)
            //            {
            //                NetworkHostServiceData.Instance.Reset();
            //            }
            //        }
            //    }
            //}
        }

        private void lnkOptions_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (options == null)
            {
                options = new Options();
            }

            if (options.ShowDialog() == DialogResult.OK)
            { 
            
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Search();
        }

        private void searchTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Search Title";
            searchMethod = new SearchMethod(SearchTitle);
        }

        private void searchAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Search Album";
            searchMethod = new SearchMethod(SearchAlbum);
        }

        private void searchArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Search Artist";
            searchMethod = new SearchMethod(SearchArtist);
        }
    }
}