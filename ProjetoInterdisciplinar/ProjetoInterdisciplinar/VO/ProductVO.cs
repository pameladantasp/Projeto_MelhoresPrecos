using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.VO
{
    internal class ProductVO
    {
        private ProductDAO dao;
        public Product product;

        public ProductVO()
        {
            product = new Product();
            product.category = new Category();
            dao = new ProductDAO();
        }
        public void insertProduct()
        {
            dao.insertData(product);
        }
        public void updateProduct()
        {
            dao.updateData(product);
        }
        public bool deleteProduct()
        {
            return dao.delete(product.idProduct);
        }
    }
}
