using System;
using System.Windows.Forms;

namespace MSMessage
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string str_message = "";
        [STAThread]

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-c":

                        break;
                    default:
                        str_message = args[i];
                        break;
                }
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form_message fm = new Form_message {
                info_message = str_message,
                TopMost = true,
            };

            Application.Run(fm);

        }
    }
}
