using System;

namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication auth = new Authentication(new AdminService());
        }
    }
}
