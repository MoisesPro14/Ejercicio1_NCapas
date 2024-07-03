

using Ejercicio1_NCapas.CapaDatos;
using Ejercicio1_NCapas.CapaEntidad;
using System;
using System.Data;

namespace Ejercicio1_NCapas.CapaNegocio
{
    public class NegocioEstudiante
    {
        Estudiante estudiante = new Estudiante();


        //LISTAR

         public DataTable Listar(EntidadEstudiante e)
         {
            return estudiante.Listar(e);
         }

        public bool Guardar (EntidadEstudiante e)
        {
            return estudiante.Guardar(e);
        }
    }
}
