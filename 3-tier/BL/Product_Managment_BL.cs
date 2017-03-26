using System.Collections.Generic;
using BL_BackEnd;
using DAL;

namespace BL
{
    public class Product_Managment_BL : IBL
    {
        private IDAL itsDAL;

        public Product_Managment_BL(IDAL itsDal)
        {
            itsDAL = itsDal;
        }

        public void AddProduct(Product p)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> FindProductByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}