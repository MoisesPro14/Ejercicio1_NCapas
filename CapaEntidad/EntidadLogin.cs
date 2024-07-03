namespace Ejercicio1_NCapas.CapaEntidad
{
    public class EntidadLogin
    {
        public string Usuario { get; set; } //get: para obtener el dato, set: para establecer el dato
        public string Contrasenia { get; set; }


        public static string NombreUsuario { get; set; } //STATIC SIGNIFICA QUE SE PUEDE ACCEDER A ESTA VARIABLE DE MANERA GLOBAL

        public static string Apellios { get; set; }
        public static string Posicion { get; set; }

    }
}
