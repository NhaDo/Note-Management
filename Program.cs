using NoteMakingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMakingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static DataHandle data;
        [STAThread]
        static void Main()
        {
            initData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Application.Run(new PinForm());

        }


        private static void initData()
        {
            data = DataHandle.getInstance();
           
        }
    }
}
