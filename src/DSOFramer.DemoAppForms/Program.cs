// Program.cs

namespace DSOFramer.DemoAppForms
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// Win32 API for process-scoped DPI-awareness.
        /// </summary>
        /// <returns>True if successful, false otherwise.</returns>
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

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
                // Not working and looking ugly, disable for now
                //SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
