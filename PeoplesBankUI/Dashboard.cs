using PeoplesBank.Config;
using PeoplesBank.Core.Services;
using System;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
           
        }
        private Form activeform = null;

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            openChidForm(new txtOpenAccount(GlobalConfig.IAccountinstance,GlobalConfig.IAccountdhinstance));
        }
        private void btnDepsosit_Click(object sender, EventArgs e)
        {
            openChidForm(new DepositForm(GlobalConfig.IAccountinstance,GlobalConfig.IAccountdhinstance));
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            openChidForm(new WithdrawForm(GlobalConfig.IAccountinstance, GlobalConfig.IAccountdhinstance));
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            openChidForm(new TransferForm(GlobalConfig.IAccountinstance,GlobalConfig.IAccountdhinstance,GlobalConfig.ICustomerdhinstance));
        }
        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            openChidForm(new BalanceForm(GlobalConfig.IAccountinstance,GlobalConfig.IAccountdhinstance));
        }
        private void btnGetAccountStatement_Click(object sender, EventArgs e)
        {
            openChidForm(new StatementForm(GlobalConfig.IAccountinstance,GlobalConfig.IAccountdhinstance,GlobalConfig.ITransactiondhinstance));
        }
        private void openChidForm(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panChildForm.Controls.Add(childform);
            panChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void panChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthRepository.CurrentUser = null;
            this.Hide();
            LoginForm lf = new LoginForm(GlobalConfig.IAuthinstance,GlobalConfig.ICustomerdhinstance);
            lf.Show();


        }
    }
}
