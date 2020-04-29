/*
* IVS - project 2 - Calculator
* Team Orient Express
* Ac. y. 2019/20
*/
/**
* @file Program.cs
* @brief Entry point for the application
*/

using System;
using System.Windows.Forms;

namespace Kalkulacka
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
