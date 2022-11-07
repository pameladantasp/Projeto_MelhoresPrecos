using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Model
{
    internal class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public Category category { get; set; }
    }
}
