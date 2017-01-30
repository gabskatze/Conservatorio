namespace Conservatorio.DATOS
{
    public class Clase
    {
        public virtual int IdClase { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual string Dia { get; set; }
        public virtual string Hora { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
