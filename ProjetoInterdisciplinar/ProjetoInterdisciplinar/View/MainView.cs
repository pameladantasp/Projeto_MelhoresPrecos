using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
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
            mainController.navigateToLoginView();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            mainController.navigateToRegisterUserView();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            mainController.setPlaceholder(txtSearch);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            mainController.removePlaceholder(txtSearch);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            mainController.populateItems(flowLayoutPanel1);
        }
    }
}