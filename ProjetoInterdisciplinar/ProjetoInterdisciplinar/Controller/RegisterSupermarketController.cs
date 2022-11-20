using ProjetoInterdisciplinar.View;
using System.Threading;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.Controller
{
    internal class RegisterSupermarketController
    {
        Thread t1;

        public void navigateToRegisterProductView()
        {
            setThread(new Thread(openRegisterProductScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openRegisterProductScreen(object obj)
        {
            Application.Run(new RegisterProductView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }
        public void showMessageBox(ErrorResult result)
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
