using PeoplesBank.Config;
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeoplesBankUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.AddIinstance();
            IAccountRepository Acctrepo = GlobalConfig.IAccountinstance;
            ICustomerRepository Custrepo = GlobalConfig.ICustomerinstance;
            IAuthRepository Authrepo = GlobalConfig.IAuthinstance;
            
            //CustomerData.LoadModelsFromFile();
            //AccountData.LoadModelsFromFile();
            //TransactionData.LoadModelsFromFile();
            Application.Run(new CreateAccount(Acctrepo, Custrepo, Authrepo));
        }
    }
}
