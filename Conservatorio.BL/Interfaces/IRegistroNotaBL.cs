using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IRegistroNotaBL
    {
        void CrearRegistroNota(RegistroNota registroNota);
        List<Curso> ObtenerCursosAprobados(Estudiante estudiante);
    }
}
