using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.VO
{
    internal class SupermarketVO
    {
        private SupermarketDAO dao;
        public Supermarket supermarket;

        public SupermarketVO()
        {
            supermarket = new Supermarket();
            supermarket.address = new Address();
            dao = new SupermarketDAO();
        }
        public void insertCostumer()
        {
            dao.insertData(supermarket);
        }
        public void updateCostumer()
        {
            dao.updateData(supermarket);
        }
        public bool deleteCostumer()
        {
            return dao.delete(supermarket.idSupermarket);
        }
    }
}
