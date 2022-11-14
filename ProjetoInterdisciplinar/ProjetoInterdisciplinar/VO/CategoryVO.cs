using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.VO
{
    internal class CategoryVO
    {
        private CategoryDAO dao;
        public Category category;

        public CategoryVO()
        {
            category = new Category(); 
            dao = new CategoryDAO();
        }

        public DataTable selectCategory()
        {
            return dao.selectData(category);
        }
    }
}
