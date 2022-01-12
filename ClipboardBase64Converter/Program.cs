using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardBase64Converter
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
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                //Application.Run();
                if (File.GetAttributes(Environment.GetCommandLineArgs()[1]).HasFlag(FileAttributes.Directory))
                    CbrdConverter.FromBase64(Environment.GetCommandLineArgs()[1]);
                else
                    CbrdConverter.ToBase64(Environment.GetCommandLineArgs()[1]);
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
