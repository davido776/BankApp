
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
    public partial class TransferForm : Form
    {
        private readonly IAccountRepository acctrepo;
        private readonly IAccountDataHandler _acctdata;
        private readonly ICustomerDataHandler _custdata;
      
        public TransferForm(IAccountRepository Acctrepo, IAccountDataHandler Acctdata, ICustomerDataHandler Custdata)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
            _acctdata = Acctdata;
            _custdata = Custdata;
        }
        private void TransferForm_Load(object sender, EventArgs e)
        {
            var accts = _acctdata.GetAccountByOwnerId(AuthRepository.CurrentUser.Id);
            foreach (Account a in accts)
            {
                cmbAccountType.Items.Add($"{a.AccountNumber}-{a.Type}");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccountType.SelectedIndex == -1)
                    throw new Exception("You must select an account");
                var acctnum = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[0];
                var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[1];
                var recipientAccount = _acctdata.GetAccountByNumber(txtRecipientAccountNumber.Text);
                var senderaccount = _acctdata.GetAccountByNumber(acctnum);
                Customer recipient = null;

                if (recipientAccount == null)
                    throw new Exception("Account does not exist");
                if (senderaccount == null)
                    throw new Exception($"You do not have a {type} account");
                recipient = _custdata.GetCustomerById(recipientAccount.OwnerId);


                DialogResult res = MessageBox.Show($"Confirm Transfer of {nudAmountToTransfer.Text} to {recipient.FullName} ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    var transferresponse = acctrepo.Transfer(senderaccount.AccountNumber, txtRecipientAccountNumber.Text, nudAmountToTransfer.Value, type);
                    if (transferresponse[0] == "failed")
                    {
                        MessageBox.Show(transferresponse[1]);
                    }
                    else
                    {
                        MessageBox.Show("TRANSFER SUCCESSFUL");
                    }
                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }

        

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
