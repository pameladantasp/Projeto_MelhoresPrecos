using Correios;
using System;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterSupermarket : Form
    {
        public RegisterSupermarket()
        {
            InitializeComponent();
        }

        private void callPostalCodeService()
        {
            localizePostalCode();
        }

        private void localizePostalCode()
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

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            callPostalCodeService();
        }
    }
}
