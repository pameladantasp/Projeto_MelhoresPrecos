using Correios;
using ProjetoInterdisciplinar.Model;
using System;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Helpers
{
    internal class ApiPostalCode
    {
        private CorreiosApi correiosApi;
        private Address address;

        public Address localizePostalCode(string txtPostalCode)
        {
            if (!string.IsNullOrEmpty(txtPostalCode))
            {
                try
                {
                    correiosApi = new CorreiosApi();
                    var response = correiosApi.consultaCEP(txtPostalCode);

                    if (response != null)
                    {
                        address = new Address();
                        address.state = response.uf;
                        address.district = response.bairro;
                        address.street = response.end;
                        address.city = response.cidade;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, informe um CEP valido", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Api correios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe um CEP valido", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return address;
        }
    }
}
