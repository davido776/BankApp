
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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    public partial class StatementForm : Form
    {
        private readonly IAccountRepository acctrepo;
        private readonly IAccountDataHandler _acctdata;
        private readonly ITransactionDataHandler _transactdata;
       

        public StatementForm(IAccountRepository AcctRepo, IAccountDataHandler Acctdata, ITransactionDataHandler Transactdata )
        {
            InitializeComponent();
            acctrepo = AcctRepo;
            _acctdata = Acctdata;
            _transactdata = Transactdata;
        }

        private void StatementForm_Load(object sender, EventArgs e)
        {
            var accts = _acctdata.GetAccountByOwnerId(AuthRepository.CurrentUser.Id);
            foreach (Account a in accts)
            {
                cmbAccountType.Items.Add($"{a.AccountNumber}-{a.Type}");
            }
        }
       private void btnGetStatement_Click(object sender, EventArgs e)
       {
            
            
           
        }

        private void lvStatement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetStatement_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (cmbAccountType.SelectedIndex == -1)
                    throw new Exception("You must select an account type");
                var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[1];
                var acctnum = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString().Split("-")[0];
               
                if (acctnum == null)
                    throw new Exception($"You do not have a {type} account");
                var currentbalance = acctrepo.GetBalance(acctnum);
                var transactions = _transactdata.GetTransactionByAccountNumber(acctnum);
                for (int i = 0; i < lvStatement.Items.Count; i++)
                {
                        lvStatement.Items[i].Remove();
                        i++;
                }
                foreach (Transact t in transactions)
                {
                    lvStatement.Items.Add(new ListViewItem(new string[] {
                    t.Id,t.Amount.ToString(),t.TransactionDate.ToString(),t.Note
                }));
                }
                lblCurrentBalanceFigure.Text = currentbalance.ToString();
                lblAccountNumber.Text = acctnum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
