
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    public partial class DepositForm : Form
    {
        private readonly IAccountRepository acctrepo;
        private readonly IAccountDataHandler _acctdata;
        
        public DepositForm(IAccountRepository Acctrepo, IAccountDataHandler Acctdata)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
            _acctdata = Acctdata;
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            var accts = _acctdata.GetAccountByOwnerId(AuthRepository.CurrentUser.Id);
            foreach (Account a in accts)
            {
                cmbAccountType.Items.Add($"{a.AccountNumber}-{a.Type}");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccountType.SelectedIndex == -1)
                    throw new Exception("You must select an account");
                if(nudDeposit.Value == 0 || nudDeposit.Value < 100 )
                    throw new Exception("You cannot Deposit below #100");
               
                var acctnum = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[0];
                var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[1];
               


                acctrepo.Deposit(acctnum, nudDeposit.Value, type);
                Thread.Sleep(3000);
                MessageBox.Show("Transaction Successfull");
                this.Close();
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
