using System.Collections.Generic;
using System.Runtime.InteropServices;
using BL_BackEnd;

namespace PL
{
    public interface IPL
    {
        void Run();
        string ReceiveCmd();
        void DisplayResult(List<Product> result);
    }
}
