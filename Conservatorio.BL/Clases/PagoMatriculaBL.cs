using System;
using System.Configuration;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class PagoMatriculaBL : IPagoMatriculaBL
    {
        private readonly IPagoMatriculaDS _pagoMatriculaDs = new PagoMatriculaDS();

        internal PagoMatriculaBL()
        {
        }

        public void CrearPagoMatricula(PagoMatricula pagoMatricula)
        {
            _pagoMatriculaDs.CrearPagoMatricula(pagoMatricula);
        }

        public Tuple<int, int> ObtenerPeriodoActual()
        {
            var fechaActual = DateTime.Now;
            var cantidadPeriodos = int.Parse(ConfigurationManager.AppSettings["cantidadPeriodos"]);
            // TODO: datos quemados
            var periodo = 1;
            var ano = 2017;

            return new Tuple<int, int>(periodo, ano);
        }
    }
}
