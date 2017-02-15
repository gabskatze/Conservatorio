using Conservatorio.BL.Interfaces;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class CursoBL : ICursoBL
    {
        private readonly ICursoDS _cursoDs = new CursoDS();

    }
}
