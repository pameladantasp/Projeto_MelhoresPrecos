using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Model
{
    internal class Category : ModelInterface
    {
        public int idCategory { get; set; }
        public string type { get; set; }

        private CategoryDAO dao;

        public Category()
        {
            dao = new CategoryDAO();
        }
        
        public DataTable select()
        {
            return dao.selectData();
        }
    }
}
