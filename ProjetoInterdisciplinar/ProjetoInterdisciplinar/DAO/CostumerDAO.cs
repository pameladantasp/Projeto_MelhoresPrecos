using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Model;
using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Helpers;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CostumerDAO
    {
        private Database database;
        public CostumerDAO()
        {
            database = new Database();
        }
        public void insertData(Customer customer)
        {
            try
            {
                int idAddress = database.getNextId("Address");

                database.setInsertCustomerQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@nameConsumer", customer.name);
                database.command.Parameters.AddWithValue("@emailConsumer", customer.email);
                database.command.Parameters.AddWithValue("@password", customer.password);
                database.command.Parameters.AddWithValue("@idAddress", idAddress);
                bool didInsert = database.insert();
                if (didInsert)
                {
                    AddressDAO addressDAO = new AddressDAO();
                    addressDAO.insertData(customer.address);
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
        public void updateCostumerData(Customer customer)
        {
            try
            {
                database.setUpdateQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@nameConsumer", customer.name);
                database.command.Parameters.AddWithValue("@emailConsumer", customer.email);
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
        public bool deleteCostumer(int idConsumer)
        {
            bool didDelete;

            try
            {
                database.setDeleteQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("?idConsumer", idConsumer);
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
            //return true;
        }
    }
}
