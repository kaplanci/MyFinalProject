using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
     public class InMemoryProductDal : IProductDal
     {
          List<Product> products ;
           List<Product> _products;

          public InMemoryProductDal()
          {
              //constructor
              _products = new List<Product>
              {
                  new Product
                  {
                      ProductID = 1, CategoryID = 1,ProductName = "Bardak",
                      UnitPrice = 15,UnitInStock = 15
                  },
                  new Product
                  {
                      ProductID = 2, CategoryID = 1,ProductName = "Kamera",
                      UnitPrice = 500,UnitInStock = 3
                  },
                  new Product
                  {
                      ProductID = 3, CategoryID = 2,ProductName = "Telefon",
                      UnitPrice = 1500,UnitInStock = 12
                  },
                  new Product
                  {
                      ProductID = 4, CategoryID = 2,ProductName = "Klavye",
                      UnitPrice = 150,UnitInStock = 65
                  },
                  new Product
                  {
                      ProductID = 5, CategoryID = 2,ProductName = "fare",
                      UnitPrice = 88,UnitInStock = 1
                  },

              };

          }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            //gönderdiği,m ürün ıdsine sahip olan listedeki ürünü bul demek

            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;


        }

        public void Delete(Product product)
        {
           //LINQ kullanıldı Lambda kullanıldı
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);


            _products.Remove(productToDelete);
        }

        public List<Product> GetAllByCategory (int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }
     }
}
