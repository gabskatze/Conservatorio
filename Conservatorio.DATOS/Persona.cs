using System;

namespace Conservatorio.DATOS
{
    public abstract class Persona
    {
        public long IdPersona { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public bool Estado { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono1 { get; set; }
        public int? Telefono2 { get; set; }
        public int? Telefono3 { get; set; }

    }
}
