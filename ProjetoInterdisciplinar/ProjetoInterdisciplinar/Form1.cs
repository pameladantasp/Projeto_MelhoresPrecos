using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.VO;

namespace ProjetoInterdisciplinar
{
    public partial class Form1 : Form
    {
        private Database database;
        private CrudVO crudVO;

        public Form1()
        {
            InitializeComponent();
            crudVO = new CrudVO();
        }
        private void loadData()
        {
            database = new Database();

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                crudVO.customer.name = txtName.Text;
                crudVO.customer.email = txtEmail.Text;
                crudVO.insertCostumer();
                MessageBox.Show("DEU CERTO INSERT!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            { 
                bool didDelete = crudVO.deleteCostumer();

                if (didDelete)
                {
                    MessageBox.Show("DEU CERTO, DELETADO!");
                }
                else
                {
                    MessageBox.Show("POR FAVOR, TENTE MAIS TARDE!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
