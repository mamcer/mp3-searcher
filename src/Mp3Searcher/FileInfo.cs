using System;
using System.Windows.Forms;
using Mp3Searcher.Core;

namespace Mp3Searcher
{
    public partial class FileInfo : Form
    {
        public FileInfo()
        {
            InitializeComponent();
        }

        public void ShowInfo(Mp3File mp3File)
        {
            lblAlbum.Text = mp3File.Album;
            lblArtist.Text = mp3File.Artist;
            lbTitle.Text = mp3File.Title;
            lblHost.Text = mp3File.Host;
            txtPath.Text = mp3File.Path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}