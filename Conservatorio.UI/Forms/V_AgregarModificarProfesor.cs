using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarProfesor : Form
    {
        private readonly IProfesorBL profesorBL;
        private readonly IInstrumentoBL instrumentoBL;
        private readonly V_Profesores vProfesor;
        private Profesor profesor;

        public V_AgregarModificarProfesor(V_Profesores vProfesor, Profesor profesor = null)
        {
            InitializeComponent();

            this.vProfesor = vProfesor;
            this.profesor = profesor;
            profesorBL = new ProfesorBL();
            instrumentoBL = new InstrumentoBL();

            CargarInstrumentos();
        }

        private void CargarInstrumentos()
        {
            clbInstrumentos.DataSource = instrumentoBL.ObtenerInstrumentos();
            clbInstrumentos.DisplayMember = "NombreInstrumento";
            clbInstrumentos.ValueMember = "IdInstrumento";
        }

        #region Action Methods

        private void V_AgregarProfesor_Load(object sender, System.EventArgs e)
        {
            Text = profesor == null ? "Agregar Profesor" : "Modificar Profesor";

            if (profesor == null)
            {
                return;
            }

            tbxNombre.Text = profesor.Nombre;
            tbxCedula.Text = profesor.Cedula.ToString();
            tbxDireccion.Text = profesor.Direccion;
            tbxOcupacion.Text = profesor.Ocupacion;
            dtpFechaNacimiento.Value = profesor.FechaNacimiento.Value;
            tbxEmail.Text = profesor.Email;
            tbxTelefono1.Text = profesor.Telefono1.ToString();
            tbxTelefono2.Text = profesor.Telefono2.ToString();
            tbxTelefono3.Text = profesor.Telefono3.ToString();
        }

        private void btnAgregarProf_Click(object sender, System.EventArgs e)
        {
            if (profesor == null)
            {
                profesor = new Profesor
                {
                    Estado = true
                };
            }

            profesor.Cedula = int.Parse(tbxCedula.Text);
            profesor.Direccion = tbxDireccion.Text;
            profesor.Email = tbxEmail.Text;
            profesor.FechaNacimiento = dtpFechaNacimiento.Value;
            profesor.GradoAcademico = string.Empty;
            profesor.Nombre = tbxNombre.Text;
            profesor.Ocupacion = tbxOcupacion.Text;
            profesor.Telefono1 = int.Parse(tbxTelefono1.Text);
            profesor.Telefono2 = string.IsNullOrEmpty(tbxTelefono2.Text) ? (int?) null : int.Parse(tbxTelefono2.Text);
            profesor.Telefono3 = string.IsNullOrEmpty(tbxTelefono3.Text) ? (int?) null : int.Parse(tbxTelefono3.Text);

            if (profesor.IdPersona == 0)
            {
                profesorBL.CrearProfesor(profesor);
            }
            else
            {
                profesorBL.ModificarProfesor(profesor);
            }

            Close();
            vProfesor.RefrescarProfesores();
        }

        #endregion
    }
}
