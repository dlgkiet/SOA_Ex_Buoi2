using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WorldSOAP.db
{
    public class ConnectDB
    {
        private static SqlConnection connection;

        private static SqlConnection connect(string server, string dbName)
        {
            string connectionString = $"Server={server};Database={dbName};Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            return connection;
        }

        private ConnectDB()
        {
        }

        public static SqlConnection getInstance()
        {
            if (connection == null)
                connection = connect("localhost", "world");
            return connection;
        }
    }
}