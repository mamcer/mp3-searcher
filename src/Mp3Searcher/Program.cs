using System;
using System.Threading;
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
            Application.ThreadException += ApplicationOnThreadException;
            Application.Run(new Main());
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            ErrorForm errorForm = new ErrorForm();
            errorForm.ErrorText = threadExceptionEventArgs.Exception.StackTrace + threadExceptionEventArgs.Exception.Message;
            errorForm.ShowDialog();
        }
    }
}