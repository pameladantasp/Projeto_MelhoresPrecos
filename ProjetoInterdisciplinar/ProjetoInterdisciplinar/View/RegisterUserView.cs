using Correios;
using ProjetoInterdisciplinar.VO;
using System;
using System.Windows.Forms;
using System.Threading;


namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterUserView : Form
    {
        Thread thread;
        private CustomerVO crudVO;

        public RegisterUserView()
        {
            InitializeComponent();
            crudVO = new CustomerVO();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                crudVO.customer.name = txtName.Text.Trim();
                crudVO.customer.email = txtEmail.Text.Trim();
                crudVO.customer.password = txtPassword.Text.Trim();

                crudVO.customer.address.street = txtStreet.Text;
                crudVO.customer.address.number = txtNumber.Text;
                crudVO.customer.address.city = txtCity.Text;
                crudVO.customer.address.state = txtState.Text;
                crudVO.customer.address.postalCode = txtPostalCode.Text;

                crudVO.insertCostumer();
                MessageBox.Show("DEU CERTO INSERT!");

                this.Close();
                thread = new Thread(openFinllayScreen);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openPrincipalScreen);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            callPostalCodeService();
        }

        private void callPostalCodeService()
        {
            localizePostalCode();
        }

            private void localizePostalCode()
        {
            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                MessageBox.Show("O campo CEP esta vazio", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var response = correiosApi.consultaCEP(txtPostalCode.Text);

                    if (response is null)
                    {
                        MessageBox.Show("CEP nao encontrado", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    txtState.Text = response.uf;
                    txtStreet.Text = response.end;
                    txtCity.Text = response.cidade;
                }
                catch (Exception error)
                {
                    MessageBox.Show($"{error.Message}");
                }
            }
        }

        private void openFinllayScreen(object obj)
        {
            Application.Run(new FinallyView());
        }

        private void openPrincipalScreen(object obj)
        {
            Application.Run(new PrincipalView());
        }
    }
}
