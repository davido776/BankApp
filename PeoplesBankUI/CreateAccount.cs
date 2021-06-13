using PeoplesBank.Config;
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    public partial class CreateAccount : Form
    {
        private readonly IAccountRepository acctrepo;
        private readonly ICustomerRepository custrepo;
        private readonly IAuthRepository authrepo;
       
        public CreateAccount(IAccountRepository Acctrepo, ICustomerRepository Custrepo, IAuthRepository Authrepo)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
            custrepo = Custrepo;
            authrepo = Authrepo;
    
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                    throw new Exception("First Name or Last Name must not be empty");

                if (!Helper.ValidateEmail(txtEmail.Text))
                    throw new Exception("Invalid Email");
                //var hashes = Helper.GenerateHash(txtPassword.Text);
                //byte[] passwordhash = hashes[0];
                //byte[] passwordsalt = hashes[1];
                //var date = DateTime.Now;
                //string acctno = Helper.GenerateNumber();
                var id = Guid.NewGuid().ToString();
                var fname = txtFirstName.Text;
                var lname = txtLastName.Text;
                var email = txtEmail.Text;
                var initialdeposit = nudInitialDeposit.Value;
                var type = cmbAccountType.Items[cmbAccountType.SelectedIndex].ToString();
                

                //var newcust = new Customer(id, fname, lname, email, date, passwordhash, passwordsalt);
                //AuthRepository.CurrentUser = newcust;

                var res = authrepo.Register(id,fname, lname, email,txtPassword.Text);
                if (res[0] == "failed")
                {
                    MessageBox.Show(res[1]);
                    
                }
                else
                {
                    acctrepo.CreateAccount(id,type, nudInitialDeposit.Value);
                    this.Hide();
                    LoginForm lf = new LoginForm(GlobalConfig.IAuthinstance, GlobalConfig.ICustomerdhinstance);
                    lf.Show();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm(authrepo,GlobalConfig.ICustomerdhinstance);
            lf.Show();
        }
    }
}
