using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CadizAutoShopManagementSystem
{
    public static class DatabaseManager
    {
        private const string ConnectionString = "server=b9sxbycirx4uxfa6hy8i-mysql.services.clever-cloud.com;" +
                                                "database=b9sxbycirx4uxfa6hy8i;" +
                                                "userid=unskwri0pshtw6x6;" +
                                                "password=0GczO34KcOpMvIiOI57Q;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            return connection;
        }
    }
}
