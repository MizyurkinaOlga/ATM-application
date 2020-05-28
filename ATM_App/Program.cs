using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ATM_App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Dictionary<int, int> tmp = new Dictionary<int, int>();
            int banknote;
            foreach(var key in appSettings.AllKeys)
            {
                if (int.TryParse(key, out banknote))
                {
                    tmp.Add(banknote, int.Parse(appSettings[key]));
                }
            }
            ATM aTM = new ATM(tmp, int.Parse(appSettings["QuantityLimit"]));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartPageForm());
        }
    }
}
