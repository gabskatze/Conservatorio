using Conservatorio.DATOS;
using System.Collections.Generic;

namespace Conservatorio.BL.Interfaces
{
    public interface IEstudiante
    {
        List<Estudiante> ObtenerEstudiantes(string keyword);
    }
}
