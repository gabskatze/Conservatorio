using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatorio.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;
using Conservatorio.DATOS;
using System.Linq.Expressions;

namespace Conservatorio.DS.Clases
{
    public class EstudianteDS : IEstudiante
    {
        private IDbConnection db;

        public EstudianteDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        public void CrearEstudiante(Estudiante nuevoEstudiante)
        {
            db.Insert(nuevoEstudiante, true);
        }

        public void EliminarEstudiante(int idEstudiante)
        {
            throw new NotImplementedException();
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            db.Update(estudiante);
        }

        public Estudiante ObtenerEstudiante(int idEstudiante)
        {
            return db.Select<Estudiante>(x => x.IdEstudiante == idEstudiante).FirstOrDefault();
        }

        public List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp)
        {
            return db.Select(exp);
        }
    }
}
