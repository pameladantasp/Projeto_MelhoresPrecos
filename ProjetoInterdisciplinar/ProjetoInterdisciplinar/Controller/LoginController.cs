using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using static ProjetoInterdisciplinar.Helpers.Enums;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar
{
    internal class LoginController
    {
        Thread t1;

        public void navigateToRegisterUserView()
        {
            setThread(new Thread(openRegisterUserScreen));
        }

        public void navigateToHomeView()
        {
            setThread(new Thread(openHomeScreen));
        }

        public void navigateToRetrievePasswordView() 
        {
            setThread(new Thread(openRetrievePasswordScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openRegisterUserScreen(object obj)
        {
            Application.Run(new RegisterUserView());
        }

        private void openHomeScreen(object obj)
        {
            Application.Run(new HomeView());
        }

        private void openRetrievePasswordScreen(object obj)
        {
            Application.Run(new RetrievePasswordView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }

        public ErrorResult userSignIn(TextBox email, TextBox password)
        {
            Customer customer = new Customer();
            customer.email = email.Text.Trim();
            customer.password = password.Text;
            ErrorResult result = customer.login();
            showMessageBox(result);

            return result;
        }

        private void showMessageBox(ErrorResult result)
        {
            switch (result)
            {
                case ErrorResult.success:
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);          
                    break;

                case ErrorResult.invalide:
                    MessageBox.Show("Login não encontrado", "Verifique login e senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case ErrorResult.failure:
                    MessageBox.Show("Falha de internet", "Verifique sua internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Falha no servidor", "Tente mais tarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
