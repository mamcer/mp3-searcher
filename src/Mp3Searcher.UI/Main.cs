using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CrossCutting.MainModule.IOC;
using Mp3Searcher.Service;

namespace Mp3Searcher.UI
{
    public partial class Main : Form
    {
        private bool _closeApplication;

        private readonly IocUnityContainer _container;

        public Main()
        {
            _container = new IocUnityContainer();

            InitializeComponent();
        }

        private void lnkOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(
                    "This process will override all the information stored in the DB. Are you sure to continue?", Text,
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmbSearchText.Text = string.Empty;
                WindowState = FormWindowState.Minimized;
                Hide();
                notifyIcon.BalloonTipTitle = Text;
                notifyIcon.BalloonTipText = "Full Scan started";
                notifyIcon.ShowBalloonTip(3000);
                var fileCount = 0;

                var networkService = _container.Resolve<INetworkService>();
                var mp3FileService = _container.Resolve<IMp3FileService>();
                var myIp = networkService.GetMyIp();
                if (myIp != null)
                {
                    var myNetworkIp = $"{myIp[0]}.{myIp[1]}.{myIp[2]}";
                    for (int i = 0; i < 255; i++)
                    {
                        if (i == myIp[3])
                        {
                            var serverIp = $"{myNetworkIp}.{i}";
                            var shareList = networkService.GetNetworkShareFoldersList(serverIp);

                            foreach (var share in shareList)
                            {
                                var directories = new List<string> {$"\\\\{serverIp}\\{share}"};
                                for (int j = 0; j < directories.Count; j++)
                                {
                                    var directoryPath = directories[j];
                                    directories.AddRange(Directory.GetDirectories(directoryPath));

                                    Console.WriteLine($"scanning directory:{directoryPath}");
                                    foreach (var filePath in Directory.GetFiles(directoryPath))
                                    {
                                        Console.WriteLine($"        file:{filePath}");
                                        var fileExtension = Path.GetExtension(filePath);

                                        if (fileExtension.ToLower(CultureInfo.InvariantCulture) == ".mp3")
                                        {
                                            var mp3File = mp3FileService.GetMp3File(filePath);
                                            if (mp3File != null)
                                            {
                                                if (mp3FileService.Mp3FileExists(mp3File))
                                                {
                                                    mp3FileService.UpdateMp3File(mp3File);
                                                }
                                                else
                                                {
                                                    mp3FileService.SaveMp3File(mp3File);
                                                }
                                            
                                                fileCount += 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                notifyIcon.BalloonTipTitle = Text;
                notifyIcon.BalloonTipText = $"Full Scan finished, total files added: {fileCount}";
                notifyIcon.ShowBalloonTip(3000);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _closeApplication = true;
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            cmbSearchText.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_closeApplication)
            {
                e.Cancel = true;
                cmbSearchText.Text = string.Empty;
                WindowState = FormWindowState.Minimized;
                Hide();
            }
        }

        private void ShowResults()
        {
            //85 - 245
            Height = pnlSearch.Height + dataGrid.Height + statusStrip.Height + 23;
            statusStrip.Visible = true;
            statusStrip.Items[0].Text = $"Total {dataGrid.RowCount} files found";
        }

        private void HideResults()
        {
            //85 - 245
            Height = pnlSearch.Height + 23;
            statusStrip.Visible = false;
        }

        private void SearchTitle()
        {
            //dataGrid.DataSource = _engine.SearchTitle(cmbSearchText.Text);
            ShowResults();
        }

        private void SearchArtist()
        {
            //dataGrid.DataSource = _engine.SearchArtist(cmbSearchText.Text);
            ShowResults();
        }

        private void SearchAlbum()
        {
            //dataGrid.DataSource = _engine.SearchAlbum(cmbSearchText.Text);
            ShowResults();
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
            //_searchMethod?.Invoke();
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
            //string filePath = _engine.GetFilePath(index);
            //if (!string.IsNullOrEmpty(filePath))
            //{
            //    Process p = new Process
            //    {
            //        StartInfo =
            //        {
            //            FileName = filePath,
            //            CreateNoWindow = true
            //        }
            //    };
            //    p.Start();
            //    p.Dispose();
            //}
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
            Show();
            WindowState = FormWindowState.Normal;
            cmbSearchText.Focus();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PlayFile(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Mp3File mp3File = _engine.GetMp3File(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[0].Value));
            //if (mp3File != null)
            //{
            //    FileInfo fileInfo = new FileInfo();
            //    fileInfo.ShowInfo(mp3File);
            //    fileInfo.ShowDialog();
            //}
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
            //        DialogResult dialog = MessageBox.Show(Text + " detect that a previous Scan was not successfully finished, do you want to continue and finish this Scan?. If you press No then you will be prompted the next time you start the application, if you press Cancel the unfinished Scan will be discarded", Text, MessageBoxButtons.YesNoCancel);
            //        if (dialog == DialogResult.Yes)
            //        {
            //            engine.ResumeFullScan(nh.Name);
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

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Search();
        }

        private void searchTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Search Title";
            //_searchMethod = SearchTitle;
        }

        private void searchAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Search Album";
            //_searchMethod = SearchAlbum;
        }

        private void searchArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Search Artist";
            //_searchMethod = SearchArtist;
        }
    }
}