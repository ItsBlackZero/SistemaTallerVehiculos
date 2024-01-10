using CapaDatos.SqlExecute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    public class InterfaceNegocio
    {
        private ExecuteSqlCommand obj_db = new ExecuteSqlCommand();

        public bool crearDocente(List<CD_parameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpNonQuery("SP_CREAR_DOCENTE",lista);
            }catch (Exception e)
            {
                throw new Exception("Error al crear Docente "+ e.Message);
            }
        }

        public DataTable getListaDocentes()
        {
            try
            {
                List<CD_parameterSP> lista = new List<CD_parameterSP>();
                return obj_db.ExecuteSpQuery("SP_OBTENER_DOCENTE", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener listado de Provincias: " + ex.Message);
            }
        }
    }
}
