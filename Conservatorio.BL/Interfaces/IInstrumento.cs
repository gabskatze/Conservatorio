using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatorio.BL.Interfaces
{
    public interface IInstrumento
    {
        List<Instrumento> ObtenerInstrumentos(string keyword);
        void CrearInstrumento(Instrumento nuevoInstrumento);

    }
}
