using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Model
{
    internal class RegisterProduct
    {
        public int idRegister { get; set; }
        public Customer customer { get; set; }
        public Product  product { get; set; }
        public Supermarket supermarket { get; set; }
        public float price { get; set; }
        public DateTime dateRegister { get; set; }

        private RegisterProductDAO dao;

        public RegisterProduct()
        {
            this.supermarket = new Supermarket();
            this.product = new Product();
            this.product.category = new Category();
            dao = new RegisterProductDAO();
        }
        public void insertProduct()
        {
            dao.insertData(this);
        }
        public void updateProduct()
        {
            dao.updateData(this);
        }
        public bool deleteProduct()
        {
            return dao.deleteData(this.idRegister);
        }
    }
}
