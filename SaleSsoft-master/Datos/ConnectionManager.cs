using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class ConnectionManager
    {
        internal OracleConnection conexion;
        public ConnectionManager(string connectionString)
        {
            conexion = new OracleConnection(connectionString);
        }
        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }
    }
}