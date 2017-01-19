using System;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using ServiceStack.OrmLite;
using System.Data;
using System.Linq;

namespace Conservatorio.DS.Clases
{
    public class ClaseDS : IClase
    {
        private IDbConnection db;

        public ClaseDS()
        {
            var conexion = Conexion.EstablecerConexion();
             db = conexion.Open();
        }

        public void CrearClase(Clase nuevaClase)
        {
            
            db.Insert(nuevaClase, true);
        }

        public void EliminarClase(int idClase)
        {
            throw new NotImplementedException();
        }

        public void ModificarClase(Clase clase)
        {
            db.Update(clase);
        }

        public Clase ObtenerClase(int idClase)
        {
            return db.Select<Clase>(x => x.IdClase == idClase).FirstOrDefault();
        }

    }
}
