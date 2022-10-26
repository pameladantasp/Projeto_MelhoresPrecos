using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoInterdisciplinar
{
    public partial class Form1 : Form
    {
        private Helpers.Database database;
        private VO.CrudVO crudVO;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadedDate()
        {
            database = new Helpers.Database();

            string connetionString = database.getConnectionString();
            string query = "SELECT * FROM Consumer";
            using (MySqlConnection connection = new MySqlConnection(connetionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            crudVO = new VO.CrudVO();
            try
            {
                crudVO.nameConsumer = txtName.Text;
                crudVO.emailConsumer = txtEmail.Text;
                MessageBox.Show("DEU CERTO INSERT!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
