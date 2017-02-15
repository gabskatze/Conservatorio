﻿using System;
using System.Collections.Generic;
using System.Linq;
using Conservatorio.DS.Interfaces;
using Conservatorio.DATOS;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class InstrumentoDS : IInstrumentoDS
    {
        public void CrearInstrumento(Instrumento nuevoInstrumento)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(nuevoInstrumento);
            }
        }

        public void ModificarInstrumento(Instrumento instrumento)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(instrumento);
            }
        }

        public Instrumento ObtenerInstrumento(int idInstrumento)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Get<Instrumento>(idInstrumento);
            }
        }

        public List<Instrumento> ObtenerInstrumentos(Expression<Func<Instrumento,bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Instrumento>().Where(exp).ToList();
            }
        }
    }
}
