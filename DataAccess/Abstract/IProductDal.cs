﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();


    }
}

///Code refactoring
