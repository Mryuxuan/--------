using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static string GetConnectionString()
        {
            string returnValue = null;
            string ConnectionName = "JobConnectionString";
            ConnectionStringSettings settings;
            settings = ConfigurationManager.ConnectionStrings[ConnectionName];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
    }
}
