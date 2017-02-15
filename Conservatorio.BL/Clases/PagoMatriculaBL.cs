using Conservatorio.BL.Interfaces;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class PagoMatriculaBL : IPagoMatriculaBL
    {
        private readonly IPagoMatriculaDS _pagoMatriculaDs = new PagoMatriculaDS();

    }
}
