using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;
using Conservatorio.DATOS.Enums;
using Conservatorio.UI.FormValidation;
using Emgu.CV;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarEstudiante : Form
    {
        private readonly IEstudianteBL estudiantesBL;
        private readonly V_Estudiantes vEstudiantes;

        public Encargado Encargado { get; set; }
        private Estudiante estudiante;

        private Capture _capture;
        private Capture CameraCapture
        {
            get
            {
                return _capture ?? (_capture = new Capture());
            }
            set { _capture = value; }
        }

        private bool CaptureInProgress { get; set; }

        public V_AgregarModificarEstudiante(V_Estudiantes vEstudiantes, Estudiante estudiante = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            estudiantesBL = new EstudianteBL();
            this.vEstudiantes = vEstudiantes;
            this.estudiante = estudiante;
        }

        private void CargarTiposEstudiante()
        {
            cbxTipo.DataSource = Enum.GetValues(typeof(TipoEstudianteEnum));
        }

        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbxNombre,
                    MetodoValidacion = (out string errorMsg) => !tbxNombre.ValidarRequerido(out errorMsg)
                },
                new Validador
                {
                    Control = tbxCedula,
                    MetodoValidacion = (out string errorMsg) => !tbxCedula.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxEmail,
                    MetodoValidacion = (out string errorMsg) => !tbxEmail.ValidarEmail(out errorMsg)
                },
                new Validador
                {
                    Control = tbxTel1,
                    MetodoValidacion = (out string errorMsg) => !tbxTel1.ValidarRequerido(out errorMsg) || !tbxTel1.ValidarEntero(out errorMsg) || !tbxTel1.ValidarLargo(8, out errorMsg)
                },
                new Validador
                {
                    Control = dtpFechaNacimiento,
                    MetodoValidacion = (out string errorMsg) => !dtpFechaNacimiento.ValidarRequerido(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        #region Action Methods

        private void V_AgregarModificarEstudiante_Load(object sender, EventArgs e)
        {
            CargarTiposEstudiante();

            Text = estudiante == null ? "Agregar Estudiante" : "Modificar Estudiante";

            if (estudiante == null)
            {
                return;
            }

            tbxNombre.Text = estudiante.Nombre;
            tbxCedula.Text = estudiante.Cedula.ToString();
            tbxDireccion.Text = estudiante.Direccion;
            tbxOcupacion.Text = estudiante.Ocupacion;
            dtpFechaNacimiento.Value = estudiante.FechaNacimiento.Value;
            tbxEmail.Text = estudiante.Email;
            tbxGradoAcademico.Text = estudiante.GradoAcademico;
            tbxTel1.Text = estudiante.Telefono1.ToString();
            tbxTel2.Text = estudiante.Telefono2.ToString();
            tbxTel3.Text = estudiante.Telefono3.ToString();
            cbxTipo.SelectedItem = Enum.Parse(typeof(TipoEstudianteEnum), estudiante.Tipo);
            Encargado = estudiante.Encargado;
        }

        

  

private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            if (estudiante == null)
            {
                estudiante = new Estudiante
                {
                    Estado = true
                };
            }

            estudiante.Nombre = tbxNombre.Text;
            estudiante.Cedula = tbxCedula.Text == "" ? (int?)null : int.Parse(tbxCedula.Text);
            estudiante.Direccion = tbxDireccion.Text;
            estudiante.Email = tbxEmail.Text;
            estudiante.FechaNacimiento = dtpFechaNacimiento.Value;
            estudiante.GradoAcademico = tbxGradoAcademico.Text;
            estudiante.Ocupacion = tbxOcupacion.Text;
            estudiante.Telefono1 = int.Parse(tbxTel1.Text);
            estudiante.Telefono2 = tbxTel2.Text == "" ? (int?)null : int.Parse(tbxTel2.Text);
            estudiante.Telefono3 = tbxTel3.Text == "" ? (int?)null : int.Parse(tbxTel3.Text);
            estudiante.Tipo = cbxTipo.SelectedItem.ToString();
            estudiante.Encargado = Encargado;

            if (estudiante.IdPersona == 0)
            {
                estudiantesBL.CrearEstudiante(estudiante);
            }
            else
            {
                estudiantesBL.ModificarEstudiante(estudiante);
            }

            Close();
            vEstudiantes.RefrescarEstudiantes();
        }

        private void btnEncargado_Click(object sender, EventArgs e)
        {
            Form f = new V_AgregarModificarEncargado(this, Encargado);
            f.ShowDialog();
        }

        #endregion

    }
}
