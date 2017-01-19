using ServiceStack.DataAnnotations;

namespace Conservatorio.DATOS
{
    public class Instrumento
    {
        [AutoIncrement]
        public int IdInstrumento { get; set; }
        public string NombreInstrumento { get; set; }
    }
}
