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
            DB.Add(p);
        }

        public List<Product> ProductNameQuery(string name)
        {
            //perform query
            var results = from Product p in DB
                          where p.Name == name
                          select p;
            //return results
            return results.ToList();
        }

        public List<Product> GetAllProducts()
        {
            int i = 16;
            return DB;
        }
    }
}