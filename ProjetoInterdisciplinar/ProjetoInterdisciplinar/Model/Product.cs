using ProjetoInterdisciplinar.DAO;

namespace ProjetoInterdisciplinar.Model
{
    internal class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public Category category { get; set; }

        private ProductDAO dao;

        public Product()
        {
            dao = new ProductDAO();
        }
        public void insert()
        {
            dao.insertData(this);
        }
        public void update()
        {
            dao.updateData(this);
        }
        public bool delete()
        {
            return dao.delete(this.idProduct);
        }
    }
}
