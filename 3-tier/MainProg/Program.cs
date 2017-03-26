
using BL;
using DAL;
using PL;

namespace MainProg
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAL dal = new LINQ_DAL();
            IBL bl = new Product_Managment_BL(dal);
            IPL pl = new PL_CLI(bl);
            pl.Run();
        }
    }
}
