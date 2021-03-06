using System;
using System.Windows.Forms;

namespace Mp3Searcher.UI
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        public string ErrorText
        {
            get => txtError.Text;

            set => txtError.Text = value;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(ErrorText);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}