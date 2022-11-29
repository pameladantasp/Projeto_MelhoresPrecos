using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using System.Net;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.View
{
    public partial class ConfigurationView : Form
    {
        private ConfigurationController configurationController;
        private Customer customer;

        public ConfigurationView()
        {
            InitializeComponent();
            configurationController = new ConfigurationController();
            customer = new Customer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            configurationController.closeView(this);
            configurationController.navigateToHomeView();
        }

        private void loadData()
        {
            Customer result =  customer.select();

            txtName.Text = result.name;
            txtEmail.Text = result.email;

            customer.address = new Address();
            txtStreet.Text = result.address.street;
            txtNumber.Text = result.address.number;
            txtDistrict.Text = result.address.district;
            txtCity.Text = result.address.city;
            txtState.Text = result.address.state;
            txtPostalCode.Text = result.address.postalCode;
        }

        private void ConfigurationView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtConfPassword.Text != "" && txtPostalCode.Text != "")
            {
                Customer customer = new Customer();
                customer.name = txtName.Text.Trim();
                customer.email = txtEmail.Text.Trim();
                customer.password = txtPassword.Text.Trim();

                customer.address = new Address();
                customer.address.street = txtStreet.Text;
                customer.address.district = txtDistrict.Text;
                customer.address.number = txtNumber.Text;
                customer.address.city = txtCity.Text;
                customer.address.state = txtState.Text;
                customer.address.postalCode = txtPostalCode.Text;

                configurationController.update(customer);
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            ApiPostalCode apiPostalCode = new ApiPostalCode();
            Address address = apiPostalCode.localizePostalCode(txtPostalCode.Text);

            if (address != null)
            {
                txtState.Text = address.state;
                txtStreet.Text = address.street;
                txtDistrict.Text = address.district;
                txtCity.Text = address.city;
            }
        }

        private void txtConfPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfPassword.Text == txtPassword.Text)
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
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
