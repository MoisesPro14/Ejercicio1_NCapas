
using Ejercicio1_NCapas.CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Ejercicio1_NCapas.CapaDatos
{
    public class Estudiante
    {
        //AQUI AGREGAMOS LOS METODOS DEL CRUD DE ESTUDIANTES 

        //LISTAR 

        public DataTable Listar(EntidadEstudiante e)
        {
            try
            {
                using(SqlConnection cn = ConexionDB.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ListarEstudiante", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tbl = new DataTable();
                            da.Fill(tbl);
                            return tbl;
                        }
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la base de datos: " + ex.Message);
                return null;
            }
        }
        //GUARDAR DATOS ESTUDIANTE
        public bool Guardar  (EntidadEstudiante e)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("AgregarEstudiante", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombres", e.Nombres);
                        cmd.Parameters.AddWithValue("@apellidoPaterno", e.ApellidoMaterno);
                        cmd.Parameters.AddWithValue("@apellidoMaterno", e.ApellidoMaterno);
                        cmd.Parameters.AddWithValue("@dni", e.DNI);
                        cmd.Parameters.AddWithValue("@telefono", e.Telefono);

                        cmd.ExecuteNonQuery();
                        return true;
                       
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Los datos no se han registrado" + ex.Message);
                return false;
            }
        }
    }
}
