using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIES_SUSTAV
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
            Application.Run(new frm_LogInPorezniObveznik());
            //Application.Run(new frm_GlavniForm("1111", "Zaposlenik PU"));
            //Application.Run(new frm_GlavniForm("12345678912", "Porezni obveznik"));
        }
    }
}
