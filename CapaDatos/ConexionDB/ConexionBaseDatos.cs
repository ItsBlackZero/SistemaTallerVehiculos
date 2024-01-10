using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.ConexionDB
{
    internal class ConexionBaseDatos
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-KEAFE1A; database=POE59; Integrated Security=true");

        internal SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        internal SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            return conexion;
        }
    }
}
