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
    public partial class txtOpenAccount : Form
    {
        public static string FirstName;
        public static string LastName;
        private readonly IAccountRepository acctrepo;
        private readonly IAccountDataHandler _acctdata;
        public txtOpenAccount(IAccountRepository Acctrepo, IAccountDataHandler Acctdata)
        {
            InitializeComponent();
            FirstName = AuthRepository.CurrentUser.FirstName;
            LastName = AuthRepository.CurrentUser.LastName;
            acctrepo = Acctrepo;
            _acctdata = Acctdata;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString();
                var accounts = _acctdata.GetAccountByOwnerId(AuthRepository.CurrentUser.Id);
                Account existingaccount = null;
                foreach (Account a in accounts)
                {
                    if (a.Type == type)
                        existingaccount = a;
                }
                if(existingaccount != null)
                    throw new Exception($"You already have a {type} account!!");
                if (existingaccount == null)
                {
                    txtFirstName.Text = FirstName;
                    txtLastName.Text = LastName;
                    //var date = DateTime.Now;
                    //string acctno = Helper.GenerateNumber();
                    //var newacct = new Account(acctno, AuthRepository.CurrentUser.Id, Decimal.Parse(nudInitialDeposit.Text), type, date);
                    acctrepo.CreateAccount(AuthRepository.CurrentUser.Id,type, nudInitialDeposit.Value);
                    Thread.Sleep(3000);
                    this.Close();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtOpenAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = AuthRepository.CurrentUser.FirstName;
            txtLastName.Text = AuthRepository.CurrentUser.LastName;
            txtEmail.Text = AuthRepository.CurrentUser.Email;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
