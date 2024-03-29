﻿using ProjetoInterdisciplinar.DAO;
using System;
using System.Collections.Generic;
using static ProjetoInterdisciplinar.Helpers.Enums;

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
            dao = new RegisterProductDAO();
        }

        public List<RegisterProduct> select()
        {
            return dao.selectData();
        }

        public List<RegisterProduct> search(string searchText)
        {
            return dao.searchData(searchText);
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
            return dao.deleteData(this.idRegister);
        }
    }
}
