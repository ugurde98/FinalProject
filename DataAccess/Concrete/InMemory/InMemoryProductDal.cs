using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products= new List<Product> {
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ProductName="Bardak",
                    UnitPrice=15,
                    UnitsInStock=48,
                
                },
                new Product 
                {
                    ProductId=2,
                    CategoryId=1,
                    ProductName="Cam",
                    UnitPrice=115,
                    UnitsInStock=8,

                },
                    new Product
                {
                    ProductId=3,
                    CategoryId=2,
                    ProductName="Bar",
                    UnitPrice=5,
                    UnitsInStock=458,

                },
                        new Product
                {
                    ProductId=4,
                    CategoryId=2,
                    ProductName="Dak",
                    UnitPrice=1,
                    UnitsInStock=123,

                },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategory(int categoryId)
        {
          return  _products.Where(p=>p.CategoryId == categoryId).ToList();    
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
