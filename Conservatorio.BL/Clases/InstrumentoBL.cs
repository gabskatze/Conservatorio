using System;
using System.Collections.Generic;
using System.Linq;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Clases
{
    public class InstrumentoBL : IInstrumento
    {
        DS.Interfaces.IInstrumento iInstrumento = new DS.Clases.InstrumentoDS();

        public void CrearInstrumento(Instrumento nuevoInstrumento)
        {
            iInstrumento.CrearInstrumento(nuevoInstrumento);
        }

        public List<Instrumento> ObtenerInstrumentos(string keyword)
        {
            return iInstrumento.ObtenerInstrumentos(x => x.NombreInstrumento.Contains(keyword));
        }
    }
}
