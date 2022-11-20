using Correios;
using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        public void closeView(Form form)
        {
            form.Close();
        }
        public void localizePostalCode(
            MaskedTextBox txtPostalCode,
            TextBox txtState,
            TextBox txtStreet,
            TextBox txtCity
        )
        {
            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                MessageBox.Show("O campo CEP esta vazio", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var response = correiosApi.consultaCEP(txtPostalCode.Text);

                    if (response is null)
                    {
                        MessageBox.Show("CEP nao encontrado", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    txtState.Text = response.uf;
                    txtStreet.Text = response.end;
                    txtCity.Text = response.cidade;
                }
                catch (Exception error)
                {
                    MessageBox.Show($"{error.Message}");
                }
            }
        }

        public void userSignUp(Customer customer)
        {
            try
            {
                customer.insert();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
