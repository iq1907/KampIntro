using Crud.Dal;
using Crud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Business
{
    class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public bool Add(Product product)
        {
            return _productDal.Add(product);
        }

        public bool Delete(Product product)
        {
            return _productDal.Delete(product);
        }

        public List<Product> GetAll(int productId,int categoryId)
        {
            return _productDal.GetAll(productId,categoryId);
        }

        public bool Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
