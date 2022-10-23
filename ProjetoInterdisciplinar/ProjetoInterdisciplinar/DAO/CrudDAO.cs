using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CrudDAO
    {
        private Helpers.Database database;
        private MySqlConnection connetion;

        public CrudDAO()
        {

        }

        public void InsertDate(string nameConsumer, string emailConsumer)
        {
            connetion = new MySqlConnection();
            database = new Helpers.Database();
            connetion.ConnectionString = connetion.ConnectionString;
            string query = "INSERT INTO Consumer (nameConsumer, emailConsumer)";
            query += ("?nameConsumer, ?emailConsumer");

            try
            {
                connetion.Open();
                MySqlCommand command = new MySqlCommand(query, connetion);
                command.Parameters.AddWithValue("?nameConsumer", nameConsumer);
                command.Parameters.AddWithValue("?emailConsumer", emailConsumer);
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
    }
}
