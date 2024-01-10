using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;

namespace CapaNegocio.Entidades
{
    public class CN_Docente
    {
        private InterfaceNegocio obj_interfaceProvincia = new InterfaceNegocio();
        private string cedula;
        private string nombre;
        private string apellidos;
        private string genero;
        private string fecha_nacimiento;
        private string direccion;
        private string telefono;
        private char estado;

        public CN_Docente() 
        {
            cedula = string.Empty;
            nombre = string.Empty;
            apellidos = string.Empty;
            genero = string.Empty;
            fecha_nacimiento = string.Empty;
            direccion = string.Empty;
            telefono = string.Empty;
            estado = 'A';
        }

        public string Cedula { get { return cedula; } set { cedula = value; } }
        public string Nombre { get {  return nombre; } set { nombre = value; } }
        public string Apellidos { get {  return apellidos; } set {  apellidos = value; } }
        public string Tlefono { get {  return telefono; } set {  telefono = value; } }
        public string Direccion { get {  return direccion; } set {  direccion = value; } }
        public char Estado { get {  return estado; } set { estado = value; } }
        public string Genero { get { return genero; }set { genero = value; } }  
        public string Fecha_Nacimiento { get { return fecha_nacimiento;} set { fecha_nacimiento= value; } }

        public bool CrearDocente (CN_Docente docente)
        {
            try
            {
                List<CD_parameterSP> lista = new List<CD_parameterSP>();
                lista.Add(new CD_parameterSP("@cedula", docente.cedula, SqlDbType.Text));
                lista.Add(new CD_parameterSP("@nombres", docente.nombre, SqlDbType.Text));
                lista.Add(new CD_parameterSP("@apellidos", docente.apellidos, SqlDbType.Text));
                lista.Add(new CD_parameterSP("@genero", docente.genero, SqlDbType.Text));
                lista.Add(new CD_parameterSP("@fecha_nacimiento", docente.fecha_nacimiento, SqlDbType.Date));
                lista.Add(new CD_parameterSP("@direccion", docente.direccion, SqlDbType.Text));
                lista.Add(new CD_parameterSP("@telefono", docente.telefono, SqlDbType.Text));
                return obj_interfaceProvincia.crearDocente(lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear registro de docente"+ ex.Message);
            }
            

        }

        public DataTable getDocente()
        {
            try
            {
                var tabla = new DataTable();
                tabla = obj_interfaceProvincia.getListaDocentes();
                return tabla;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al Obtener Listado de Provincias " + ex.Message);
            }
        }
    }
}
