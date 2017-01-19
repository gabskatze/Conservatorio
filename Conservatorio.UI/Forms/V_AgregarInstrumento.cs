using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarInstrumento : Form
    {
        private IInstrumento misInstrumentos;
        private V_Instrumentos vInst;

        public V_AgregarInstrumento(V_Instrumentos vInstrumentos)
        {
            InitializeComponent();
            misInstrumentos = new InstrumentoBL();
            vInst = vInstrumentos;
        }

        private void btnAgregarInst_Click(object sender, EventArgs e)
        {
            Instrumento nuevoInstrumento = new Instrumento
            {
                NombreInstrumento = tbxNombreInst.Text
            };

            misInstrumentos.CrearInstrumento(nuevoInstrumento);

            this.Close();
            vInst.RefrescarInstrumentos();
        }
    }
}
