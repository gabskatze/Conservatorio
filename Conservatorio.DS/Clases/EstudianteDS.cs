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
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(nuevoEstudiante);
            }
        }

        public void EliminarEstudiante(int idEstudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                var miEstudiante = ObtenerEstudiante(idEstudiante);
                miEstudiante.Estado = false;
                ModificarEstudiante(miEstudiante);
            }
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(estudiante);
            }
        }

        public Estudiante ObtenerEstudiante(int idEstudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Get<Estudiante>(idEstudiante);
            }
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
