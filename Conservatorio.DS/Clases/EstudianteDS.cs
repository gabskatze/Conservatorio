using System;
using System.Collections.Generic;
using Conservatorio.DS.Interfaces;
using Conservatorio.DATOS;
using System.Linq.Expressions;

namespace Conservatorio.DS.Clases
{
    public class EstudianteDS : IEstudiante
    {
        public void CrearEstudiante(Estudiante nuevoEstudiante)
        {
            throw new NotImplementedException();
        }

        public void EliminarEstudiante(long idEstudiante)
        {
            throw new NotImplementedException();
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public Estudiante ObtenerEstudiante(long idEstudiante)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp, Expression<Func<Persona, bool>> exp2)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            throw new NotImplementedException();
        }
    }
}
