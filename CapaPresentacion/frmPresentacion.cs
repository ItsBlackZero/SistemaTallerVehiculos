using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Entidades;
namespace CapaPresentacion
{
    public partial class frmPresentacion : Form
    {
        private CN_Docente obj_docente = new CN_Docente();
        public frmPresentacion()
        {
            InitializeComponent();
            cmbGenero.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            CargarComboProvincias();
        }
        private void CargarComboProvincias()
        {
            try
            {
                dgvDocente.DataSource = obj_docente.getDocente();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Focus();
                obj_docente.Nombre = txtNombre.Text;
                obj_docente.Apellidos = txtApellido.Text;
                obj_docente.Cedula = txtCedula.Text;
                obj_docente.Genero = cmbGenero.Text;
                obj_docente.Tlefono= txtTelefono.Text;
                obj_docente.Fecha_Nacimiento= dtpFechaNacimiento.Text;
                obj_docente.Direccion = txtDireccion.Text;
                if(cmbEstado.Text == "ACTIVO")
                {
                    obj_docente.Estado = 'A';
                }
                else if (cmbEstado.Text == "INACTIVO")
                {
                    obj_docente.Estado = 'I';
                }
                if (obj_docente.CrearDocente(obj_docente))
                {
                    MessageBox.Show("Registro Insertado con EXITO");
                    CargarComboProvincias();
                        
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
