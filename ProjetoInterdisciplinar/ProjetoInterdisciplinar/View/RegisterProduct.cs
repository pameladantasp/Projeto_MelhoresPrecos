using ProjetoInterdisciplinar.VO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterProduct : Form
    {
        private CategoryVO categoryVO;
        private SupermarketVO supermarketVO;
        private Thread thread;

        public RegisterProduct()
        {
            InitializeComponent();
            categoryVO = new CategoryVO();
            supermarketVO = new SupermarketVO();
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadSupermarket();
        }

        private void loadCategory()
        {
            try
            {
                DataTable dataTable = categoryVO.selectCategory();
                if (dataTable.Rows.Count > 0)
                {
                    cbCategory.DataSource = dataTable;
                    cbCategory.ValueMember = dataTable.Columns[0].ColumnName;
                    cbCategory.DisplayMember = dataTable.Columns[1].ColumnName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadSupermarket()
        {
            try
            {
                DataTable dataTable = supermarketVO.selectSupermarket();
                if (dataTable.Rows.Count > 0)
                {
                    cbSupermarket.DataSource = dataTable;
                    cbSupermarket.ValueMember = dataTable.Columns[0].ColumnName;
                    cbSupermarket.DisplayMember = dataTable.Columns[1].ColumnName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void linkLbSupermarket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            thread = new Thread(openRegisterSupermarket);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openRegisterSupermarket()
        {
            Application.Run(new RegisterSupermarket());
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openFinallyScreen);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openFinallyScreen()
        {
            Application.Run(new FinallyView());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openRegisterProductScreen);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); 
        }

        private void openRegisterProductScreen()
        {
            Application.Run(new RegisterProduct());
        }
    }
}
