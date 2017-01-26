namespace Conservatorio.DATOS
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public Curso CursoRequisito { get; set; }
        public Instrumento Instrumento { get; set; }
        public int Nivel { get; set; }
    }
}
