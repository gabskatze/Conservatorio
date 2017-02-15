using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class InstrumentoBL : IInstrumentoBL
    {
        private readonly IInstrumentoDS _instrumentoDs = new InstrumentoDS();

        public void CrearInstrumento(Instrumento nuevoInstrumento)
        {
            _instrumentoDs.CrearInstrumento(nuevoInstrumento);
        }

        public List<Instrumento> ObtenerInstrumentos(string keyword)
        {
            return _instrumentoDs.ObtenerInstrumentos(x => x.NombreInstrumento.Contains(keyword));
        }

        public List<Instrumento> ObtenerInstrumentos()
        {
            return _instrumentoDs.ObtenerInstrumentos();
        }
    }
}
