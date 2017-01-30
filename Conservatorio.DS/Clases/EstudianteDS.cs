using System;
using System.Collections.Generic;
using System.Linq;
using Conservatorio.DS.Interfaces;
using Conservatorio.DATOS;
using System.Linq.Expressions;
using NHibernate.Linq;

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

        public List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Estudiante>().Where(exp).ToList();
            }
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            throw new NotImplementedException();
        }
    }
}
