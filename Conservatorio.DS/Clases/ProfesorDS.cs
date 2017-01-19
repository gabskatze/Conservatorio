using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatorio.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;
using Conservatorio.DATOS;

namespace Conservatorio.DS.Clases
{
    public class ProfesorDS : IProfesor
    {
        private IDbConnection db;

        public ProfesorDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        public void CrearProfesor(Profesor nuevoProfesor)
        {
            db.Insert(nuevoProfesor, true);
        }

        public void EliminarProfesor(int idProfesor)
        {
            throw new NotImplementedException();
        }

        public void ModificarProfesor(Persona profesor)
        {
            db.Update(profesor);
        }

        public Profesor ObtenerProfesor(int idProfesor)
        {
            return db.Select<Profesor>(x => x.IdProfesor == idProfesor).FirstOrDefault();
        }
    }
}
