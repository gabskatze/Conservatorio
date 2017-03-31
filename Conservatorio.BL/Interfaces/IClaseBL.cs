using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IClaseBL
    {
        void CrearClase(Clase clase);
        void ModificarClase(Clase clase);
        void EliminarClase(Clase clase);
        List<Clase> ObtenerClases(string keyword);
        List<Clase> ObtenerClasesDisponibles(Estudiante estudiante, List<Instrumento> instrumentos);
    }
}
