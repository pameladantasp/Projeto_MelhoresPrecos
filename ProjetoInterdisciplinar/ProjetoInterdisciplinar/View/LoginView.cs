using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoInterdisciplinar.View
{
    public partial class LoginView : Form
    {
        Thread t1;
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openWindowRegisterUser);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openWindowRegisterUser (object obj)
        {
            Application.Run(new RegisterUserView());
        }
    }
}
