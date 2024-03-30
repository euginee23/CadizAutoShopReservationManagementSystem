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
        private const string ConnectionString = "server=localhost;" +
                                                "database=auto_reservation_db;" +
                                                "userid=root;" +
                                                "password=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            return connection;
        }
    }
}
