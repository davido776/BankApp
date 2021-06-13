using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PeoplesBank.Data
{
    public class DBConfig
    {
        public static SqlConnection GetConnection()
        {

            string conn = "Data Source=.;Initial Catalog=PeoplesBank;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(conn);
            return myConn;
        }
    }
}
