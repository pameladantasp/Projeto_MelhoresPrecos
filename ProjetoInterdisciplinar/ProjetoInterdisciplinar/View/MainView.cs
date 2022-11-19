using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoInterdisciplinar.View
{
    public partial class MainView : Form
    {
        Thread t2;
        Thread t3;
        public MainView()
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
            poplateItems();
        }

        private void poplateItems()
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i < listItems.Length; i++) {

                listItems[i] = new ListItem();
                listItems[i].UserName = "Pamela Dantas";
                listItems[i].DescriptionProduct = "Refrigerante Coca Cola Pet 3L";
                listItems[i].SupermarketName = "Supermercado Enxuto";
                listItems[i].Price = "R$ 9.99";

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {

                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }

            }
        }
    }
}