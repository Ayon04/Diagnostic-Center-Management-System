﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adbms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
           //  Application.Run(new Reg());
            //Application.Run(new DataBase());
             //Application.Run(new PatientInfo());
         //  Application.Run(new AdminInterFace());
           // Application.Run(new PatientsRecord());
        }
    }
}
