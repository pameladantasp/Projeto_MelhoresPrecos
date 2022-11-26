using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;

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
    }
}
