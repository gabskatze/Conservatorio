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
    public class InstrumentoDS : IInstrumento
    {
        private IDbConnection db;

        public InstrumentoDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        public void CrearInstrumento(Instrumento nuevoInstrumento)
        {
            db.Insert(nuevoInstrumento, true);
        }

        public void ModificarInstrumento(Instrumento instrumento)
        {
            db.Update(instrumento);
        }

        public Instrumento ObtenerInstrumento(int idInstrumento)
        {
            return db.Select<Instrumento>(x => x.IdInstrumento == idInstrumento).FirstOrDefault();
        }

        public List<Instrumento> ObtenerInstrumentos(Expression<Func<Instrumento,bool>> exp)
        {
            return db.Select(exp);
        }
    }
}
