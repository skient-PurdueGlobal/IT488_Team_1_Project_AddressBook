using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT488_Team_1_Project_AddressBook.DAL;

namespace IT488_Team_1_Project_AddressBook
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Update Database Directory Path
            string path = Environment.CurrentDirectory;
            path = path.Replace("\\bin\\Debug\\netcoreapp3.1", "");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            Debug.WriteLine(AppDomain.CurrentDomain.GetData("DataDirectory") + Environment.NewLine);

            //Load Database to DataSet
            Connection.Load_Database();

            //Application Modifiers
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PLL.AddressBook());
        }
    }
}
