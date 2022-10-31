using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Helpers
{
    internal class Database
    {
        private string databaseConnetionString;
        private MySqlConnection connection;
        public MySqlCommand command;
        private string query;

        public Database()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = getConnectionString();
        }
        private string getConnectionString()
        {
            databaseConnetionString = "datasource=sql10.freemysqlhosting.net;username=sql10527490;password=MAPprojeto;database=sql10527490";
           //connectionString = ConfigurationManager.ConnectionStrings["ProjetoInterdisciplinar.Properties.Settings.databaseConnectionString"].ConnectionString;
            return databaseConnetionString;
        }
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Invalidate username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public void closeConnection()
        {
            connection.Close();
        }

        public void setLoadQueryString()
        {
            query = "SELECT * FROM Consumer";
        }
        public void setInsertCustomerQueryString()
        {
            query = "INSERT INTO Consumer (nameConsumer, emailConsumer, password, idAddress)" +
                " VALUES (@nameConsumer, @emailConsumer, @password, @idAddress)";
        }
        public void setInsertAddressQueryString()
        {
            query = "INSERT INTO Address (street, number, city, state, postalCode)" +
                " VALUES (@street, @number, @city, @state, @postalCode)";
        }
        public void setInsertProductQueryString()
        {
            query = "INSERT INTO Product (name, category) VALUES (@name, @category)";
        }
        public void setUpdateQueryString()
        {
            query = "UPDATE Comsumer SET nameConsumer = @nameConsumer, emailConsumer = @emailConsumer password = @password " +
                "WHERE idConsumer = @idConsumer";
        }
        public void setDeleteQueryString()
        {
            query = "DELETE FROM Consumer ";
            query += "WHERE idConsumer = @idConsumer";
        }
        public void configureMySqlCommand()
        {
            command = new MySqlCommand(query, connection);
        }
        public bool insert()
        {
            try
            {
                if (openConnection())
                {
                    execute();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        private void execute()
        {
            command.ExecuteNonQuery();
        }

        public int getNextId(string nameTable)
        {
            query = "SELECT AUTO_INCREMENT FROM information_schema.TABLES " +
            "WHERE TABLE_SCHEMA = 'sql10527490' " +
            "AND TABLE_NAME = '" + nameTable + "'";

            int id;

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                id = Int32.Parse(dataTable.Rows[0]["AUTO_INCREMENT"].ToString());
            }
            return id;
        }
    }
}
