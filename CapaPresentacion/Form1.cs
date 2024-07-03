using System;
using System.Data;
using System.Windows.Forms;
using Ejercicio1_NCapas.CapaEntidad;
using Ejercicio1_NCapas.CapaNegocio;
using Ejercicio1_NCapas.CapaPresentacion;



namespace Ejercicio1_NCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EntidadLogin objEntidad = new EntidadLogin();
        NegocioLogin objNegocio = new NegocioLogin();

        void Login() //Creando procedimiento
        {
            objEntidad.Usuario = txtUsuario.Text; 
            objEntidad.Contrasenia = txtContrasenia.Text;

            //llamos a un obj datatable y volcamos los datos del método LogonN(tipo datatable) allí
            DataTable tbl = objNegocio.LogonN(objEntidad);
            //si no me devuelve ningún dato
            if(tbl.Rows.Count == 0 )
            {
                MessageBox.Show("No coinciden Usuario y Contraseña \n Inténtelo nuevamente", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                txtUsuario.Focus();
            }
            //si existe
            else
            {
                //MessageBox.Show("Bienvenidos al Sistema", "Acceso al Sistema", MessageBoxButtons.OK);

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                menuPrincipal.FormClosed += CerrarSesion;
                this.Hide();
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
            this.Show();
            txtUsuario.Focus();
        }
    }
}
