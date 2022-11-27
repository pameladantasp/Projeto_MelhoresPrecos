using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterUserView : Form
    {
        private RegisterUserController registerUserController;

        public RegisterUserView()
        {
            InitializeComponent();
            registerUserController = new RegisterUserController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtConfPassword.Text != "" && txtPostalCode.Text != "")
            {
                Customer customer = new Customer();
                customer.name = txtName.Text.Trim();
                customer.email = txtEmail.Text.Trim();
                customer.password = txtPassword.Text.Trim();

                customer.address = new Address();
                customer.address.street = txtStreet.Text;
                customer.address.number = txtNumber.Text;
                customer.address.city = txtCity.Text;
                customer.address.state = txtState.Text;
                customer.address.postalCode = txtPostalCode.Text;

                ErrorResult result = registerUserController.userSignUp(customer);
                if (result == ErrorResult.success)
                {
                    registerUserController.closeView(this);
                    registerUserController.navigateToHomeView();
                }
                else if (result == ErrorResult.invalide)
                {
                    registerUserController.closeView(this);
                    registerUserController.navigateToLoginView();
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerUserController.closeView(this);
            registerUserController.navigateToMainView();
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            ApiPostalCode apiPostalCode = new ApiPostalCode();

            Address address = apiPostalCode.localizePostalCode(txtPostalCode.Text);
            if(address != null)
            {

                txtState.Text = address.state;
                txtStreet.Text = address.street;
                txtCity.Text = address.city;
            }
        }

        private void txtConfPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtConfPassword.Text == txtPassword.Text)
            {
                lbConfPassword.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbConfPassword.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
