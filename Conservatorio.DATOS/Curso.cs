using ServiceStack.DataAnnotations;

namespace Conservatorio.DATOS
{
    public class Curso
    {
        [AutoIncrement]
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int IdCursoRequisito { get; set; }
        public int IdInstrumento { get; set; }
        public int Nivel { get; set; }
    }
}
