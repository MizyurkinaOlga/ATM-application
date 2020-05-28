using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ATM_App
{
    public partial class StartPageForm : Form
    {
        ATM aTM;

        public StartPageForm()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Dictionary<int, int> tmp = new Dictionary<int, int>();
            int banknote;
            foreach (var key in appSettings.AllKeys)
            {
                if (int.TryParse(key, out banknote))
                {
                    tmp.Add(banknote, int.Parse(appSettings[key]));
                }
            }
            aTM = new ATM(tmp, int.Parse(appSettings["QuantityLimit"]));
            InitializeComponent();
        }

        private void completeService_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            WithdrawalCashForm dCashForm = new WithdrawalCashForm(aTM);
            dCashForm.Show();
        }
    }
}
