using System;
using System.Windows.Forms;
using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.UI.FormValidation;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarClase : Form
    {
        private const string TIME_FORMAT = "hh:mm tt";
        private const string DEFAULT_TIME_FORMAT = "hh:00 tt";

        private readonly IClaseBL _claseBL;
        private readonly IInstrumentoBL _instrumentoBL;
        private readonly ICursoBL _cursoBL;
        private readonly IProfesorBL _profesorBL;
        private readonly V_Clases _vClases;
        private Clase clase;

        public V_AgregarModificarClase(V_Clases vClases, Clase clase)
        {
            InitializeComponent();
            ConfigurarValidacion();

            _claseBL = new ClaseBL();
            _instrumentoBL = new InstrumentoBL();
            _cursoBL = new CursoBL();
            _profesorBL = new ProfesorBL();
            _vClases = vClases;
            this.clase = clase;
        }

        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbxAula,
                    MetodoValidacion = (out string errorMsg) => !tbxAula.ValidarRequerido(out errorMsg) || !tbxAula.ValidarEntero(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        private void CargarInstrumentos()
        {
            cbxInstrumento.DataSource = _instrumentoBL.ObtenerInstrumentos();
            cbxInstrumento.ValueMember = "IdInstrumento";
            cbxInstrumento.DisplayMember = "NombreInstrumento";
        }

        private void CargarDias()
        {
            cbxDias.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<DiasEnum>();
            cbxDias.ValueMember = "Key";
            cbxDias.DisplayMember = "Value";
        }

        private void CargarCursos()
        {
            var instrumentoSeleccionado = ObtenerInstrumentoSeleccionado();
            if (instrumentoSeleccionado == null)
            {
                return;
            }

            cbxCursos.DataSource = _cursoBL.ObtenerCursosPorInstrumento(instrumentoSeleccionado.IdInstrumento);
            cbxCursos.ValueMember = "IdCurso";
            cbxCursos.DisplayMember = "NombreCurso";
        }

        private void CargarProfesores()
        {
            var instrumentoSeleccionado = ObtenerInstrumentoSeleccionado();
            if (instrumentoSeleccionado == null)
            {
                return;
            }

            cbxProfesores.DataSource = _profesorBL.ObtenerProfesoresPorInstrumento(instrumentoSeleccionado.IdInstrumento);
            cbxProfesores.ValueMember = "IdPersona";
            cbxProfesores.DisplayMember = "Nombre";
        }

        private Instrumento ObtenerInstrumentoSeleccionado()
        {
            return cbxInstrumento.SelectedItem as Instrumento;
        }

        #region Action Methods

        private void V_AgregarModificarClase_Load(object sender, EventArgs e)
        {
            CargarInstrumentos();
            CargarDias();

            if (clase == null)
            {
                Text = "Agregar Clase";
                dtpHoraInicio.Text = DateTime.Now.ToString(DEFAULT_TIME_FORMAT);
                dtpHoraFinal.Text = DateTime.Now.AddHours(1).ToString(DEFAULT_TIME_FORMAT);
            }
            else
            {
                Text = "Modificar Clase";
                cbxInstrumento.SelectedValue = clase.Curso.Instrumento.IdInstrumento;
                cbxCursos.SelectedValue = clase.Curso.IdCurso;
                cbxProfesores.SelectedValue = clase.Profesor.IdPersona;
                cbxDias.SelectedValue = clase.Dia;
                dtpHoraInicio.Text = clase.HoraInicio;
                dtpHoraFinal.Text = clase.HoraFinal;
                tbxAula.Text = clase.Aula.ToString();
            }
        }

        private void cbxInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos();
            CargarProfesores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (clase == null)
            {
                clase = new Clase();
            }

            clase.Curso = cbxCursos.SelectedItem as Curso;
            clase.Profesor = cbxProfesores.SelectedItem as Profesor;
            clase.Dia = cbxDias.SelectedValue.ToString();
            clase.HoraInicio = dtpHoraInicio.Value.ToString(TIME_FORMAT);
            clase.HoraFinal = dtpHoraFinal.Value.ToString(TIME_FORMAT);
            clase.Aula = int.Parse(tbxAula.Text);

            if (clase.IdClase == 0)
            {
                _claseBL.CrearClase(clase);
            }
            else
            {
                _claseBL.ModificarClase(clase);
            }
            
            Close();
            _vClases.RefrescarClases();
        }

        #endregion
    }
}
