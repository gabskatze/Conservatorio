using Conservatorio.BL.Interfaces;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class PagoMensualidadBL : IPagoMensualidadBL
    {
        private readonly IPagoMensualidadDS _pagoMensualidadDs = new PagoMensualidadDS();

    }
}
