using ProjetoInterdisciplinar.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class MainController
    {
        Thread t1;

        public void navigateToRegisterUserView()
        {
            setThread(new Thread(openRegisterUserScreen));
        }

        public void navigateToLoginView()
        {
            setThread(new Thread(openLoginScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openRegisterUserScreen(object obj)
        {
            Application.Run(new RegisterUserView());
        }

        private void openLoginScreen(object obj)
        {
            Application.Run(new LoginView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }

        public void setPlaceholder(TextBox txtSearch)
        {
            if (txtSearch.Text == "Busque por um produto...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        public void removePlaceholder(TextBox txtSearch)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Busque por um produto...";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        public void populateItems(FlowLayoutPanel flowPanel)
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].UserName = "Pamela Dantas";
                listItems[i].DescriptionProduct = "Refrigerante Coca Cola Pet 3L";
                listItems[i].SupermarketName = "Supermercado Enxuto";
                listItems[i].Price = "R$ 9.99";

                if (flowPanel.Controls.Count < 0)
                {
                    flowPanel.Controls.Clear();
                }
                else
                {
                    flowPanel.Controls.Add(listItems[i]);
                }
            }
        }
    }
}
