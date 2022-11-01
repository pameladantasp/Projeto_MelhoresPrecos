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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                crudVO.customer.name = txtName.Text;
                crudVO.customer.email = txtEmail.Text;
                crudVO.customer.password = txtPassword.Text;

                crudVO.customer.address.street = "Rua Antonio Miguel";
                crudVO.customer.address.number = "77";
                crudVO.customer.address.city = "Campinas";
                crudVO.customer.address.state = "SP";
                crudVO.customer.address.postalCode = "00000-000";

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
