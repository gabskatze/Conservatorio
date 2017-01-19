using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
