using System.Data.SqlClient;

namespace Ejercicio1_NCapas.CapaDatos
{
    public class ConexionDB
    {
        private static string cadenaConexion = "Data Source=10_A4_101_52\\SQLEXPRESS;Initial Catalog=DBEscuela;Integrated Security=True;User Id=SA;";
        private static SqlConnection conexion;

        //Propiedad para acceder a la instancia única de la conexión
        public static SqlConnection ObtenerConexion() 
        {
            if(conexion == null || conexion.ConnectionString == "" )
            {
                conexion = new SqlConnection(cadenaConexion); //llama al constructor privado
                conexion.Open();
            }
            return conexion;
        }

        //Método para cerrar la conexión
        public static void CerrarConexion()
        { 
            if(conexion != null)
            {
                conexion.Close();
                conexion = null;
            }
        }
    }
}
