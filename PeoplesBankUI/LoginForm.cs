
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
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
    public partial class LoginForm : Form
    {
        public readonly IAuthRepository authrepo;
        public readonly ICustomerDataHandler _custdb;
        public LoginForm(IAuthRepository Authrepo, ICustomerDataHandler Custdb)
        {
            InitializeComponent();
            authrepo = Authrepo;
            _custdb = Custdb;

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var foundcustomer = _custdb.GetCustomerByEmail(txtEmail.Text);

                if (foundcustomer != null)
                {
                    if (authrepo.Login(txtEmail.Text, txtPassword.Text))
                    {
                        AuthRepository.CurrentUser = foundcustomer;
                        Thread.Sleep(3000);
                        this.Hide();
                        Dashboard db = new Dashboard();
                        db.Show();
                    }
                    else
                    {
                        throw new Exception("Incorrect Password");
                    }
                }
                else
                {
                    throw new Exception("User does not exist");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
    
}
