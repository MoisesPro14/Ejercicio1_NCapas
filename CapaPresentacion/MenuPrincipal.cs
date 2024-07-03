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
    public partial class MenuPrincipal : Form
    {
        NegocioEstudiante negocioEstudiante = new NegocioEstudiante();
        EntidadEstudiante estudiante = new EntidadEstudiante();
        public MenuPrincipal()
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido" + " " + EntidadLogin.Posicion + " " + EntidadLogin.NombreUsuario + " " +EntidadLogin.Apellios;
            Listar();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Listar()
        {
             DataTable tbl =  negocioEstudiante.Listar(estudiante);

            if (tbl.Rows.Count > 0)
            {
                grwEstudiante.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("No hay alumnos Registrados");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno Alumno = new Alumno();
            Alumno.ShowDialog();
        }
    }
}
