using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;
using ProjetoInterdisciplinar.Model;

namespace ProjetoInterdisciplinar.View
{
    public partial class HomeView : Form
    {
        private HomeController homeController;
        public HomeView()
        {
            InitializeComponent();
            homeController = new HomeController();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            homeController.populateItems(flowLayoutPanel1);
            lbUserName.Text = Customer.shared.name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            homeController.closeView(this);
            homeController.navigateToMainView();
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            homeController.closeView(this);
            homeController.navigateToRegisterProductView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length >= 3)
            {
                flowLayoutPanel1.Controls.Clear();
                homeController.search(flowLayoutPanel1, txtSearch.Text);
            }
            else if(txtSearch.Text == "")
            {
                flowLayoutPanel1.Controls.Clear();
                homeController.populateItems(flowLayoutPanel1);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            homeController.setPlaceholder(txtSearch);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            homeController.removePlaceholder(txtSearch);
        }
    }
}
