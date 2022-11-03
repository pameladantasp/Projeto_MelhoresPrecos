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
            query = "SELECT * FROM costumer";
        }
        public void configureMySqlCommand()
        {
            command = new MySqlCommand(query, connection);
        }

        //Query Address
        public void setInsertAddressQueryString()
        {
            query = "INSERT INTO address (Street, Number, City, State, PostalCode)" +
                " VALUES (@Street, @Number, @City, @State, @PostalCode)";
        }
        public void setUpdateAddressQueryString()
        {
            query = "UPDATE address SET (Street = @Street, Number = @Number, City = @City, State = @State, PostalCode = @PostalCode) " +
                "WHERE idAddress = @idAddress";
        }
        public void setDeleteAddressQueryString()
        {
            query = "DELETE FROM address ";
            query += "WHERE idAddress = @idAddress";
        }

        //Query customer
        public void setInsertCustomerQueryString()
        {
            query = "INSERT INTO costumer (name, email, password, idAddress)" +
                " VALUES (@name, @email, @password, @idAddress)";
        }
        public void setUpdateCustomerQueryString()
        {
            query = "UPDATE costumer SET name = @name, email = @email, password = @password " +
                "WHERE idConsumer = @idConsumer";
        }
        public void setDeleteCustomerQueryString()
        {
            query = "DELETE FROM costumer ";
            query += "WHERE idCostumer = @idCostumer";
        }

        //Query supermarket
        public void setInsertSupermarketQueryString()
        {
            query = "INSERT INTO supermarket (Name, idAddress)" +
                " VALUES (@Name, @idAddress)";
        }
        public void setUpdateSupermarketQueryString()
        {
            query = "UPDATE supermarket SET Name = @Name "+
                "WHERE idSupermarket = @idSupermarket";
        }
        public void setDeleteSupermarketQueryString()
        {
            query = "DELETE FROM supermarket ";
            query += "WHERE idSupermarket = @idSupermarket";
        }

        //Query category
        public void setInsertCategoryQueryString()
        {
            query = "INSERT INTO category (Type) VALUES (@Type)";
        }
        public void setUpdateCategoryQueryString()
        {
            query = "UPDATE category SET Type = @Type " +
                "WHERE idCategory = @idCategory";
        }
        public void setDeleteCategoryQueryString()
        {
            query = "DELETE FROM category ";
            query += "WHERE idCategory = @idCategory";
        }

        //Query Product
        public void setInsertProductQueryString()
        {
            query = "INSERT INTO product (Name, idCategory) VALUES (@Name, @idCategory)";
        }
        public void setUpdateProductQueryString()
        {
            query = "UPDATE product SET Name = @Name " +
                "WHERE idProduct = @idProduct";
        }
        public void setDeleteProductQueryString()
        {
            query = "DELETE FROM product ";
            query += "WHERE idProduct = @idProduct";
        }

        //Query registerProduct

        public void setInsertRegisterProductQueryString()
        {
            query = "INSERT INTO registerProduct (idRegister, idCustomer, idSupermarket, idProduct, Price, DateRegister) " +
                "VALUES (@idRegister, @idCustomer, @idSupermarket, @idProduct, @Price, @DateRegister)";
        }
        public void setUpdateRegisterProductQueryString()
        {
            query = "UPDATE registerProduct SET (idRegister, idCustomer, idSupermarket, idProduct, Price, DateRegister) " +
                "VALUES (@idRegister, @idCustomer, @idSupermarket, @idProduct, @Price, @DateRegister)";
        }
        public void setDeleteRegisterProductQueryString()
        {
            query = "DELETE FROM registerProduct ";
            query += "WHERE idRegister = @idRegister";
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
