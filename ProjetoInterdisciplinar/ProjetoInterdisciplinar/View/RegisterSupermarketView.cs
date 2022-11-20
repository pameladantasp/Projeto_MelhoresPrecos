using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Model;

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
            Supermarket supermarket = new Supermarket();
            supermarket.name = txtName.Text;

            supermarket.address = new Address();
            supermarket.address.street = txtStreet.Text;
            supermarket.address.number = txtNumber.Text;
            supermarket.address.city = txtCity.Text;
            supermarket.address.state = txtState.Text;
            supermarket.address.postalCode = txtPostalCode.Text;

            registerSupermarketController.supermarketInsert(supermarket);
            registerSupermarketController.closeView(this);
            registerSupermarketController.navigateToRegisterProductView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerSupermarketController.closeView(this);
            registerSupermarketController.navigateToRegisterProductView();
        }
    }
}
