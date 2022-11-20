using System;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoInterdisciplinar.View
{
    public partial class HomeView : Form
    {
        Thread thread;
        public HomeView()
        {
            InitializeComponent();
        }

        private void FinallyView_Load(object sender, EventArgs e)
        {
            poplateItems();
        }

        private void poplateItems()
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openPrincipalScreen);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openPrincipalScreen(object obj)
        {
            Application.Run(new MainView());
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            thread= new Thread(openRegisterProductScreen);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openRegisterProductScreen()
        {
            Application.Run(new RegisterProductView());
        }
    }
}
