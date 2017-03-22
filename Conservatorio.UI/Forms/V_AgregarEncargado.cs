using Conservatorio.DATOS;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarEncargado : Form
    {
        private readonly V_AgregarModificarEstudiante vAgregarModificarEstudiante;

        public V_AgregarEncargado(V_AgregarModificarEstudiante vAgregarModificarEstudiante)
        {
            InitializeComponent();

            this.vAgregarModificarEstudiante = vAgregarModificarEstudiante;
        }

        private void btnAgregarEnc_Click(object sender, EventArgs e)
        {
            var miEncargado = new Encargado
            {
                Nombre = tbxAg_NombreEnc.Text,
                Email = tbxAg_EmailEnc.Text,
                Parentesco = tbxParentesco.Text,
                Estado = true,
                Telefono1 = Int32.Parse(tbxAg_Tel1Enc.Text),
                Telefono2 = tbxAg_Tel2Enc.Text == "" ? (int?)null : Int32.Parse(tbxAg_Tel2Enc.Text),
                Telefono3 = tbxAg_Tel3Enc.Text == "" ? (int?)null : Int32.Parse(tbxAg_Tel3Enc.Text)
            };

            vAgregarModificarEstudiante.Encargado = miEncargado;
            Close();
        }
    }
}
