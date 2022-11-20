using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using ProjetoInterdisciplinar.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class RegisterProductController
    {
        Thread t1;

        public void navigateToRegisterSupermarketView()
        {
            setThread(new Thread(openRegisterSupermarketScreen));
        }

        public void navigateToHomeView()
        {
            setThread(new Thread(openHomeScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openRegisterSupermarketScreen(object obj)
        {
            Application.Run(new RegisterSupermarketView());
        }

        private void openHomeScreen(object obj)
        {
            Application.Run(new HomeView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }

        public void fetch(ModelInterface model, ComboBox comboBox)
        {
            try
            {
                DataTable dataTable = model.select();

                if (dataTable.Rows.Count > 0)
                {
                    comboBox.DataSource = dataTable;
                    comboBox.ValueMember = dataTable.Columns[0].ColumnName;
                    comboBox.DisplayMember = dataTable.Columns[1].ColumnName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
