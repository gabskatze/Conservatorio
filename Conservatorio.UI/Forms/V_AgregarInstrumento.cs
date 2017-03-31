using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;
using Conservatorio.UI.FormValidation;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarInstrumento : Form
    {
        private readonly IInstrumentoBL instrumentoBL;
        private readonly V_Instrumentos vInst;

        public V_AgregarInstrumento(V_Instrumentos vInstrumentos)
        {
            InitializeComponent();
            ConfigurarValidacion();

            instrumentoBL = new InstrumentoBL();
            vInst = vInstrumentos;
        }
        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConfigurarValidacion()
        {
            try
            {
                var validadores = new[]
                {
                    new Validador
                    {
                        Control = tbxNombreInst,
                        MetodoValidacion = (out string errorMsg) => !tbxNombreInst.ValidarRequerido(out errorMsg)
                    }
                };

                Validation.Config(errorProvider, validadores);
            }
            catch (Exception ex)
            {

                MostrarError(ex);
            }
            
        }

        #region Action Methods

        private void btnAgregarInst_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                var nuevoInstrumento = new Instrumento
                {
                    NombreInstrumento = tbxNombreInst.Text
                };
                instrumentoBL.CrearInstrumento(nuevoInstrumento);

                Close();
                vInst.RefrescarInstrumentos();
            }
            catch (Exception ex)
            {

                MostrarError(ex);
            }
            
        }

        private void V_AgregarInstrumento_Load(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
