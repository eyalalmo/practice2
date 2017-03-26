using System;
using System.Collections.Generic;
using BL;
using BL_BackEnd;

namespace PL
{
    public class PL_CLI : IPL
    {
        private IBL _bl;

        public PL_CLI(IBL bl)
        {
            _bl = bl;
        }

        public void Run()
        {
            Console.WriteLine("Menu was not implemented");
            Console.WriteLine("Press Q to exit");
            while (true)
            {
                string c = ReceiveCmd();
                if (c == "Q" || c == "q")
                {
                    return;
                }
            }
        }

        public string ReceiveCmd()
        {
            return Console.ReadLine();
        }

        public void DisplayResult(List<Product> results)
        {
            if (results == null || results.Count == 0)
            {
                Console.WriteLine("No result was found");
            }
            else
            {
                Console.WriteLine("The Result:");
                foreach (var p in results)
                {
                    Console.WriteLine(
                        $"\tProduct id: \"{p.ProductID}\" , Product Name: \"{p.Name}\" , Product Type: \"{p.Type}\"");
                }
            }
        }
    }
}
