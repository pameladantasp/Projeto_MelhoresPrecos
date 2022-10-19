using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoInterdisciplinar
{
    public partial class Form1 : Form
    {
        MySqlConnection connention;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string datasource = "datasource=sql10.freemysqlhosting.net;username=sql10527490;password=DRUcpZMmgz;database=sql10527490";
                // Criar conexao com MySQL
                connention = new MySqlConnection(datasource);


                string query = "INSERT INTO Consumer (nameConsumer, emailConsumer) " +
                               "VALUES ('" + txtName.Text + "', '" + txtEmail.Text + "')";

                // Executar comando Insert
                MySqlCommand command = new MySqlCommand(query, connention);
                connention.Open();
                command.ExecuteReader();

                MessageBox.Show("Deu tudo certo, Inserido");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connention.Close();
            }
        }
    }
}
