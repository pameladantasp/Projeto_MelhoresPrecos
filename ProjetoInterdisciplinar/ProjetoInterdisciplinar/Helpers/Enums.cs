using System;

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

        public enum WhereType
        {
            like,
            limit
        }
    }
}
