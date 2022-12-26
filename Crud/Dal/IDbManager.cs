using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Crud.Dal
{
    public interface IDbManager
    {
        public SqlConnection _conn { get; set; }

        public List<T> DataReaderMapToList<T>(IDataReader dr);

        public bool Connect();

        public bool Close();

    }
}
