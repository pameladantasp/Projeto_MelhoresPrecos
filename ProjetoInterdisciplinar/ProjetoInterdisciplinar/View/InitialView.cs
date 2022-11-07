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
    public partial class InitialView : Form
    {
        Thread t2;
        Thread t3;
        public InitialView()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(openLoginView);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void openLoginView(object obj)
        {
            Application.Run(new LoginView());
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(openRegisterUserView);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void openRegisterUserView(object obj)
        {
            Application.Run(new RegisterUserView());
        }
    }
}
