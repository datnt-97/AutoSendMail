using AutoSendMailService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendBirhDayMail.DBConnection
{
    class DBTestConnection
    {
        public void TestConnection(string serverName, string dataBaseName, string userName, string pass)
        {
            SqlConnection conn = DBSQLServerUtils.GetDBConnection(serverName, dataBaseName, userName, pass);
            conn.Open();
            conn.Close();
            conn.Dispose();
        }
    }
}
