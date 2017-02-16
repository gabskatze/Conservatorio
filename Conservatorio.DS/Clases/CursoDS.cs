using System.Collections.Generic;
using System.Linq;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class CursoDS : ICursoDS
    {
        public List<Curso> ObtenerCursos()
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Curso>().ToList();
            }
        }
    }
}
