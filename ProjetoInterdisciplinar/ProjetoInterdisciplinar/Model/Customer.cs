using ProjetoInterdisciplinar.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Model
{
    internal class Customer
    {
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

        public LoginResult login()
        {
            return dao.verifyLogin(this);
        }
        public void insertCostumer()
        {
            dao.insertData(this);
        }
        public void updateCostumer()
        {
            dao.updateData(this);
        }
        public bool deleteCostumer()
        {
            return dao.deleteData(this.idCustomer);
        }
    }
}