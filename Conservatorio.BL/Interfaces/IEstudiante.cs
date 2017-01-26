using Conservatorio.DATOS;
using System.Collections.Generic;

namespace Conservatorio.BL.Interfaces
{
    public interface IEstudiante
    {
        List<Estudiante> ObtenerEstudiantes(string keyword);
        List<Estudiante> ObtenerEstudiantes();
        void CrearEstudiante(Estudiante estudiante);
        void EliminarEstudiante(long idEstudiante);
    }
}
