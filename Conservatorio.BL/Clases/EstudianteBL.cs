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

        public List<Estudiante> ObtenerEstudiantes()
        {
            return iEstudiante.ObtenerEstudiantes();
        }

        public void CrearEstudiante(Estudiante estudiante)
        {
            iEstudiante.CrearEstudiante(estudiante);
        }

        public void EliminarEstudiante(long idEstudiante)
        {
            iEstudiante.EliminarEstudiante(idEstudiante);
        }
    }
}
