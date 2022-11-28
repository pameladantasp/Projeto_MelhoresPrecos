using System;
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
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                ErrorResult result = loginController.userSignIn(txtEmail, txtPassword);

                if (result == ErrorResult.success)
                {
                    loginController.closeView(this);
                    loginController.navigateToHomeView();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos por favor!", "Os campos estao vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginController.closeView(this);
            loginController.navigateToRetrievePasswordView();
        }
    }
}
