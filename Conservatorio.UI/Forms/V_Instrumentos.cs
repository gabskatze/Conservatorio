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
        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RefrescarInstrumentos()
        {
            try
            {
                var keyword = tbxBuscar.Text;
                var list = instrumentosBL.ObtenerInstrumentos(keyword);
                dgvInstrumentos.DataSource = list.Select(x => new InstrumentoModel
                {
                    IdInstrumento = x.IdInstrumento,
                    NombreInstrumento = x.NombreInstrumento
                }).ToList();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            

        }

        #region Action Events

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new V_AgregarInstrumento(this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarInstrumentos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void V_Instrumentos_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarInstrumentos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        #endregion
    }
    
}
