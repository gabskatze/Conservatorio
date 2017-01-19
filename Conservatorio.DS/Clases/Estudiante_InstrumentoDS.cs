using System;
using System.Collections.Generic;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace Conservatorio.DS.Clases
{
    public class Estudiante_InstrumentoDS : IEstudiante_Instrumento
    {
        private IDbConnection db;

        public Estudiante_InstrumentoDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        public List<Estudiante_Instrumento> ObtenerEstudiante_Instrumento()
        {
            return db.Select<Estudiante_Instrumento>();
        }
    }
}
