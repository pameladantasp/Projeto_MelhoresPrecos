﻿using Correios;
using ProjetoInterdisciplinar.VO;
using System;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterUserView : Form
    {
        private CustomerVO crudVO;

        public RegisterUserView()
        {
            InitializeComponent();
            crudVO = new CustomerVO();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                crudVO.customer.name = txtName.Text;
                crudVO.customer.email = txtEmail.Text;
                crudVO.customer.password = txtPassword.Text;

                crudVO.customer.address.street = txtStreet.Text;
                crudVO.customer.address.number = txtNumber.Text;
                crudVO.customer.address.city = txtCity.Text;
                crudVO.customer.address.state = txtState.Text;
                crudVO.customer.address.postalCode = txtPostalCode.Text;

                crudVO.insertCostumer();
                MessageBox.Show("DEU CERTO INSERT!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                bool didDelete = crudVO.deleteCostumer();

                if (didDelete)
                {
                    MessageBox.Show("DEU CERTO, DELETADO!");
                }
                else
                {
                    MessageBox.Show("POR FAVOR, TENTE MAIS TARDE!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            callPostalCodeService();
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
    }
}
