namespace Conservatorio.DATOS
{
    public class RegistroNota
    {
        public int IdRegistroNota { get; set; }
        public Clase Clase { get; set; }
        public Estudiante Estudiante { get; set; }
        public float Nota { get; set; }
    }
}
