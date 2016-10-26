using System;
using System.Windows.Forms;

namespace Noisy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                switch (args[0])
                {
                    case "encode":
                        Application.Run(new frmEncode());
                        break;
                    case "decode":
                        Application.Run(new frmDecode());
                        break;
                }
            }
        }
    }
}
