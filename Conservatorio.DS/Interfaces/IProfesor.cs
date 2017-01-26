using Conservatorio.DATOS;

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
