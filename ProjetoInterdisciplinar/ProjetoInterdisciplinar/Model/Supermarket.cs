using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Model
{
    internal class Supermarket : ModelInterface
    {
        public int idSupermarket { get; set; }
        public string name { get; set; }
        public Address address { get; set; }

        private SupermarketDAO dao;

        public Supermarket()
        {
            this.address = new Address();
            dao = new SupermarketDAO();
        }
        public DataTable select()
        {
            return dao.selectData(this);
        }
        public void insert()
        {
            dao.insertData(this);
        }
        public void update()
        {
            dao.updateData(this);
        }
        public bool delete()
        {
            return dao.deleteData(this.idSupermarket);
        }
    }
}
