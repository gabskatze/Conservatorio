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
    public class PersonaDS : IPersona
    {
        private IDbConnection db;

        public PersonaDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        public void CrearPersona(Persona nuevaPersona)
        {
            db.Insert(nuevaPersona, true);
        }

        public void EliminarPersona(int idPersona)
        {
            throw new NotImplementedException();
        }
        
        public void ModificarPersona(Persona persona)
        {
            db.Update(persona);
        }

        public Persona ObtenerPersona(int idPersona)
        {
            return db.Select<Persona>(x => x.IdPersona == idPersona).FirstOrDefault();
        }
    }
}
