using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatorio.DS.Interfaces
{
    public interface IPersona
    {
        void CrearPersona(Persona nuevaPersona);

        void EliminarPersona(int idPersona);

        void ModificarPersona(Persona persona);

        Persona ObtenerPersona(int idPersona);
    }
}
