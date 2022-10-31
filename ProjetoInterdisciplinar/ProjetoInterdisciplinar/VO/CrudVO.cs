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
    internal class CrudVO
    {
        private CostumerDAO dao;
        public Customer customer;

        public CrudVO()
        {
            customer = new Customer();
            dao = new CostumerDAO();
        }
        public void insertCostumer()
        {
            dao.insertData(customer);
        }
        public void updateCostumer()
        {
            dao.updateCostumerData(customer);
        }
        public bool deleteCostumer()
        {
            return dao.deleteCostumer(customer.idCustomer);
        }
    }
}
