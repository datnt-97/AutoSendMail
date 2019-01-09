using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (GetProcessPath())
            {
                MessageBox.Show("Chương trình đang chạy");

                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form2(false));
        }
        public static bool GetProcessPath()
        {
            string name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            Process[] processList = Process.GetProcesses();
            // Loop through the array to show information of every process in your console
            int countTask = 0;
            foreach (Process process in processList)
            {
                if (process.ProcessName == name)
                {
                    countTask++;
                }
            }
            return countTask > 1 ? true : false;

        }
    }
}
