//usamos los siguientes archivos
using System.Data;
using Ejercicio1_NCapas.CapaDatos;
using Ejercicio1_NCapas.CapaEntidad;

namespace Ejercicio1_NCapas.CapaNegocio
{
    public class NegocioLogin
    {
        //Instanciamos un objeto de la capa Datos
        DatosLogin objDatos = new DatosLogin();

        //
        public DataTable LogonN(EntidadLogin e)
        {
            //llama al datatable resuelto en la capa Datos para enviarlo a la capa Presentación
            return objDatos.Login(e);
        }
    }
}
