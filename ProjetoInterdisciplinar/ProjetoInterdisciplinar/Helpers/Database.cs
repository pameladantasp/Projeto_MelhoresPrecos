using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Helpers
{
    internal class Database
    {
        string databaseConnetionString;
        private MySqlConnection connetion;
        public string getConnectionString()
        {
            databaseConnetionString = "datasource=sql10.freemysqlhosting.net;username=sql10527490;password=MAPprojeto;database=sql10527490";
           //connectionString = ConfigurationManager.ConnectionStrings["ProjetoInterdisciplinar.Properties.Settings.databaseConnectionString"].ConnectionString;
            return databaseConnetionString;
        }
    }
}
