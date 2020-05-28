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
    public partial class DepositCashForm : Form
    {
        public DepositCashForm()
        {
            InitializeComponent();
        }

        private void returnToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPageForm startPage = new StartPageForm();
            startPage.Show();
        }
    }
}
