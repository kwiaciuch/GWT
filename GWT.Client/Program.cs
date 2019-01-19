using System;
using System.Windows.Forms;
using GWT.Client.Views;
using GWT.Logger;

namespace GWT.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.LogInfo("================GWT Started================");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new GwtMainForm());
            }
            catch (Exception e)
            {
                Log.LogFatalAndShowMessageBox("Unexpected error occured:\n{0}\n{1}\n{2}", e.GetType(), e.Message, e.StackTrace);
            }
        }
    }
}
