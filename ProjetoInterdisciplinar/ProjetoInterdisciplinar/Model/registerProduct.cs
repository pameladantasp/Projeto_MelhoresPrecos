using ProjetoInterdisciplinar.DAO;

namespace ProjetoInterdisciplinar.Model
{
    internal class RegisterProduct
    {
        public int idRegister { get; set; }
        public Customer customer { get; set; }
        public Product  product { get; set; }
        public Supermarket supermarket { get; set; }
        public float price { get; set; }
        public DateTime dateRegister { get; set; }

        private RegisterProductDAO dao;

        public RegisterProduct()
        {
            dao = new RegisterProductDAO();
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
            return dao.deleteData(this.idRegister);
        }
    }
}
