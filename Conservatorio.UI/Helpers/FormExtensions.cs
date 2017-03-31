using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Helpers
{
    public static class FormExtensions
    {
        private const string MensajeError = "Ocurrió un error: {0}";
        private const string TituloVentanaError = "Error";

        public static void MostrarError(this Form form, Exception ex)
        {
            MessageBox.Show(string.Format(MensajeError, ex.Message), TituloVentanaError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
