using Conservatorio.DATOS;
using System.Collections.Generic;

namespace Conservatorio.BL.Interfaces
{
    public interface IEstudianteBL
    {
        void CrearEstudiante(Estudiante estudiante);
        void ModificarEstudiante(Estudiante estudiante);
        void EliminarEstudiante(Estudiante estudiante);
        List<Estudiante> ObtenerEstudiantes(string keyword);
        List<Estudiante> ObtenerEstudiantes();
    }
}
