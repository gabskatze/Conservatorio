using Conservatorio.DS.Interfaces;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatorio.DS.Clases
{
    public class Profesor_InstrumentoDS : IProfesor_Instrumento
    {
        private IDbConnection db;

        public Profesor_InstrumentoDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }
    }
}
