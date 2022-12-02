using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using System;
using System.Threading;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.Controller
{
    internal class ConfigurationController
    {
        Thread t1;

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

        private void openHomeScreen(object obj)
        {
            Application.Run(new HomeView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }

        public ErrorResult update(Customer customer)
        {
            ErrorResult result = ErrorResult.invalide;

            try
            {
                result = customer.update();
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
                    MessageBox.Show("Atualizacao com sucesso", "Deu certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case ErrorResult.invalide:
                    MessageBox.Show("Atualizacap com sucesso", "Deu certo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case ErrorResult.failure:
                    MessageBox.Show("Tente novamente", "Falha na atualizacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

    }
}