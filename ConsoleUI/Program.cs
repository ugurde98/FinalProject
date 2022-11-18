using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName+ ":" +item.UnitPrice);
            }

            Console.WriteLine("--------------------------------------------------");
            foreach (var item in productManager.GetAllByCategory(2))
            {
                Console.WriteLine(item.ProductName + ":" + item.CategoryId);
            }
            Console.WriteLine("--------------------------------------------------");
            foreach (var item in productManager.GetByUnitPrice(10,20))
            {
                Console.WriteLine(item.ProductName + ":" + item.UnitPrice);
            }

        }

    }
}