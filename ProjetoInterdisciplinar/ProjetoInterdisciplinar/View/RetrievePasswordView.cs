using ProjetoInterdisciplinar.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class RetrievePasswordView : Form
    {
        private RetrievePasswordController retrievePasswordController;
        public RetrievePasswordView()
        {
            InitializeComponent();
            retrievePasswordController = new RetrievePasswordController();
        }

        private void RetrievePasswordView_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnRetrievePassword_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "")
            {
                MessageBox.Show("Enviaremos um email com as instruções de como redefinir sua senha!", "Refenir senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor preencha o campo em branco!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            retrievePasswordController.closeView(this);
            retrievePasswordController.navigateToLoginView();
        }
    }
}
