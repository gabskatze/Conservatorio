using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarInstrumento : Form
    {
        private readonly IInstrumentoBL instrumentoBL;
        private readonly V_Instrumentos vInst;

        public V_AgregarInstrumento(V_Instrumentos vInstrumentos)
        {
            InitializeComponent();

            instrumentoBL = new InstrumentoBL();
            vInst = vInstrumentos;
        }

        #region Action Methods

        private void btnAgregarInst_Click(object sender, EventArgs e)
        {
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
