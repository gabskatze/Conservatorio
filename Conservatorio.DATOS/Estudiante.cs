

using ServiceStack.DataAnnotations;

namespace Conservatorio.DATOS
{
    public class Estudiante : Persona
    {
        //[AutoIncrement]
        public int IdEstudiante { get; set; }
        public int IdEncargado { get; set; }
        public string Tipo { get; set; }
    }
}
