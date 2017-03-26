using System.Collections.Generic;
using BL_BackEnd;

namespace DAL
{
    public interface IDAL
    {
        void AddProduct(Product product);
        List<Product> ProductNameQuery(string name);
        List<Product> GetAllProducts();
    }
}