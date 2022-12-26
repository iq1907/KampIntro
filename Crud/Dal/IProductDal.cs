using Crud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Dal
{
    interface IProductDal
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        List<Product> GetAll(int productId, int categoryId);

    }
}
