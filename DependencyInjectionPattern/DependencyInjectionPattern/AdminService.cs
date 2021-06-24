using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern
{
    class AdminService : IUserService
    {
        public void ShowName()
        {
            Console.WriteLine("Admin Name");
        }
        public void ShowAge()
        {
            Console.WriteLine("Admin Age");
        }
        public void ShowAccessLevel()
        {
            Console.WriteLine("Admin Access Level");
        }
    }
}
