using System;
using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Clases
{
    public class EstudianteBL : IEstudiante
    {
        DS.Interfaces.IEstudiante iEstudiante = new DS.Clases.EstudianteDS();
        public List<Estudiante> ObtenerEstudiantes(string keyword)
        {
            return iEstudiante.ObtenerEstudiantes(x => x.Nombre.Contains(keyword));
        }
    }
}
