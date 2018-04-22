using System;
using System.Windows.Forms;

namespace Mp3Searcher
{
    public partial class Options : Form
    {
        private DialogResult _result;

        public Options()
        {
            InitializeComponent();
            _result = DialogResult.Cancel;
            btnSave.Enabled = false;
            listBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = txtNewPath.Text.Length > 0;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: { pnlScanType.SendToBack(); break; }
                case 1 : { pnlScanType.BringToFront(); break; }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                _result = DialogResult.OK;
                btnSave.Enabled = false;
            }

            DialogResult = _result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chkLstPaths.Items.Add(txtNewPath.Text);
        }
    }
}