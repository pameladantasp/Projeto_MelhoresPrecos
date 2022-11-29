using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Model;
using System;
using System.Net;
using System.Windows.Forms;

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

        }
    }
}
