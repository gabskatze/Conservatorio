using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarClase : Form
    {
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

            _claseBL = CapaLogica.ClaseBl;
            _instrumentoBL = CapaLogica.InstrumentoBl;
            _cursoBL = CapaLogica.CursoBl;
            _profesorBL = CapaLogica.ProfesorBl;
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
                },
                new Validador
                {
                    Control = tbxAno,
                    MetodoValidacion = (out string errorMsg) => !tbxAno.ValidarRequerido(out errorMsg) || !tbxAno.ValidarEntero(out errorMsg)
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
            
        private void CargarPeriodos()
        {
            var list = new List<int>();
            var cantidadPeriodos = int.Parse(ConfigurationManager.AppSettings["cantidadPeriodos"]);
            for (var i = 1; i <= cantidadPeriodos; i++)
            {
                list.Add(i);
            }
            cbxPeriodo.DataSource = list;
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
            try
            {
                CargarInstrumentos();
                CargarDias();
            	CargarPeriodos();

                if (clase == null)
                {
                    Text = "Agregar Clase";
                    // Poner la hora de inicio a las 8 AM
                    var horaInicio = DateTime.Now.EnPunto();
                    horaInicio = horaInicio.AddHours((horaInicio.Hour - 8)*-1);
                    dtpHoraInicio.Value = horaInicio;
                    dtpHoraFinal.Value = horaInicio.AddHours(1);
                    tbxAno.Text = horaInicio.Year.ToString();
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
                    cbxPeriodo.SelectedItem = clase.Periodo;
                    tbxAno.Text = clase.Ano.ToString();
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void cbxInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarCursos();
                CargarProfesores();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }
		
        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dateTime = dtpHoraInicio.Value;
                dtpHoraFinal.Value = dateTime.AddHours(1);
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
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
                clase.HoraInicio = dtpHoraInicio.Value.ToString(dtpHoraInicio.CustomFormat);
                clase.HoraFinal = dtpHoraFinal.Value.ToString(dtpHoraInicio.CustomFormat);
                clase.Aula = int.Parse(tbxAula.Text);
                clase.Periodo = (int) cbxPeriodo.SelectedValue;
                clase.Ano = int.Parse(tbxAno.Text);

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
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

    }
}
