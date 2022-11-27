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
                        MessageBox.Show("No foi possível se conetar com o servidor. Contate o administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Email ou senha invalida, por favor tente novamente");
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                    query = "INSERT INTO address (street, number, district, city, state, postalCode)" +
                            " VALUES (@street, @number, @district, @city, @state, @postalCode)";
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

        public void setUpdateQueryString(QueryType queryType)
        {
            switch(queryType)
            {
                case QueryType.address:
                    query = "UPDATE address SET (street = @street, number = @number, district = @district, city = @city, state = @state, postalCode = @postalCode) " +
                            "WHERE idAddress = @idAddress";
                    break;

                case QueryType.category:
                    query = "UPDATE category SET type = @type " +
                            "WHERE idCategory = @idCategory";
                    break;

                case QueryType.customer:
                    query = "UPDATE customer SET name = @name, email = @email, password = @password " +
                            "WHERE idCustomer = @idCustomer";
                    break;

                case QueryType.product:
                    query = "UPDATE product SET name = @name " +
                            "WHERE idProduct = @idProduct";
                    break;

                case QueryType.supermarket:
                    query = "UPDATE supermarket SET name = @name " +
                            "WHERE idSupermarket = @idSupermarket";
                    break;

                case QueryType.registerProduct:
                    query = "UPDATE registerProduct SET (idRegister, idCustomer, idSupermarket, idProduct, price, dateRegister) " +
                            "VALUES (@idRegister, @idCustomer, @idSupermarket, @idProduct, @price, @dateRegister)";
                    break;
            }
        }

        public void setDeleteQueryString(QueryType queryType)
        {
            switch (queryType)
            {
                case QueryType.address:
                    query = "DELETE FROM address ";
                    query += "WHERE idAddress = @idAddress";
                    break;

                case QueryType.category:
                    query = "DELETE FROM category ";
                    query += "WHERE idCategory = @idCategory";
                    break;

                case QueryType.customer:
                    query = "DELETE FROM customer ";
                    query += "WHERE idCustomer = @idCustomer";
                    break;

                case QueryType.product:
                    query = "DELETE FROM product ";
                    query += "WHERE idProduct = @idProduct";
                    break;

                case QueryType.supermarket:
                    query = "DELETE FROM supermarket ";
                    query += "WHERE idSupermarket = @idSupermarket";
                    break;

                case QueryType.registerProduct:
                    query = "DELETE FROM registerProduct ";
                    query += "WHERE idRegister = @idRegister";
                    break;
            }
        }

        //login
        public void selectLoginQueryString()
        {
            query = "SELECT idCustomer, name, email FROM customer " +
               "WHERE email = @login AND password = @password";
        }


        //Query supermarket
        public void selectSupermarketQueryString()
        {
            query = "SELECT idSupermarket, name FROM supermarket ORDER BY name";
        }

        //Query category

        public void selectCategoryQueryString()
        {
            query = "SELECT idCategory, type FROM category ORDER BY type";
        }

        //Query registerProduct

        public void selectRegisterProductQueryString(WhereType whereType, string search = "")
        {
            string where = "";

            switch (whereType)
            {
                case WhereType.like:
                    where = "INNER JOIN address AS A ON S.idAddress = A.idAddress " +
                        "INNER JOIN(" +
                        "      SELECT SA.city, SA.state FROM customer AS SC " +
                        "          INNER JOIN address AS SA ON SC.idAddress = SA.idAddress " +
                        "      WHERE SC.idCustomer = @idCustomer " +
                        ") AS SUB ON SUB.city = A.city AND SUB.state = A.state " +
                        "WHERE P.name LIKE '%"+ search +"%' " +
                        "ORDER BY P.name";
                break;

                case WhereType.limit:
                    where = "ORDER BY RP.dateRegister DESC " +
                            "LIMIT @limit";
                break;
            }

            query = "SELECT C.name AS 'customerName', S.name AS 'supermarketName'," +
                    "       P.name AS 'productDescription', RP.price AS 'price' " +
                    "  FROM registerProduct AS RP " +
                    "     INNER JOIN customer AS C ON RP.idCustomer = C.idCustomer " +
                    "     INNER JOIN supermarket AS S ON RP.idSupermarket = S.idSupermarket " +
                    "     INNER JOIN product AS P ON RP.idProduct = P.idProduct " + where;
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
