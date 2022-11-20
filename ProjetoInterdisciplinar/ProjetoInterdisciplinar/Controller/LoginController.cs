using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        public void closeView(Form form)
        {
            form.Close();
        }

        public LoginResult userSignIn(TextBox email, TextBox password)
        {
            Customer customer = new Customer();
            customer.email = email.Text.Trim();
            customer.password = password.Text;
            LoginResult result = customer.login();
            showMessageBox(result);

            return result;
        }

        private void showMessageBox(LoginResult result)
        {
            switch (result)
            {
                case LoginResult.success:
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Warning);          
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
    }
}
