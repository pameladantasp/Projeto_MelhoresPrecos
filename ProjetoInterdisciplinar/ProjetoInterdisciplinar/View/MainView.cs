using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Controller;

namespace ProjetoInterdisciplinar.View
{
    public partial class MainView : Form
    {
       private MainController mainController;

        public MainView()
        {
            InitializeComponent();
            mainController = new MainController();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            mainController.closeView(this);
            mainController.navigateToLoginView();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            mainController.closeView(this);
            mainController.navigateToRegisterUserView();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            mainController.populateItems(flowLayoutPanel1);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            mainController.setPlaceholder(txtSearch);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            mainController.removePlaceholder(txtSearch);
        }
    }
}