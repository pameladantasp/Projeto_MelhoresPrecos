using Correios;
using System;
using System.Windows.Forms;
using System.Threading;
using ProjetoInterdisciplinar.Controller;
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
            else if(result == ErrorResult.invalide)
            {
                registerUserController.closeView(this);
                registerUserController.navigateToLoginView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerUserController.closeView(this);
            registerUserController.navigateToMainView();
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            registerUserController.localizePostalCode(txtPostalCode, txtState, txtStreet, txtCity);
        }
    }
}
