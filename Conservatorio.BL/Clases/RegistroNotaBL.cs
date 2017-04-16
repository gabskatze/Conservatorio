using System.Collections.Generic;
using System.Linq;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class RegistroNotaBL : IRegistroNotaBL
    {
        private readonly IRegistroNotaDS _registroNotaDs = new RegistroNotaDS();

        internal RegistroNotaBL()
        {
        }

        public void CrearRegistroNota(RegistroNota registroNota)
        {
            _registroNotaDs.CrearRegistroNota(registroNota);
        }

        public List<Curso> ObtenerCursosAprobados(Estudiante estudiante)
        {
            //TODO: dato quemado (70)
            return _registroNotaDs.ObtenerRegistroNotas(x => x.Estudiante.IdPersona == estudiante.IdPersona && x.Nota > 70)
                .Select(x => x.Clase.Curso)
                .ToList();
        }
    }
}
