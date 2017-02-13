using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_ModificarEstudiante : Form
    {
        private IEstudiante misEstudiates;
        private V_Estudiantes vEst;
        private Estudiante estudiante;
        public Encargado Encargado { get; set; }
        public V_ModificarEstudiante(V_Estudiantes v_Est, Estudiante estudiante)
        {
            InitializeComponent();
            misEstudiates = new EstudianteBL();
            vEst = v_Est;
            this.estudiante = estudiante;
        }

        private void V_ModificarEstudiante_Load(object sender, EventArgs e)
        {
            tbxMod_NombreEst.Text = estudiante.Nombre;
            tbxMod_DireccionEst.Text = estudiante.Direccion;
            tbxMod_CedulaEst.Text = estudiante.Cedula.ToString();
            tbxMod_EmailEst.Text = estudiante.Email;
            tbxMod_OcupacionEst.Text = estudiante.Ocupacion;
            tbxMod_Tel1Est.Text = estudiante.Telefono1.ToString();
            tbxMod_Tel2Est.Text = estudiante.Telefono2.ToString();
            tbxMod_Tel3Est.Text = estudiante.Telefono3.ToString();

        }

        private void btnModificarEst_Click(object sender, EventArgs e)
        {
            
            estudiante.Nombre = tbxMod_NombreEst.Text;
            estudiante.Direccion = tbxMod_DireccionEst.Text;
            estudiante.Cedula = Int32.Parse(tbxMod_CedulaEst.Text);
            estudiante.Email = tbxMod_EmailEst.Text;
            estudiante.Ocupacion = tbxMod_OcupacionEst.Text;
            estudiante.Telefono1 = Int32.Parse(tbxMod_Tel1Est.Text);
            estudiante.Telefono2 = tbxMod_Tel2Est.Text == "" ? (int?)null : int.Parse(tbxMod_Tel2Est.Text);
            estudiante.Telefono2 = tbxMod_Tel3Est.Text == "" ? (int?)null : int.Parse(tbxMod_Tel3Est.Text);

            misEstudiates.ModificarEstudiante(estudiante);

            Close();
            vEst.RefrescarEstudiantes();
        }
    }
}
