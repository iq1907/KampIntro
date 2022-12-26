using Crud.Dal;
using Crud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Business
{
    interface IProductService
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        List<Product> GetAll(int productId, int categoryId);


    }
}
