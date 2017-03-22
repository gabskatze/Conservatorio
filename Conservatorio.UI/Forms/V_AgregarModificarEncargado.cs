using Conservatorio.DATOS;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarEncargado : Form
    {
        private readonly V_AgregarModificarEstudiante vAgregarModificarEstudiante;
        private Encargado Encargado { get; set; }

        public V_AgregarModificarEncargado(V_AgregarModificarEstudiante vAgregarModificarEstudiante, Encargado encargado = null)
        {
            InitializeComponent();

            this.vAgregarModificarEstudiante = vAgregarModificarEstudiante;
            Encargado = encargado;
        }

        private void V_AgregarModificarEncargado_Load(object sender, EventArgs e)
        {
            Text = Encargado == null ? "Agregar Encargado" : "Modificar Encargado";

            if (Encargado == null)
            {
                return;
            }

            tbxNombre.Text = Encargado.Nombre;
            tbxParentesco.Text = Encargado.Parentesco;
            tbxEmail.Text = Encargado.Email;
            tbxTel1.Text = Encargado.Telefono1.ToString();
            tbxTel2.Text = Encargado.Telefono2.ToString();
            tbxTel3.Text = Encargado.Telefono3.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Encargado == null)
            {
                Encargado = new Encargado
                {
                    Estado = true
                };
            }

            Encargado.Nombre = tbxNombre.Text;
            Encargado.Parentesco = tbxParentesco.Text;
            Encargado.Email = tbxEmail.Text;
            Encargado.Telefono1 = int.Parse(tbxTel1.Text);
            Encargado.Telefono2 = tbxTel2.Text == "" ? (int?)null : int.Parse(tbxTel2.Text);
            Encargado.Telefono3 = tbxTel3.Text == "" ? (int?)null : int.Parse(tbxTel3.Text);

            vAgregarModificarEstudiante.Encargado = Encargado;
            Close();
        }
    }
}
