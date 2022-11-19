﻿using ProjetoInterdisciplinar.DAO;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable selectSupermarket()
        {
            return dao.selectData(supermarket);
        }
        public void insertSupermarket()
        {
            dao.insertData(supermarket);
        }
        public void updateSupermarket()
        {
            dao.updateData(supermarket);
        }
        public bool deleteSupermarket()
        {
            return dao.delete(supermarket.idSupermarket);
        }
    }
}
