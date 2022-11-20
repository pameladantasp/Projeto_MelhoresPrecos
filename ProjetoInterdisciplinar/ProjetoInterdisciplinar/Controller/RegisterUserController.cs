using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using static ProjetoInterdisciplinar.Helpers.Enums;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class RegisterUserController
    {
        Thread t1;

        public void navigateToMainView()
        {
            setThread(new Thread(openMainScreen));
        }

        public void navigateToHomeView()
        {
            setThread(new Thread(openHomeScreen));
        }

        public void navigateToLoginView()
        {
            setThread(new Thread(openLoginScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openMainScreen(object obj)
        {
            Application.Run(new MainView());
        }

        private void openHomeScreen(object obj)
        {
            Application.Run(new HomeView());
        }

        private void openLoginScreen(object obj)
        {
            Application.Run(new LoginView());
        }
        public void closeView(Form form)
        {
            form.Close();
        }
        public ErrorResult userSignUp(Customer customer)
        {
            ErrorResult result = ErrorResult.invalide;

            try
            {
                result = customer.insert();

                if (result == ErrorResult.success)
                {
                    result = customer.login(); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showMessageBox(result);

            return result;
        }
        private void showMessageBox(ErrorResult result)
        {
            switch (result)
            {
                case ErrorResult.success:
                    MessageBox.Show("Cadastro realizado e logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case ErrorResult.invalide:
                    MessageBox.Show("Cadastro realizado com sucesso", "Faca seu login", MessageBoxButtons.OK);
                    break;

                case ErrorResult.failure:
                    MessageBox.Show("Tente novamente", "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
