using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Helpers;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CrudDAO
    {
        private Database database;
        private MySqlConnection connetion;

        public CrudDAO()
        {

        }

        public void insertCostumerData(Customer customer)
        {
            connetion = new MySqlConnection();
            database = new Database();
            connetion.ConnectionString = database.getConnectionString();
            String query = "INSERT INTO Consumer (nameConsumer, emailConsumer) VALUES";
            query += "(?nameConsumer, ?emailConsumer)";

            try
            {
                connetion.Open();
                MySqlCommand command = new MySqlCommand(query, connetion);
                command.Parameters.AddWithValue("?nameConsumer", customer.name);
                command.Parameters.AddWithValue("?emailConsumer", customer.email);
                command.ExecuteNonQuery();
                command.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connetion.Close();
            }
        }

        public void updateCostumerData(Customer customer)
        {
            connetion = new MySqlConnection();
            database = new Database();
            connetion.ConnectionString = database.getConnectionString();
            string query = "UPDATE Comsumer SET nameConsumer = ?nameConsumer, emailConsumer = ?emailConsumer " +
                "WHERE idConsumer = ?idConsumer";

            try
            {
                connetion.Open();
                MySqlCommand command = new MySqlCommand(query,connetion);
                command.Parameters.AddWithValue("idConsumer", customer.idCustomer);
                command.Parameters.AddWithValue("nameConsumer", customer.name);
                command.Parameters.AddWithValue("emailConsumer", customer.email);
                command.ExecuteNonQuery();
                command.Dispose();

                
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connetion.Close();
            }
        }
        public bool deleteCostumer(int idConsumer)
        {
            connetion = new MySqlConnection();
            database = new Database();
            connetion.ConnectionString = database.getConnectionString();
            bool didDelete;

            string query = "DELETE FROM Consumer ";
            query += "WHERE idConsumer = ?idConsumer";
            try
            {
                connetion.Open();
                MySqlCommand cmd = new MySqlCommand(query, connetion);
                cmd.Parameters.AddWithValue("?idConsumer", idConsumer);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                didDelete = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                didDelete = false;
            }
            finally
            {
                connetion.Close();
            }
            return didDelete;
        }
    }
}
