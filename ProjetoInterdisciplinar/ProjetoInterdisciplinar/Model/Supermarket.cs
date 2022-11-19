using ProjetoInterdisciplinar.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Model
{
    internal class Supermarket
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
        public DataTable selectSupermarket()
        {
            return dao.selectData(this);
        }
        public void insertSupermarket()
        {
            dao.insertData(this);
        }
        public void updateSupermarket()
        {
            dao.updateData(this);
        }
        public bool deleteSupermarket()
        {
            return dao.deleteData(this.idSupermarket);
        }
    }
}
