using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Model;
using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Helpers;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CustomerDAO
    {
        private Database database;
        private ErrorResult result;
        public string message;
        public CustomerDAO()
        {
            database = new Database();
        }

        public ErrorResult verifyLogin(Customer customer)
        {
            try
            {
                database.selectLoginQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@login", customer.email);
                database.command.Parameters.AddWithValue("@password", EasyEncryption.MD5.ComputeMD5Hash(customer.password));
                database.select();

                if (database.dataReader != null)
                {
                    if (database.dataReader.HasRows)
                    {
                        while (database.dataReader.Read())
                        {
                            Customer.shared.idCustomer = Int32.Parse(database.dataReader["idCustomer"].ToString());
                            Customer.shared.name = database.dataReader["name"].ToString();
                            Customer.shared.email = database.dataReader["email"].ToString();
                            result = ErrorResult.success;
                        }
                    }
                    else
                    {
                        result = ErrorResult.invalide;
                    }
                }
            }
            catch(MySqlException)
            {
                this.message = "Erro com o Banco de Dados!!";
                result = ErrorResult.failure;
            }
            finally
            {
               database.closeConnection();
            }
            return result;
        }
        public ErrorResult insertData(Customer customer)
        {
            try
            {
                int idAddress = database.getNextId("address");
                
                AddressDAO addressDAO = new AddressDAO();
                bool didInsert = addressDAO.insertData(customer.address);

                if (didInsert)
                {
                    database.setInsertQueryString(QueryType.customer);
                    database.configureMySqlCommand();
                    database.command.Parameters.AddWithValue("@name", customer.name);
                    database.command.Parameters.AddWithValue("@email", customer.email);
                    database.command.Parameters.AddWithValue("@password", EasyEncryption.MD5.ComputeMD5Hash(customer.password));
                    database.command.Parameters.AddWithValue("@idAddress", idAddress);
                    database.insert();
                    result = ErrorResult.success;
                }
                else
                {
                    result = ErrorResult.failure;
                }
            }
            catch(MySqlException)
            {
                this.message = "Erro na conexao com o banco de dados!";
                result = ErrorResult.failure;
            }
            finally
            {
                database.closeConnection();
            }
            return result;
        }
        public void updateData(Customer customer)
        {
            try
            {
                database.setUpdateCustomerQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", customer.name);
                database.command.Parameters.AddWithValue("@email", customer.email);
                database.command.Parameters.AddWithValue("@password", customer.password);
                database.insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }
        public bool deleteData(int idCustomer)
        {
            bool didDelete;

            try
            {
                database.setDeleteCustomerQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idCustomer", idCustomer);
                database.insert();
                didDelete = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                didDelete = false;
            }
            finally
            {
                database.closeConnection();
            }
            return didDelete;
        }
    }
}
