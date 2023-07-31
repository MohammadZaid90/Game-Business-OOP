using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BMS_Project.BL;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project
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
            MUserDL.readDataFromFile();
            AdminDL.ReadClientDataFromFile();
            Application.Run(new SignINForm());
        }
    }
}
