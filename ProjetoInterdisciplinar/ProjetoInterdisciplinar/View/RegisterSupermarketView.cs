using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using static ProjetoInterdisciplinar.Helpers.Enums;

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
            ApiPostalCode apiPostalCode =  new ApiPostalCode();
            Address address = apiPostalCode.localizePostalCode(txtPostalCode.Text);

            if(address != null)
            {
                txtState.Text = address.state;
                txtStreet.Text = address.street;
                txtDistrict.Text = address.district;
                txtCity.Text = address.city;
            }
            else
            {
                MessageBox.Show("Por favor preencha seu CEP!", "O CEP esta vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPostalCode.Text != "")
            {
                Supermarket supermarket = new Supermarket();
                supermarket.name = txtName.Text.Trim();

                supermarket.address = new Address();
                supermarket.address.street = txtStreet.Text;
                supermarket.address.district = txtDistrict.Text;
                supermarket.address.number = txtNumber.Text;
                supermarket.address.city = txtCity.Text;
                supermarket.address.state = txtState.Text;
                supermarket.address.postalCode = txtPostalCode.Text;

                ErrorResult result = supermarket.insert();
                if (result == ErrorResult.success)
                {
                    registerSupermarketController.showMessageBox(result);
                    registerSupermarketController.closeView(this);
                    registerSupermarketController.navigateToRegisterProductView();
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos vazios!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerSupermarketController.closeView(this);
            registerSupermarketController.navigateToRegisterProductView();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
