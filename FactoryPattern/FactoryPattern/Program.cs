using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserFactory userFactory = new BuyerFactory("Yusril", 27);
            IUser user = userFactory.GetUser();
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Age: " + user.Age.ToString());
            Console.WriteLine("Access Level: " + user.GetAccessLevel().ToString());
        }
    }
}
