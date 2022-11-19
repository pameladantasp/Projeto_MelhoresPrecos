using Correios;
using System;
using System.Windows.Forms;
using System.Threading;
using ProjetoInterdisciplinar.Controller;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterSupermarketView : Form
    {
        private RegisterSupermarketController registerSupermarketController;
        public RegisterSupermarketView()
        {
            InitializeComponent();
            registerSupermarketController = new RegisterSupermarketController();
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            registerSupermarketController.localizePostalCode(txtPostalCode, txtState, txtStreet, txtCity);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerSupermarketController.navigateToRegisterProductView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerSupermarketController.navigateToRegisterProductView();
        }
    }
}
