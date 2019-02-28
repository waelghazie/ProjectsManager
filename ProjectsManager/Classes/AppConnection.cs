using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;


namespace ProjectsManager
{
    [DebuggerStepThrough]
    class AppConnection
    {
        public static SqlConnection GetConnection()
        {

            SqlConnection Connection = new SqlConnection(@"Data Source=" + Settings1.Default.SQLServer + ";Initial Catalog=" + Settings1.Default.DatabaseName + ";User ID=" + Settings1.Default.ServerUser + ";Password=" + Settings1.Default.SqlPassword + ";Connect Timeout=" + Settings1.Default.ServerConnectTimeout);

            return Connection;

        }
        public static SqlConnection GetConnectionUsingMaster()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=" + Settings1.Default.SQLServer + ";Initial Catalog=master;User ID=" + Settings1.Default.ServerUser + ";Password=" + Settings1.Default.SqlPassword + ";Connect Timeout=" + Settings1.Default.ServerConnectTimeout);
            return Connection;
        }

    }
}
