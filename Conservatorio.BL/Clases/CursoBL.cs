using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class CursoBL : ICursoBL
    {
        private readonly ICursoDS _cursoDs = new CursoDS();

        internal CursoBL()
        {
        }

        public void CrearCurso(Curso curso)
        {
            _cursoDs.CrearCurso(curso);
        }

        public void ModificarCurso(Curso curso)
        {
            _cursoDs.ModificarCurso(curso);
        }

        public void EliminarCurso(Curso curso)
        {
            _cursoDs.EliminarCurso(curso);
        }

        public List<Curso> ObtenerCursos()
        {
            return _cursoDs.ObtenerCursos();
        }

        public List<Curso> ObtenerCursosPorInstrumento(int idInstrumento)
        {
            return _cursoDs.ObtenerCursos(x => x.Instrumento.IdInstrumento == idInstrumento);
        }
    }
}
