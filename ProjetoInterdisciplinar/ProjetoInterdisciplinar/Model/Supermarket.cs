using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Helpers;
using System.Data;
using static ProjetoInterdisciplinar.Helpers.Enums;

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
        public ErrorResult insert()
        {
            return dao.insertData(this);
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
