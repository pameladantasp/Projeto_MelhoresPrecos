using System;
using System.Data;
using System.Windows.Forms;
using ProjetoInterdisciplinar.VO;

namespace ProjetoInterdisciplinar
{
    public partial class RegisterView : Form
    {
        private CustomerVO crudVO;

        public RegisterView()
        {
            InitializeComponent();
            crudVO = new CustomerVO();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                crudVO.customer.name = txtName.Text;
                crudVO.customer.email = txtEmail.Text;
                crudVO.customer.password = txtPassword.Text;

                crudVO.customer.address.Street = txtStreet.Text;
                crudVO.customer.address.Number = txtNumber.Text;
                crudVO.customer.address.City = txtCity.Text;
                crudVO.customer.address.State = txtState.Text;
                crudVO.customer.address.PostalCode = txtPostalCode.Text;

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
