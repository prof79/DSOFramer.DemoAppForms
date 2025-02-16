// Program.cs

namespace DSOFramer.DemoAppForms
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The primary entry point to the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
