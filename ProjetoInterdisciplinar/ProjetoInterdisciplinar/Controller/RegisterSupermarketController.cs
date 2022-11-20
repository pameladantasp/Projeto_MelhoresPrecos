﻿using Correios;
using ProjetoInterdisciplinar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class RegisterSupermarketController: Form
    {
        Thread t1;

        public void navigateToRegisterProductView()
        {
            setThread(new Thread(openRegisterProductScreen));
        }

        private void setThread(Thread thread)
        {
            this.Close();
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openRegisterProductScreen(object obj)
        {
            Application.Run(new RegisterProductView());
        }

        public void localizePostalCode(
            MaskedTextBox txtPostalCode,
            TextBox txtState,
            TextBox txtStreet,
            TextBox txtCity
        ) {
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
    }
}