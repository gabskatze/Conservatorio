using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;

namespace Conservatorio.BL.Clases
{
    public class ProfesorBL : IProfesor
    {
        private DS.Interfaces.IProfesor profesoresDS = new ProfesorDS();

        public void CrearProfesor(Profesor profesor)
        {
            profesoresDS.CrearProfesor(profesor);
        }

        public void ModificarProfesor(Profesor profesor)
        {
            profesoresDS.ModificarProfesor(profesor);
        }

        public void EliminarProfesor(Profesor profesor)
        {
            profesoresDS.EliminarProfesor(profesor);
        }

        public List<Profesor> ObtenerProfesores(string keyword)
        {
            return profesoresDS.ObtenerProfesores(x => x.Nombre.Contains(keyword));
        }
    }
}
