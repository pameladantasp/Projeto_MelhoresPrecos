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
            registerProduct.supermarket = new Supermarket();
            registerProduct.product = new Product();
            registerProduct.product.category = new Category();
            dao = new RegisterProductDAO();
        }
        public void insertProduct()
        {
            dao.insertData(registerProduct);
        }
        public void updateProduct()
        {
            dao.updateData(registerProduct);
        }
        public bool deleteProduct()
        {
            return dao.delete(registerProduct.idRegister);
        }
    }
}
