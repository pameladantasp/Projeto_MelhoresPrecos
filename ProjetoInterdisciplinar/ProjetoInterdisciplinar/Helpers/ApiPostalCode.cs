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
            try
            {
                if (!string.IsNullOrEmpty(txtPostalCode))
                {
                    correiosApi = new CorreiosApi();
                    var response = correiosApi.consultaCEP(txtPostalCode);

                    if (response != null)
                    {
                        address = new Address();
                        address.state = response.uf;
                        address.street = response.end;
                        address.city = response.cidade;
                    }
                    else
                    {
                        MessageBox.Show("CEP nao encontrado", "Atencao!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("O campo CEP esta vazio", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            return address;
        }
    }
}
