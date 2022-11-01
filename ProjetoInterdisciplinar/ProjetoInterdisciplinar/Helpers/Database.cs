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
        public bool insert()
        {
            try
            {
                if (openConnection())
                {
                    execute();
                }
            }
            catch (Exception ex)
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
        public void setLoadQueryString()
        {
            query = "SELECT * FROM Consumer";
        }
        public void configureMySqlCommand()
        {
            command = new MySqlCommand(query, connection);
        }

        //Query Address
        public void setInsertAddressQueryString()
        {
            query = "INSERT INTO Address (street, number, city, state, postalCode)" +
                " VALUES (@street, @number, @city, @state, @postalCode)";
        }
        public void setUpdateAddressQueryString()
        {
            query = "UPDATE Address SET street = @street, number = @number, city = @city, state = @state, postalCode = @postalCode " +
                "WHERE idAddress = @idAddress";
        }
        public void setDeleteAddressQueryString()
        {
            query = "DELETE FROM Address ";
            query += "WHERE idAddress = @idAddress";
        }

        //Query customer
        public void setInsertCustomerQueryString()
        {
            query = "INSERT INTO Consumer (name, email, password, idAddress)" +
                " VALUES (@name, @email, @password, @idAddress)";
        }
        public void setUpdateCustomerQueryString()
        {
            query = "UPDATE Comsumer SET name = @name, email = @email, password = @password " +
                "WHERE idConsumer = @idConsumer";
        }
        public void setDeleteCustomerQueryString()
        {
            query = "DELETE FROM Consumer ";
            query += "WHERE idConsumer = @idConsumer";
        }

        //Query supermarket
        public void setInsertSupermarketQueryString()
        {
            query = "INSERT INTO Supermarket (name, idAddress)" +
                " VALUES (@name, @idAddress)";
        }
        public void setUpdateSupermarketQueryString()
        {
            query = "UPDATE Supermarket SET name = @name "+
                "WHERE idSupermarket = @idSupermarket";
        }
        public void setDeleteSupermarketQueryString()
        {
            query = "DELETE FROM Supermarket ";
            query += "WHERE idSupermarket = @idSupermarket";
        }

        //Query category
        public void setInsertCategoryQueryString()
        {
            query = "INSERT INTO Category (type) VALUES (@type)";
        }
        public void setUpdateCategoryQueryString()
        {
            query = "UPDATE Category SET type = @type " +
                "WHERE idCategory = @idCategory";
        }
        public void setDeleteCategoryQueryString()
        {
            query = "DELETE FROM Category ";
            query += "WHERE idCategory = @idCategory";
        }

        //Query Product
        public void setInsertProductQueryString()
        {
            query = "INSERT INTO Product (name, idCategory) VALUES (@name, @idCategory)";
        }
        public void setUpdateProductQueryString()
        {
            query = "UPDATE Product SET name = @name " +
                "WHERE idProduct = @idProduct";
        }
        public void setDeleteProductQueryString()
        {
            query = "DELETE FROM Product ";
            query += "WHERE idProduct = @idProduct";
        }

        //Query registerProduct
       
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
