﻿using System.Collections.Generic;

namespace Conservatorio.DATOS
{
    public class Profesor : Persona
    {
        public virtual string GradoAcademico { get; set; }
        public virtual IList<Instrumento> Instrumentos { get; set; }
        public virtual IList<Clase> Clases { get; set; }
    }
}
