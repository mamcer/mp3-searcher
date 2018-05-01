using System;
using System.Windows.Forms;
using Mp3Searcher.Core;

namespace Mp3Searcher.UI
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}