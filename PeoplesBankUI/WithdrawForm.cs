
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
using System.Threading;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    public partial class WithdrawForm : Form
    {
        private readonly IAccountRepository acctrepo;
        private readonly IAccountDataHandler _acctdata;
       
        public WithdrawForm(IAccountRepository Acctrepo, IAccountDataHandler Acctdata)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
            _acctdata = Acctdata;
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            var accts = _acctdata.GetAccountByOwnerId(AuthRepository.CurrentUser.Id);
            foreach (Account a in accts)
            {
                cmbAccountType.Items.Add($"{a.AccountNumber}-{a.Type}");
            }
        }

       
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudAmountToWithdraw.Value == 0 || nudAmountToWithdraw.Value < 500)
                     throw new Exception("You cannot Withdraw below #500");
                if (cmbAccountType.SelectedIndex == -1)
                     throw new Exception("You must select an account");
                var acctnum = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[0];
                var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[1];
                if (acctnum == null)
                    throw new Exception($"You do not have a {type} account");
                DialogResult dialogres = MessageBox.Show($"Confirm Withdraw of {nudAmountToWithdraw.Value}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialogres == DialogResult.OK)
                {
                    var res = acctrepo.Withdraw(acctnum, nudAmountToWithdraw.Value, type);
                    if (res[0] == "failed")
                    {
                        MessageBox.Show(res[1]);
                    }
                    else
                    {
                        MessageBox.Show("Transaction Successfull");
                        Thread.Sleep(3000);
                        this.Close();
                    }
                }
                else
                {
                    this.Hide();
                }
                
               
      

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
           
        }
    }
}
