// Program.cs

namespace DSOFramer.DemoAppForms
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The primary entry point to the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // DPI-awareness for Office-embedding
            // https://stackoverflow.com/questions/4075802/creating-a-dpi-aware-application
            if (Environment.OSVersion.Version.Major >= 6)
            {
                // This - from StackOverflow - doesn't work:
                //Interop.SetProcessDPIAware();

                // This works - a newer API according to MSDN, introduced in Windows 8.1,
                // which is able to provide the same contextual info as the Microsoft Learn
                // asmv3 manifest sample does.
                Interop.SetProcessDpiAwareness(
                    Interop.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE
                );
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
