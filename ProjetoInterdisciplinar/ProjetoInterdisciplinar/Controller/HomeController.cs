using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class HomeController
    {
        Thread t1;

        public void navigateToMainView()
        {
            setThread(new Thread(openMainScreen));
        }
        public void navigateToRegisterProductView()
        {
            setThread(new Thread(openRegisterProductScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openMainScreen(object obj)
        {
            Application.Run(new MainView());
        }
        private void openRegisterProductScreen()
        {
            Application.Run(new RegisterProductView());
        }

        public void closeView(Form form)
        {
            form.Close();
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
