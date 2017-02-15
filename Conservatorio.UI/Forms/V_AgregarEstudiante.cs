using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarEstudiante : Form
    {
        private IEstudianteBL misEstudiates;
        private V_Estudiantes vEst;
        public Encargado Encargado { get; set; }
       
        public V_AgregarEstudiante(V_Estudiantes v_Est)
        {
            InitializeComponent();
            misEstudiates = new EstudianteBL();
            vEst = v_Est;
        }

        private void btnAgregarEst_Click(object sender, EventArgs e)
        {
            Estudiante nuevoEstudiante = new Estudiante
            {
                Nombre = tbxAg_NombreEst.Text,
                Cedula = int.Parse(tbxAg_CedulaEst.Text),
                Direccion = tbxAg_DireccionEst.Text,
                Email = tbxAg_EmailEst.Text,
                Estado = true,
                FechaNacimiento = dtpFechNac.Value,
                Ocupacion = tbxAg_OcupacionEst.Text,
                Telefono1 = int.Parse(tbxAg_Tel1Est.Text),
                Telefono2 = tbxAg_Tel2Est.Text == "" ? (int?)null : int.Parse(tbxAg_Tel2Est.Text),
                Telefono3 = tbxAg_Tel3Est.Text == "" ? (int?)null : int.Parse(tbxAg_Tel3Est.Text),
                Tipo = cbxTipo.SelectedItem.ToString(),
                Encargado = Encargado
            };
            misEstudiates.CrearEstudiante(nuevoEstudiante);

            Close();
            vEst.RefrescarEstudiantes();
        }

        private void btnEncargado_Click(object sender, EventArgs e)
        {
            Form f = new V_AgregarEncargado(this);
            f.ShowDialog();
        }
    }
}
