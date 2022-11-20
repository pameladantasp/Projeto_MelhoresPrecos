using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Helpers;
using static ProjetoInterdisciplinar.Helpers.Enums;
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
        public ErrorResult insert()
        {
           return dao.insertData(this);
        }
        public void update()
        {
            dao.updateData(this);
        }
        public bool delete()
        {
            return dao.deleteData(this.idCustomer);
        }
    }
}