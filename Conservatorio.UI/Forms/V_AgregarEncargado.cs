using Conservatorio.DATOS;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarEncargado : Form
    {
        private V_AgregarEstudiante vAgEst;
        public V_AgregarEncargado(V_AgregarEstudiante vAg_Est)
        {
            InitializeComponent();
            vAgEst = vAg_Est;
        }

        private void btnAgregarEnc_Click(object sender, EventArgs e)
        {
            Encargado miEncargado = new Encargado
            {
                Nombre = tbxAg_NombreEnc.Text,
                Email = tbxAg_EmailEnc.Text,
                Parentesco = tbxParentesco.Text,
                Estado = true,
                Telefono1 = Int32.Parse(tbxAg_Tel1Enc.Text),
                Telefono2 = tbxAg_Tel2Enc.Text == "" ? (int?)null : Int32.Parse(tbxAg_Tel2Enc.Text),
                Telefono3 = tbxAg_Tel3Enc.Text == "" ? (int?)null : Int32.Parse(tbxAg_Tel3Enc.Text)
            };
            vAgEst.Encargado = miEncargado;

            Close();
        }
    }
}
