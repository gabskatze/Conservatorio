using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatorio.UI.FormModels
{
    public class EstudianteModel
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public int? Cedula { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int Telefono1 { get; set; }
        public int? Telefono2 { get; set; }
        public int? Telefono3 { get; set; }
        public string NombreEncargado { get; set; }
        public string Parentesco { get; set; }
        public int Telefono1Encargado { get; set; }
        public int? Telefono2Encargado { get; set; }
        public int? Telefono3Encargado { get; set; }
        public string EmailEncargado { get; set; }


    }
}
