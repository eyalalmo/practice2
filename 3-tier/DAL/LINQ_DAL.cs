using System.Collections.Generic;
using System.Linq;
using BL_BackEnd;

namespace DAL
{
    public class LINQ_DAL : IDAL
    {
        private List<Product> DB;

        public LINQ_DAL()
        {
            DB = new List<Product>();    
        }

        public void AddProduct(Product p)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> ProductNameQuery(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}