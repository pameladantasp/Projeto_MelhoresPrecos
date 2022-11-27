using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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

        public void removePlaceholder(TextBox txtSearch)
        {
            if (txtSearch.Text == "Busque por um produto...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        public void setPlaceholder(TextBox txtSearch)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Busque por um produto...";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        public void populateItems(FlowLayoutPanel flowPanel)
        {
            RegisterProduct registerProduct = new RegisterProduct();
            List<RegisterProduct> registerProductList = registerProduct.select();

            ListItem[] listItems = new ListItem[registerProductList.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].UserName = registerProductList[i].customer.name;
                listItems[i].DescriptionProduct = registerProductList[i].product.name;
                listItems[i].SupermarketName = registerProductList[i].supermarket.name;
                listItems[i].Price = registerProductList[i].price.ToString();

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
