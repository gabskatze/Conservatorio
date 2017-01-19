using System;
using System.Collections.Generic;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;
using System.Linq;

namespace Conservatorio.DS.Clases
{
    public class Clase_EstudianteDS : IClase_Estudiante
    {
        private IDbConnection db;

        public Clase_EstudianteDS()
        {
            var conexion = Conexion.EstablecerConexion();
            db = conexion.Open();
        }

        //public void CrearClase_Estudiante(List<Clase_Estudiante> clase_estudiante)
        //{
        //    db.Insert(clase_estudiante, true);
        //}

        //public void ModificarClase_Estudiante(Clase_Estudiante clase_estudiante)
        //{
        //    db.Update(clase_estudiante);
        //}

        //public List<Clase_Estudiante> ObtenerClase_Estudiante()
        //{
        //    return db.Select<Clase_Estudiante>();
        //}

        //public Clase_Estudiante ObtenerClase_Estudiante(int idClase)
        //{
        //    return db.Select<Clase_Estudiante>(x => x.IdClase_Estudiante == idClase).FirstOrDefault();
        //}

        //Clase_Estudiante IClase_Estudiante.ObtenerClase_Estudiante()
        //{
        //    throw new NotImplementedException();
        //}

        //List<Clase_Estudiante> IClase_Estudiante.ObtenerClase_Estudiante(int idClase)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
