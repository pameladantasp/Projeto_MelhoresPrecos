using ProjetoInterdisciplinar.VO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class LoginView : Form
    {
        Thread t1;
        private CustomerVO customerVO;
        public LoginView()
        {
            InitializeComponent();
            customerVO = new CustomerVO();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openRegisterUserScreen);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openRegisterUserScreen(object obj)
        {
            Application.Run(new RegisterUserView());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            customerVO.customer.email = txtEmail.Text.Trim();
            customerVO.customer.password = txtPassword.Text;

            switch (customerVO.loginCustomer())
            {
                case LoginResult.success:
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    t1 = new Thread(openFinallyScreen);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    break;

                case LoginResult.invalide:
                    MessageBox.Show("Login não encontrado", "Verifique login e senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case LoginResult.failure:
                    MessageBox.Show("Falha de internet", "Verifique sua internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Falha no servidor", "Tente mais tarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

      
        }

        private void openFinallyScreen(object obj)
        {
            Application.Run(new FinallyView());
        }
    }
}
