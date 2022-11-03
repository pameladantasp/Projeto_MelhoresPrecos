using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Model
{
    internal class RegisterProduct
    {
        public int idRegister { get; set; }
        public Customer customer { get; set; }
        public Product  product { get; set; }
        public Supermarket supermarket { get; set; }
        public float Price { get; set; }
        public DateTime DataRegister { get; set; }
    }
}
