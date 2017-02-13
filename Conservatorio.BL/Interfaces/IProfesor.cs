using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IProfesor
    {
        void CrearProfesor(Profesor profesor);
        void ModificarProfesor(Profesor profesor);
        void EliminarProfesor(Profesor profesor);
        List<Profesor> ObtenerProfesores(string keyword);
    }
}
