//importamos los siguientes archivos
using System;
using System.Data;
using System.Data.SqlClient; //con esto llamamos a la conexión SQL server
using System.Windows.Forms;
using Ejercicio1_NCapas.CapaEntidad;
using Ejercicio1_NCapas.CapaPresentacion; //llamamos a la capa de Entidad

namespace Ejercicio1_NCapas.CapaDatos
{
    public class DatosLogin
    {
        //private static string cadenaConexion = "Data Source=INSTRUCTOR-LAB-\\SQLEXPRESS;Initial Catalog=dbEscuela;Integrated Security=True;User Id=SA;";
        //SqlConnection cn = new SqlConnection(cadenaConexion);

        public DataTable Login(EntidadLogin e)
        {
            //vamos a crear una excepción en caso no se conecte 
            try { 
                //establecemos el procedimiento almacenado
                using(SqlConnection cn = ConexionDB.ObtenerConexion())
                {
                    //llamamos al procedimiento almacenado
                    using(SqlCommand cmd = new SqlCommand("Logeo",cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", e.Usuario);
                        cmd.Parameters.AddWithValue("@Contrasenia", e.Contrasenia);

                        //los datos devueltos lo agregamso a un datatable
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tbl = new DataTable();
                            da.Fill(tbl);
                            EntidadLogin.NombreUsuario = (tbl.Rows[0]["nombres"].ToString());
                            EntidadLogin.Apellios = (tbl.Rows[0]["apellidos"].ToString());
                            EntidadLogin.Posicion = (tbl.Rows[0]["posicion"].ToString());
                            //MessageBox.Show("Bienvenido " + EntidadLogin.NombreUsuario);
                            return tbl;
                        }
                    }
                }
            }
            catch(Exception ex) {
                //si no se conecta muestra un error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }
    }

    //Agregar Estudiante
    //Actualizar Estudiante
    //Eliminar Estudiante
    //Listar Estudiantes
}
