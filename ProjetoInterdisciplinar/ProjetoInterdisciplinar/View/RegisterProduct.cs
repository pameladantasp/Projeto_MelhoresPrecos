using ProjetoInterdisciplinar.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterProduct : Form
    {
        private CategoryVO categoryVO;
        private SupermarketVO supermarketVO;

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
    }
}
