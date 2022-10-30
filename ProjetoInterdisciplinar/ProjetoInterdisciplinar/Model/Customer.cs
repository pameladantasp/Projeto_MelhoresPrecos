using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Model
{
    internal class Customer
    {
        public int idCustomer { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Address address { get; set; } 
    }
}