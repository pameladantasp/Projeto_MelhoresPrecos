using ProjetoInterdisciplinar.Controller;
using System;
using System.Threading;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.View
{
    public partial class LoginView : Form
    {
        private LoginController loginController;

        public LoginView()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            loginController.closeView(this);
            loginController.navigateToRegisterUserView();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ErrorResult result = loginController.userSignIn(txtEmail, txtPassword);

            if ( result == ErrorResult.success) {
                loginController.closeView(this);
                loginController.navigateToHomeView();
            }
        }
    }
}
