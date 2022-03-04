using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
/// <summary>
/// HW-Soheilian
/// </summary>
namespace howto_tower_of_hanoi_animated
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
