using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.VO
{
    internal class CrudVO
    {
        private int _idConsumer;
        private string _nameConsumer;
        private string _emailConsumer;
        private DAO.CrudDAO dao;
        public int idConsumer
        {
            get { return _idConsumer; }
            set { _idConsumer = value; }
        }
        public string nameConsumer
        {
            get { return _nameConsumer; }
            set { _nameConsumer = value;  }
        }
        public string emailConsumer
        {
            get { return _emailConsumer; }
            set { _emailConsumer = value; }
        }
        public void Insert()
        {
            dao = new DAO.CrudDAO();
            dao.InsertDate(nameConsumer, emailConsumer);
        }
        public void Update()
        {
            dao = new DAO.CrudDAO();
            dao.Update(idConsumer, nameConsumer, emailConsumer);
        }
        public void Delate()
        {
            dao = new DAO.CrudDAO();
            dao.DelateData(idConsumer, nameConsumer, emailConsumer);
        }
    }
}
