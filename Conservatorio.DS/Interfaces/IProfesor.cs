using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatorio.DS.Interfaces
{
    public interface IProfesor
    {
        void CrearProfesor(Profesor nuevoProfesor);

        void EliminarProfesor(int idProfesor);

        void ModificarProfesor(Persona profesor);

        Profesor ObtenerProfesor(int idProfesor);
    }
}
