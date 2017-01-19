using ServiceStack.DataAnnotations;

namespace Conservatorio.DATOS
{
    public class Clase
    {
        [AutoIncrement]
        public int IdClase { get; set; }
        public int IdProfesor { get; set; }
        public int IdInstrumento { get; set; }
        public string Nivel { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
    }
}
