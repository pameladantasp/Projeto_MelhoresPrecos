using ProjetoInterdisciplinar.DAO;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.Model
{
    internal class Customer
    {
        public static readonly Customer shared = new Customer();

        public int idCustomer { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Address address { get; set; }

        private CustomerDAO dao;

        public Customer()
        {
            dao = new CustomerDAO();
        }

        public ErrorResult login()
        {
            return dao.verifyLogin(this);
        }
        public Customer select()
        {
            return dao.selectData();
        }
        public ErrorResult insert()
        {
           return dao.insertData(this);
        }
        public ErrorResult update()
        {
            return dao.updateData(this);
        }
        public bool delete()
        {
            return dao.deleteData(this.idCustomer);
        }
    }
}