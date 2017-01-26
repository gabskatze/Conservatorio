using System;

namespace Conservatorio.DATOS
{
    public class Pago_Mensualidad
    {
        public int IdMensualidad { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime Mes { get; set; }
        public Estudiante Estudiante { get; set; }
        public string Comentario { get; set; }
        public string TipoPago { get; set; }
    }
}
