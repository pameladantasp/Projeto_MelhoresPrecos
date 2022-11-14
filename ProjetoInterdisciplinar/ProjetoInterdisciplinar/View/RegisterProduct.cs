using ProjetoInterdisciplinar.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class RegisterProduct : Form
    {
        private CategoryVO crudVO;

        public RegisterProduct()
        {
            InitializeComponent();
            crudVO = new CategoryVO();
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void loadCategory()
        {
            try
            {
                DataTable dataTable = crudVO.selectCategory();
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

    }
}
