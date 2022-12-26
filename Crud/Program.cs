using Crud.Business;
using Crud.Dal;
using Crud.Entities;
using System;

namespace Crud
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal(new SqlDbManager()));

            Product product1 = new Product
            {
                CategoryID = 1,
                ProductID = 78,
                ProductName = "Elma",
                QuantityPerUnit = "Adet",
                UnitPrice = 100,
                UnitsInStock = 0
            };

            //var result = productManager.Add(product1);
            var result = productManager.Delete(product1);

            Console.WriteLine("result : " + result);

            var vList = productManager.GetAll(78,0);

            foreach (var item in vList)
            {
                Console.WriteLine(item.CategoryID + " " + item.ProductName);
            }

        }
    }
}
