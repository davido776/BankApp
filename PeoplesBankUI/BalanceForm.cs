
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    public partial class BalanceForm : Form
    {
        private readonly IAccountRepository acctrepo;
        private readonly IAccountDataHandler _acctdata;
        
        public BalanceForm(IAccountRepository Acctrepo, IAccountDataHandler Acctdata)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
            _acctdata = Acctdata;
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            var accts = _acctdata.GetAccountByOwnerId(AuthRepository.CurrentUser.Id);
            foreach (Account a in accts)
            {
                cmbAccountType.Items.Add($"{a.AccountNumber}-{a.Type}");
            }
        }

        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[1];
            var acctnum = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[0];
            var res = acctrepo.GetBalance(acctnum);
            MessageBox.Show($"Your {type} account balance : {res}");
            
           
        }
    }
}
