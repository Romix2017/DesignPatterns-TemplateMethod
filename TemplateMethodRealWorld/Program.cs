using System;

namespace TemplateMethodRealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();
            Console.ReadKey();
            DataAccessObject daoProducts = new Products();
            daoProducts.Run();
            Console.ReadKey();
        }
    }
}
