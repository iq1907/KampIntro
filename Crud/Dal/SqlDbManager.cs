using Crud.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;


namespace Crud.Dal
{
    public class SqlDbManager:IDbManager
    {
        public SqlConnection _conn { get; set; }

        public List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        public bool Connect()
        {

            string vConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _conn = new SqlConnection(vConnStr);

            try
            {
                _conn.Open();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;

        }

        public bool Close()
        {
            try
            {
                _conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

    }
}
