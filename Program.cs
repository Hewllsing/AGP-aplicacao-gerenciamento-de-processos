using System;
using System.Windows.Forms;
using AGP.Forms;

namespace AGP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormLixo());
            Application.Run(new MainForm());

        }
    }
}
