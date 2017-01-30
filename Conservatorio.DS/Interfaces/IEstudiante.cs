using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Conservatorio.DS.Interfaces
{
    public interface IEstudiante
    {
        void CrearEstudiante(Estudiante nuevoEstudiante);

        void EliminarEstudiante(long idEstudiante);

        void ModificarEstudiante(Estudiante estudiante);

        Estudiante ObtenerEstudiante(long idEstudiante);

        List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp);

        List<Estudiante> ObtenerEstudiantes();
    }
}
