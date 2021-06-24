using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern
{
    class SellerService : IUserService
    {
        public void ShowName()
        {
            Console.WriteLine("Seller Name");
        }
        public void ShowAge()
        {
            Console.WriteLine("Seller Age");
        }
        public void ShowAccessLevel()
        {
            Console.WriteLine("Seller Access Level");
        }
    }
}
