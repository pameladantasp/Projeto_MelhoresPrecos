using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Helpers
{
    internal class Enums
    {
        public enum ErrorResult
        {
            success,
            invalide,
            failure
        }
        public enum QueryType
        {
            address,
            category,
            customer,
            product,
            supermarket,
            registerProduct
        }
    }
}
