using System.Collections.Generic;

namespace Conservatorio.DATOS
{
    public class Profesor : Persona
    {
        public virtual string GradoAcademico { get; set; }
        public virtual List<Instrumento> Instrumentos { get; set; }
        public virtual List<Clase> Clases { get; set; }
    }
}
