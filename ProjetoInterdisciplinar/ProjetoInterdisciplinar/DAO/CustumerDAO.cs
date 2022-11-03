using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Model;
using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Helpers;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CustumerDAO
    {
        private Database database;
        public CustumerDAO()
        {
            database = new Database();
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
        public bool delete(int idConsumer)
        {
            bool didDelete;

            try
            {
                database.setDeleteCustomerQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idConsumer", idConsumer);
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
