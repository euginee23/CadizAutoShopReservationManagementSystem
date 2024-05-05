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
        private const string ConnectionString = "server=bwnqthzv2o6xaim43ak5-mysql.services.clever-cloud.com;" +
                                                "database=bwnqthzv2o6xaim43ak5;" +
                                                "userid=uizbrucd6hqnoq24;" +
                                                "password=IqG7YurypTxLS9Z3T2Z;" +
                                                "port=20995";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            return connection;
        }
    }
}
