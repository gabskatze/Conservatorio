using Conservatorio.DATOS;

namespace Conservatorio.DS.Interfaces
{
    public interface IEncargado
    {
        void CrearEncargado(Encargado nuevoEncargado);

        void EliminarEncargado(int idEncargado);

        void ModificarEncargado(Encargado encargado);

        Encargado ObtenerEncargado(int idEncargado);
    }
}
