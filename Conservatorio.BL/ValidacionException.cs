using System;

namespace Conservatorio.BL
{
    public class ValidacionException : Exception
    {
        public string Mensaje { get; set; }

        public ValidacionException(string mensaje)
        {
            Mensaje = mensaje;
        }

    }
}
