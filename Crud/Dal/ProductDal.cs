using Crud.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Crud.Dal
{
    class ProductDal : IProductDal
    {
        IDbManager _dbManager;

        public ProductDal(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public bool Add(Product product)
        {
            
            int vResult = 0;

            if (_dbManager.Connect())
            {
                string vSql = "";

                vSql = "insert into Products(ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock) values(@name,@category,@perUnit,@price,@stock)";

                SqlCommand sqlCommand = new SqlCommand(vSql, _dbManager._conn);

                //sqlCommand.Parameters.AddWithValue("@id", product.ProductID);
                sqlCommand.Parameters.AddWithValue("@category", product.CategoryID);
                sqlCommand.Parameters.AddWithValue("@name", product.ProductName);
                sqlCommand.Parameters.AddWithValue("@perUnit", product.QuantityPerUnit);
                sqlCommand.Parameters.AddWithValue("@price", product.UnitPrice);
                sqlCommand.Parameters.AddWithValue("@stock", product.UnitsInStock);

                vResult = sqlCommand.ExecuteNonQuery();
                
                sqlCommand.Dispose();
                _dbManager.Close();
            
            }

            return (vResult > 0) ? true : false;

        }

        public bool Delete(Product product)
        {
            
            int vResult = 0;

            if (_dbManager.Connect())
            {
                string vSql = "";

                vSql = "delete from Products where ProductID = @Id";

                SqlCommand sqlCommand = new SqlCommand(vSql, _dbManager._conn);

                sqlCommand.Parameters.AddWithValue("@id", product.ProductID);

                vResult = sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
                _dbManager.Close();

            }

            return (vResult > 0) ? true : false;

        }

        public List<Product> GetAll(int productId, int categoryId)
        {
            
            List<Product> list=null;

            if (_dbManager.Connect())
            {
                string vSql = "";

                if (productId != 0)
                {
                    vSql = "select * from Products where ProductID =" + productId;
                }
                else if (categoryId != 0)
                {
                    vSql = "select * from Products where CategoryID =" + categoryId;
                }
                else
                {
                    vSql = "select * from Products";
                }
                
                SqlCommand sqlCommand = new SqlCommand(vSql, _dbManager._conn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                list = _dbManager.DataReaderMapToList<Product>(sqlDataReader);

                sqlDataReader.Close();
                sqlCommand.Dispose();
                _dbManager.Close();

            }

            return (list.Count > 0) ? list : null;
        }

        public bool Update(Product product)
        {
            
            int vResult = 0;

            if (_dbManager.Connect())
            {
                string vSql = "";

                vSql = "update Products Set ProductName=@name,CategoryID=@category,QuantityPerUnit=@perUnit,UnitPrice=@price,UnitsInStock=@stock";
                
                SqlCommand sqlCommand = new SqlCommand(vSql, _dbManager._conn);

                sqlCommand.Parameters.AddWithValue("@category", product.CategoryID);
                sqlCommand.Parameters.AddWithValue("@name", product.ProductName);
                sqlCommand.Parameters.AddWithValue("@perUnit", product.QuantityPerUnit);
                sqlCommand.Parameters.AddWithValue("@price", product.UnitPrice);
                sqlCommand.Parameters.AddWithValue("@stock", product.UnitsInStock);

                vResult = sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
                _dbManager.Close();

            }

            return (vResult > 0) ? true : false;

        }
    }
}
