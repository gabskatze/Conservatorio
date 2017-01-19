using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace Conservatorio.DS.Clases
{
    public class EncargadoDS : IEncargado
    {
        private IDbConnection db;

        public EncargadoDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        public void CrearEncargado(Encargado nuevoEncargado)
        {
            db.Insert(nuevoEncargado, true);
        }

        public void EliminarEncargado(int idEncargado)
        {
            throw new NotImplementedException();
        }

        public void ModificarEncargado(Encargado encargado)
        {
            db.Update(encargado);
        }

        public Encargado ObtenerEncargado(int idEncargado)
        {
            return db.Select<Encargado>(x => x.IdEncargado == idEncargado).FirstOrDefault();
        }
    }
}
