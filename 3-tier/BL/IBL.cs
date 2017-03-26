using System.Collections.Generic;
using BL_BackEnd;

namespace BL
{
    public interface IBL
    {
        void AddProduct(Product p);
        List<Product> FindProductByName(string name);
    }
}