using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClassConnection
    {
        private SqlConnection connection = new SqlConnection("Data source=localhost\\LAPTOP-DE-NAVIE; " +
            "Initial Catalog=BD_PlasticHouse; Integrated Security=true");
        
        public SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

       public SqlConnection CloseConnection()
       { 
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
       }
    }
}

