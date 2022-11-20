using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Helpers;
using System.Data;

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
