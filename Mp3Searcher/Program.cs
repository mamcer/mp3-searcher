using System;
using System.Windows.Forms;

namespace Mp3Searcher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.ErrorText = ex.StackTrace + ex.Message;
                errorForm.ShowDialog();
            }
        }
    }
}