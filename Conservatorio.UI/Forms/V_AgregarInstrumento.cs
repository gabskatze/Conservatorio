using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;
using Conservatorio.BL;
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

            instrumentoBL = CapaLogica.InstrumentoBl;
            vInst = vInstrumentos;
        }

        private void ConfigurarValidacion()
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

        #region Action Methods

        private void btnAgregarInst_Click(object sender, EventArgs e)
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

        private void V_AgregarInstrumento_Load(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
