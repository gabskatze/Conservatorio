using System;
using System.Windows.Forms;
using Conservatorio.BL;

namespace Conservatorio.UI.Helpers
{
    public static class FormExtensions
    {
        private const string MensajeError = "Ocurrió un error en la aplicación: {0}";
        private const string TituloVentanaError = "Error";

        private const string MensajeValidacion = "Error de validación: \n{0}";

        public static void MostrarError(this Form form, Exception ex)
        {
            if (ex is ValidacionException)
            {
                var valEx = (ValidacionException)ex;
                MessageBox.Show(string.Format(MensajeValidacion, string.Join("\n", valEx.Mensajes)), TituloVentanaError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format(MensajeError, ex.Message), TituloVentanaError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
