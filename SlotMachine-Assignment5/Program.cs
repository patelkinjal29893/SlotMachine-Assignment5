// App Name : Program Form
// Author Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : April 3rd, 2017
// App Description : This is the entry point o this application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine_Assignment5
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
            Application.Run(new SlotMachineForm());
        }
    }
}
