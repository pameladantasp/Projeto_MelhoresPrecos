using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Model;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterProductView : Form
    {
        private RegisterProductController registerProductController;

        public RegisterProductView()
        {
            InitializeComponent();
            registerProductController = new RegisterProductController();
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            registerProductController.fetch(new Category(), cbCategory);
            registerProductController.fetch(new Supermarket(), cbSupermarket);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void linkLbSupermarket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerProductController.closeView(this);
            registerProductController.navigateToRegisterSupermarketView();
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterProduct registerProduct = new RegisterProduct();
                registerProduct.price = float.Parse(txtPrice.Text.Trim());
                registerProduct.dateRegister = DateTime.Parse(txtDate.Text);

                registerProduct.product = new Product();
                registerProduct.product.name = txtDescription.Text.Trim();

                registerProduct.product.category = new Category();
                registerProduct.product.category.idCategory = Int32.Parse(cbCategory.SelectedValue.ToString());
                registerProduct.product.category.type = cbCategory.Text;

                registerProduct.supermarket = new Supermarket();
                registerProduct.supermarket.idSupermarket = Int32.Parse(cbSupermarket.SelectedValue.ToString());
                registerProduct.supermarket.name = cbSupermarket.Text;

                registerProduct.customer = Customer.shared;

                ErrorResult result = registerProduct.insert();
                if(result == ErrorResult.success)
                {
                    registerProductController.showMessageBox(result);
                    registerProductController.closeView(this);
                    registerProductController.navigateToHomeView();
                }
                else
                {
                    registerProductController.showMessageBox(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            } 
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // TODO: It will be defined
        }
    }
}
