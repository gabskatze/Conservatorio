using System.Collections.Generic;

namespace Conservatorio.DATOS
{
    public class Curso
    {
        public virtual int IdCurso { get; set; }
        public virtual string NombreCurso { get; set; }
        public virtual Curso CursoRequisito { get; set; }
        public virtual Instrumento Instrumento { get; set; }
        public virtual int Nivel { get; set; }
        public virtual List<Clase> Clases { get; set; }
    }
}
