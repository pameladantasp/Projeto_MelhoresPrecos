using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.View;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.Controller
{
    internal class RegisterProductController
    {
        Thread t1;

        public void navigateToRegisterSupermarketView()
        {
            setThread(new Thread(openRegisterSupermarketScreen));
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

        private void openRegisterSupermarketScreen(object obj)
        {
            Application.Run(new RegisterSupermarketView());
        }

        private void openHomeScreen(object obj)
        {
            Application.Run(new HomeView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }

        public void fetch(ModelInterface model, ComboBox comboBox)
        {
            try
            {
                DataTable dataTable = model.select();

                if (dataTable.Rows.Count > 0)
                {
                    comboBox.DataSource = dataTable;
                    comboBox.ValueMember = dataTable.Columns[0].ColumnName;
                    comboBox.DisplayMember = dataTable.Columns[1].ColumnName;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
