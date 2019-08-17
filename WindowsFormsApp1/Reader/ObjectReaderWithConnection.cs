using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Reader
{
    abstract class ObjectReaderWithConnection <T> :ObjectReaderBase <T>
    {
        private static string ConnectionString = @"Server=localhost;Database=cafeteriadb;Uid=root;";
        protected override IDbConnection GetConecction()
        {
            IDbConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

    }
}
