﻿using System;
using System.Windows.Forms;

namespace Voenkaff
{
    static class Program
    {
        public static FormHello FormHello;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormHello = new FormHello();
            Application.Run(FormHello);
        }
    }
}
