using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatorio.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace Conservatorio.DS.Clases
{
    public class Pago_MatriculaDS : IPago_Matricula
    {
        private IDbConnection db;

        public Pago_MatriculaDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }
    }
}
