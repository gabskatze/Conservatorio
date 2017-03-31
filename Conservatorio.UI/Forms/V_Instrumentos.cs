using Conservatorio.BL.Interfaces;
using Conservatorio.UI.FormModels;
using System;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;

namespace Conservatorio.UI.Forms
{
    public partial class V_Instrumentos : Form
    {
        private readonly IInstrumentoBL instrumentosBL;

        public V_Instrumentos()
        {
            InitializeComponent();
            instrumentosBL = CapaLogica.InstrumentoBl;
        }

        public void RefrescarInstrumentos()
        {
            var keyword = tbxBuscar.Text;
            var list = instrumentosBL.ObtenerInstrumentos(keyword);
            dgvInstrumentos.DataSource = list.Select(x => new InstrumentoModel
            {
                IdInstrumento = x.IdInstrumento,
                NombreInstrumento = x.NombreInstrumento
            }).ToList();

        }

        #region Action Events

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form f = new V_AgregarInstrumento(this);
            f.ShowDialog();
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            RefrescarInstrumentos();
        }

        private void V_Instrumentos_Load(object sender, EventArgs e)
        {
            RefrescarInstrumentos();
        }

        #endregion
    }
    
}
