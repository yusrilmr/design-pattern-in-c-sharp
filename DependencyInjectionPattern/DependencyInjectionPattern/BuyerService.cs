using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern
{
    class BuyerService : IUserService
    {
        public void ShowName()
        {
            Console.WriteLine("Buyer Name");
        }
        public void ShowAge()
        {
            Console.WriteLine("Buyer Age");
        }
        public void ShowAccessLevel()
        {
            Console.WriteLine("Buyer Access Level");
        }
    }
}
