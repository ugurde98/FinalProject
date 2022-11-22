using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
           // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine("--------------------------------------------------");
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
            Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine(categoryManager.GetById(2));
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName + ":" + item.UnitPrice);
            }

            Console.WriteLine("--------------------------------------------------");
            foreach (var item in productManager.GetAllByCategory(2))
            {
                Console.WriteLine(item.ProductName + ":" + item.CategoryId);
            }
            Console.WriteLine("--------------------------------------------------");
            foreach (var item in productManager.GetByUnitPrice(10, 20))
            {
                Console.WriteLine(item.ProductName + ":" + item.UnitPrice);
            }
            Console.WriteLine("--------------------------------------------------");
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+"/"+item.CategoryName);
            }
        }
    }
}