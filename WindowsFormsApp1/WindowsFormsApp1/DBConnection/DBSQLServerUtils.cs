using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendMailService
{
    class DBSQLServerUtils
    {
       
        public static SqlConnection
                 GetDBConnection(string serverName, string dataBaseName, string userName, string pass)
        {
            string connString = @"Data Source=" + @serverName+ "\\SQLEXPRESS" + ";Initial Catalog="
                        + dataBaseName + ";Persist Security Info=True;User ID=" + userName + ";Password=" + pass;

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
