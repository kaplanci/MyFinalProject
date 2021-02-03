using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
     public class ProductManager :IProductService
     {
          IProductDal _productDal;

          public ProductManager(IProductDal productDal)
          {
              _productDal = productDal;
          }

          public List<Product> GetAll()
        {
            //iş kodları 
            //yetksii var mı?

            return _productDal.GetAll();

        }

          public List<Product> GetAllByCategory(int id)
          {
              return _productDal.GetAll(p => p.CategoryID == id);
          }

          public List<Product> GetByUnitPrice(decimal min, decimal max)
          {
              return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
          }
     }
}
