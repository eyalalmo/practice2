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
           public void AddProduct(Product p)
        {
            //First generate the new product ID
            List<Product> Allprods = itsDAL.GetAllProducts();
            int maxID = 0;
            foreach (Product prod in Allprods)
            {
                if (prod.ProductID > maxID)
                    maxID = prod.ProductID;
            }
            //set the new ID
            p.ProductID = maxID++;
            //Add the new product to the system
            itsDAL.AddProduct(p);
        }
    }
<<<<<<< HEAD
    console.etay21
=======
    console.etay2121
>>>>>>> origin/new
        public List<Product> FindProductByName(string name)
        {
           public List<Product> FindProductByName(string name)
    {
        return itsDAL.ProductNameQuery(name);
    }
}
    }
}