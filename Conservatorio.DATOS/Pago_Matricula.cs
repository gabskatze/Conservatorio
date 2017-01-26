using System;

namespace Conservatorio.DATOS
{
    public class Pago_Matricula
    {
        public int IdMatricula { get; set; }
        public string Periodo { get; set; }
        public int Año { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public Estudiante Estudiante { get; set; }
        public string Comentario { get; set; }
        public string TipoPago { get; set; }
    }
}
