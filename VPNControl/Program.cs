using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VPNControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            Logger.End();
        }
    }
}
