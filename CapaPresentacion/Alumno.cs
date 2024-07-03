using Ejercicio1_NCapas.CapaEntidad;
using Ejercicio1_NCapas.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_NCapas.CapaPresentacion
{
    public partial class Alumno : Form
    {
        EntidadEstudiante objEstudiante = new EntidadEstudiante();
        NegocioEstudiante negocioEstudiante = new NegocioEstudiante();
        public Alumno()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEstudiante.Nombres = txtNombre.Text;
            objEstudiante.ApllidoPaterno =  txtApellidoPaterno.Text;
            objEstudiante.ApellidoMaterno = txtApellidoMaterno.Text;
            objEstudiante.DNI = txtdni.Text;
            objEstudiante.Telefono = txtTelefono.Text;

            bool exito = negocioEstudiante.Guardar(objEstudiante);

            if (exito = true)
            {
                MessageBox.Show("Los datos del alumno fueron registrados correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos");
            }
        }
    }
}
