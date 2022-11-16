using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Model;
using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Helpers;
using System.Drawing;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CustomerDAO
    {
        private Database database;
        public bool exist;
        public string message;
        public CustomerDAO()
        {
            database = new Database();
        }

        public bool verifyLogin(string login, string password)
        {
            try
            {
                database.selectLoginQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@login", login);
                database.command.Parameters.AddWithValue("password", password);
                database.select();
                exist = true;
            }
            catch(MySqlException)
            {
                this.message = "Erro com o Banco de Dados!!";
            }
            return exist;
        }
        public void insertData(Customer customer)
        {
            try
            {
                int idAddress = database.getNextId("address");
                
                AddressDAO addressDAO = new AddressDAO();
                bool didInsert = addressDAO.insertData(customer.address);

                if (didInsert)
                {
                    database.setInsertCustomerQueryString();
                    database.configureMySqlCommand();
                    database.command.Parameters.AddWithValue("@name", customer.name);
                    database.command.Parameters.AddWithValue("@email", customer.email);
                    database.command.Parameters.AddWithValue("@password", customer.password);
                    database.command.Parameters.AddWithValue("@idAddress", idAddress);
                    database.insert();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
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
        public bool delete(int idCustomer)
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
