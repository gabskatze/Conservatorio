using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class ClaseBL : IClaseBL
    {
        private readonly IClaseDS _claseDs = new ClaseDS();

        public void CrearClase(Clase clase)
        {
            _claseDs.CrearClase(clase);
        }

        public void ModificarClase(Clase clase)
        {
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
    }
}
