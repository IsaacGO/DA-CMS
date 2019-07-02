
using ControlApp.OnPremises.Forms.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlApp.OnPremises.Forms.Security;

namespace ControlApp.OnPremises
{
   
    static class Program
    {

        public static class MystaticValues
        {
           public static string IdSession = "N/A";
           public static int rptSsrs = 0;
           public static string rptSsrsDateBegin = "N/A";
           public static string rptSsrsDateEnd = "N/A";
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static ApplicationContext MainContext = new ApplicationContext();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainContext.MainForm = new frmLogin();
            Application.Run(MainContext);
        }
        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }
        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }
    }
}
