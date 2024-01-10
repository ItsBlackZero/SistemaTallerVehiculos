using CapaDatos.ConexionDB;
using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.SqlExecute
{
    internal class ExecuteSqlCommand
    {
        private ConexionBaseDatos conn = new ConexionBaseDatos();


        public bool ExecuteSpNonQuery(string nombre_sp, List<CD_parameterSP> lista_parametros)
        {
            var comando = new SqlCommand();
            comando.Connection = conn.AbrirConexion(); //asigno conexion
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            if (lista_parametros.Count > 0)
            {
                foreach (var parametro in lista_parametros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }
            var resultado = comando.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else
                return false;
        }

        public DataTable ExecuteSpQuery(string nombre_sp, List<CD_parameterSP> lista_paramteros)
        {

            var comando = new SqlCommand();
            comando.Connection = conn.AbrirConexion(); //asigno conexion
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            if (lista_paramteros.Count > 0)
            {
                foreach (var parametro in lista_paramteros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }

            SqlDataReader reader = comando.ExecuteReader();

            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }

        }


    }
}
