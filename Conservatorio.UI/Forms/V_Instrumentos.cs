using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_Instrumentos : Form
    {
        private IInstrumento misInstrumentos;

        public V_Instrumentos()
        {
            InitializeComponent();
            misInstrumentos = new InstrumentoBL();
        }

        public void RefrescarInstrumentos()
        {
            var keyword = tbxBuscarInstrumento.Text;
            var list = misInstrumentos.ObtenerInstrumentos(keyword);
            dgvInstrumentos.DataSource = list;

        }

        #region Events
        private void tbxBuscarInstrumento_TextChanged(object sender, EventArgs e)
        {
            RefrescarInstrumentos();
        }

        private void btnAgregarInstrumento_Click(object sender, EventArgs e)
        {
            Form f = new V_AgregarInstrumento(this);
            f.ShowDialog();
        }

        private void V_Instrumentos_Load(object sender, EventArgs e)
        {
            RefrescarInstrumentos();
        }
        #endregion

        private void dgvInstrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
