using System;
using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;
using System.Linq;

namespace Conservatorio.BL.Clases
{
    public class ClaseBL : IClaseBL
    {
        private readonly IClaseDS _claseDs = new ClaseDS();

        internal ClaseBL()
        {
        }

        private bool ValidarClase(Clase clase, out string msj)
        {
            var result = true;
            msj = null;

            var clasesEnConflicto = _claseDs.ObtenerClases(x => x.Periodo == clase.Periodo && x.Ano == clase.Ano);
            if (clasesEnConflicto.Any())
            {
                result = false;
                msj = "";
            }

            return result;
        }

        public void CrearClase(Clase clase)
        {
            string msj;
            if (!ValidarClase(clase, out msj))
            {
                throw new ValidacionException(msj);
            }

            _claseDs.CrearClase(clase);
        }

        public void ModificarClase(Clase clase)
        {
            string msj;
            if (!ValidarClase(clase, out msj))
            {
                throw new ValidacionException(msj);
            }

            _claseDs.ModificarClase(clase);
        }

        public void EliminarClase(Clase clase)
        {
            _claseDs.EliminarClase(clase);
        }

        public List<Clase> ObtenerClases(string keyword)
        {
            return _claseDs.ObtenerClases(x => x.Profesor.Nombre.Contains(keyword) || x.Curso.NombreCurso.Contains(keyword) || x.Dia.Contains(keyword));
        }

        public List<Clase> ObtenerClasesDisponibles(Estudiante estudiante, List<Instrumento> instrumentos)
        {
            var idsInstrumentos = instrumentos.Select(x => x.IdInstrumento);
            return _claseDs.ObtenerClases(x => idsInstrumentos.Contains(x.Curso.Instrumento.IdInstrumento));
        }
    }
}
