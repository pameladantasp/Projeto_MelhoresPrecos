using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.Helpers
{
    internal class Database
    {
        private string databaseConnetionString;
        private MySqlConnection connection;
        public MySqlCommand command;
        private string query;
        public MySqlDataReader dataReader;

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
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
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
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
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
        public void configureMySqlCommand()
        {
            command = new MySqlCommand(query, connection);
        }

        public void select()
        {
            try
            {
                if (openConnection())
                {
                    executeDataReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void executeDataReader()
        {
            dataReader = command.ExecuteReader();
        }

        public void setInsertQueryString(QueryType queryType)
        {
            switch(queryType)
            {
                case QueryType.address:
                    query = "INSERT INTO address (street, number, city, state, postalCode)" +
                            " VALUES (@street, @number, @city, @state, @postalCode)";
                    break;

                case QueryType.category:
                    query = "INSERT INTO category (type) VALUES (@type)";
                    break;

                case QueryType.customer:
                    query = "INSERT INTO customer (name, email, password, idAddress)" +
                            " VALUES (@name, @email, @password, @idAddress)";
                    break;

                case QueryType.product:
                    query = "INSERT INTO product (name, category) VALUES (@name, @category)";
                    break;

                case QueryType.supermarket:
                    query = "INSERT INTO supermarket (name, idAddress)" +
                            " VALUES (@name, @idAddress)";
                    break;

                case QueryType.registerProduct:
                    query = "INSERT INTO registerProduct (idCustomer, idSupermarket, idProduct, price, dateRegister)" +
                            " VALUES (@idCustomer, @idSupermarket, @idProduct, @price, @dateRegister)";
                    break;
            }
        }

        //Query Address
        public void setUpdateAddressQueryString()
        {
            query = "UPDATE address SET (street = @street, number = @number, city = @city, state = @state, postalCode = @postalCode) " +
                "WHERE idAddress = @idAddress";
        }
        public void setDeleteAddressQueryString()
        {
            query = "DELETE FROM address ";
            query += "WHERE idAddress = @idAddress";
        }

        //Query customer

        //login
        public void selectLoginQueryString()
        {
            query = "SELECT idCustomer, name, email FROM customer " +
               "WHERE email = @login AND password = @password";
        }
        public void setLoadQueryString()
        {
            query = "SELECT * FROM customer";
        }
        public void setUpdateCustomerQueryString()
        {
            query = "UPDATE customer SET name = @name, email = @email, password = @password " +
                "WHERE idCustomer = @idCustomer";
        }
        public void setDeleteCustomerQueryString()
        {
            query = "DELETE FROM customer ";
            query += "WHERE idCustomer = @idCustomer";
        }

        //Query supermarket
        public void selectSupermarketQueryString()
        {
            query = "SELECT idSupermarket, name FROM supermarket ORDER BY name";
        }
        public void setUpdateSupermarketQueryString()
        {
            query = "UPDATE supermarket SET name = @name " +
                "WHERE idSupermarket = @idSupermarket";
        }
        public void setDeleteSupermarketQueryString()
        {
            query = "DELETE FROM supermarket ";
            query += "WHERE idSupermarket = @idSupermarket";
        }

        //Query category

        public void selectCategoryQueryString()
        {
            query = "SELECT idCategory, type FROM category ORDER BY type";
        }
        public void setUpdateCategoryQueryString()
        {
            query = "UPDATE category SET type = @type " +
                "WHERE idCategory = @idCategory";
        }
        public void setDeleteCategoryQueryString()
        {
            query = "DELETE FROM category ";
            query += "WHERE idCategory = @idCategory";
        }

        //Query Product
        public void setUpdateProductQueryString()
        {
            query = "UPDATE product SET name = @name " +
                "WHERE idProduct = @idProduct";
        }
        public void setDeleteProductQueryString()
        {
            query = "DELETE FROM product ";
            query += "WHERE idProduct = @idProduct";
        }

        //Query registerProduct
        public void setUpdateRegisterProductQueryString()
        {
            query = "UPDATE registerProduct SET (idRegister, idCustomer, idSupermarket, idProduct, price, dateRegister) " +
                "VALUES (@idRegister, @idCustomer, @idSupermarket, @idProduct, @price, @dateRegister)";
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
