using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    public partial class WithdrawalCashForm : Form
    {
        Dictionary<int, int> currentRequest;
        ATM aTM;
        int amount = 0;

        public WithdrawalCashForm(ATM atmBanknotes)
        {
            aTM = new ATM(atmBanknotes);
            currentRequest = new Dictionary<int, int>();
            foreach(var item in atmBanknotes.AffordableBanknotes)
            {
                currentRequest.Add(item.Key, 0);
            }
            InitializeComponent();
            amountTextBox.Text = amount.ToString();
        }

        private void returnToStart_Click(object sender, EventArgs e)
        {
            this.Close();
            StartPageForm startPage = new StartPageForm();
            startPage.Show();
        }

        private void completeService_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic50rbls_Click(object sender, EventArgs e)
        {
            amount += 50;
            currentRequest[50]++;
            if (aTM.AffordableBanknotes[50] == currentRequest[50])
            {
                pic50rbls.Enabled = false;
                pic50rbls.Visible = false;
            }
            amountTextBox.Text = amount.ToString();
        }
    }
}
