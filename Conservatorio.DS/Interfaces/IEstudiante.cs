using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Conservatorio.DS.Interfaces
{
    public interface IEstudiante
    {
        void CrearEstudiante(Estudiante nuevoEstudiante);

        void EliminarEstudiante(Estudiante nuevoEstudiante);

        void ModificarEstudiante(Estudiante estudiante);

        Estudiante ObtenerEstudiante(int idEstudiante);

        List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp);

        List<Estudiante> ObtenerEstudiantes();
    }
}
