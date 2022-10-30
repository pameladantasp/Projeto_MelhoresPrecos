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
        private CrudDAO dao;
        public Customer customer;

        public CrudVO()
        {
            customer = new Customer();
        }

        public void insertCostumer()
        {
            dao = new CrudDAO();
            dao.insertCostumerData(customer);
        }
        public void updateCostumer()
        {
            dao = new CrudDAO();
            dao.updateCostumerData(customer);
        }
        public bool deleteCostumer()
        {
            dao = new CrudDAO();
            return dao.deleteCostumer(customer.idCustomer);
        }
    }
}
