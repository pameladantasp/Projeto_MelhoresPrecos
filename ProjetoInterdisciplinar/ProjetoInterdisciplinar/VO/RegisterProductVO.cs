using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.VO
{
    internal class RegisterProductVO
    {
        private RegisterProductDAO dao;
        public  RegisterProduct registerProduct;

        public RegisterProductVO()
        {
            registerProduct = new RegisterProduct();
            registerProduct.customer = new Customer();
            registerProduct.supermarket = new Supermarket();
            registerProduct.product = new Product();
            dao = new RegisterProductDAO();
        }
        public void insertCostumer()
        {
            dao.insertData(registerProduct);
        }
        public void updateCostumer()
        {
            dao.updateData(registerProduct);
        }
        public bool deleteCostumer()
        {
            return dao.delete(registerProduct.idRegister);
        }
    }
}
