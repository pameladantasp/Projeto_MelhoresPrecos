using Org.BouncyCastle.Asn1.Mozilla;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoInterdisciplinar.DAO;

namespace ProjetoInterdisciplinar.VO
{
    internal class CustomerVO
    {
        private CustomerDAO dao;
        public Customer customer;

        public CustomerVO()
        {
            customer = new Customer();
            customer.address = new Address();
            dao = new CustomerDAO();
        }
        public void insertCostumer()
        {
            dao.insertData(customer);
        }
        public void updateCostumer()
        {
            dao.updateData(customer);
        }
        public bool deleteCostumer()
        {
            return dao.delete(customer.idCustomer);
        }
    }
}
