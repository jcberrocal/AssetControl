using AssetControl.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Mutex to prevent multiple instances of the application
            using (Mutex mutex = new Mutex(false, "AssetControl"))
            {
                // Check if the application is already running
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("La aplicación ya se está ejecutando", "Control de Activos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
            }
        }
    }
}
