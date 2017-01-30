using System.Collections.Generic;

namespace Conservatorio.DATOS
{
    public class Instrumento
    {
        public virtual int IdInstrumento { get; set; }
        public virtual string NombreInstrumento { get; set; }
        public virtual List<Profesor> Profesores { get; set; }
        public virtual List<Estudiante> Estudiantes { get; set; }
        public virtual List<Curso> Cursos { get; set; }
    }
}
