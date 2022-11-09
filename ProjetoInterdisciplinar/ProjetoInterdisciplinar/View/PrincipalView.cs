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
    public partial class PrincipalView : Form
    {
        Thread t2;
        Thread t3;
        public PrincipalView()
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Busque por um produto...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if( txtSearch.Text == "")
            {
                txtSearch.Text = "Busque por um produto...";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void PrincipalView_Load(object sender, EventArgs e)
        {

        }

        private void poplateItems()
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i < listItems.Length; i++) {
                listItems[i]
            }
        }
    }
}
