using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.FormValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;

namespace Conservatorio.UI.Forms
{
    public partial class V_Matricula : Form
    {
        private readonly IEstudianteBL estudianteBL;
        private readonly IClaseBL claseBL;
        private List<Estudiante> listaEstudiantes;

        private readonly IInstrumentoBL instrumentoBL;
        public V_Matricula()
        {
            InitializeComponent();
            ConfigurarValidacion();

            estudianteBL = CapaLogica.EstudianteBl;
            instrumentoBL = CapaLogica.InstrumentoBl;
            claseBL = CapaLogica.ClaseBl;
        }

        private void V_Matricula_Load(object sender, EventArgs e)
        {
            RefrescarEstudiantes();
            CargarInstrumentos();
            CargarPagos();
        }

        public void RefrescarEstudiantes()
        {
            var keyword = tbxBuscarEst_Matric.Text;
            listaEstudiantes = estudianteBL.ObtenerEstudiantes(keyword, false);
            dgvEst_Matric.DataSource = listaEstudiantes.Select(x => new EstudianteModel
            {
                IdEstudiante = x.IdPersona,
                Nombre = x.Nombre,
                Cedula = x.Cedula,
                Direccion = x.Direccion,
                Ocupacion = x.Ocupacion,
                GradoAcademico = x.GradoAcademico,
                Email = x.Email,
                Estado = x.Estado ? "Activo" : "Inactivo",
                FechaNacimiento = x.FechaNacimiento.Value.ToShortDateString(),
                Telefono1 = x.Telefono1,
                Telefono2 = x.Telefono2,
                Telefono3 = x.Telefono3,
                NombreEncargado = x.Encargado == null ? string.Empty : x.Encargado.Nombre,
                Parentesco = x.Encargado == null ? string.Empty : x.Encargado.Parentesco,
                Telefono1Encargado = x.Encargado == null ? (int?)null : x.Encargado.Telefono1,
                Telefono2Encargado = x.Encargado == null ? null : x.Encargado.Telefono2,
                Telefono3Encargado = x.Encargado == null ? null : x.Encargado.Telefono3,
                EmailEncargado = x.Encargado == null ? string.Empty : x.Encargado.Email
            }).ToList();
        }

        private Estudiante ObtenerEstudianteSeleccionado()
        {
            if (dgvEst_Matric.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvEst_Matric.SelectedRows[0].Index;
            return listaEstudiantes[selectedIndex];
        }

        private void tbxBuscarEst_Matric_TextChanged(object sender, EventArgs e)
        {
            RefrescarEstudiantes();
        }

        private void dgvEst_Matric_DoubleClick(object sender, EventArgs e)
        {
            var estudiante = ObtenerEstudianteSeleccionado();
            if (estudiante == null)
            {
                return;
            }

            lblNombreEstudiante.Text = estudiante.Nombre;
            lblTipoEstudiante.Text = estudiante.Tipo;
        }

        private void CargarInstrumentos()
        {
            clbInstrumentos.DataSource = instrumentoBL.ObtenerInstrumentos();
            clbInstrumentos.DisplayMember = "NombreInstrumento";
            clbInstrumentos.ValueMember = "IdInstrumento";
        }

        private void CargarClases()
        {

        }

        private void CargarPagos()
        {
            cbTipoPago.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<TipoPagoEnum>();
            cbTipoPago.ValueMember = "Key";
            cbTipoPago.DisplayMember = "Value";
        }

        private List<Instrumento> ObtenerInstrumentosSeleccionados()
        {
            return clbInstrumentos.CheckedItems.Cast<Instrumento>().ToList();
        }

        private void clbInstrumentos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker) (() =>
            {
                var estudiante = ObtenerEstudianteSeleccionado();
                if (estudiante == null)
                {
                    return;
                }

                var instrumentosSeleccionados = ObtenerInstrumentosSeleccionados();
                var clases = claseBL.ObtenerClasesDisponibles(estudiante, instrumentosSeleccionados);
                dgv_Clase_Mat.DataSource = clases.Select(x => new ClaseModel
                {
                    Profesor = x.Profesor.Nombre,
                    Curso = x.Curso.NombreCurso,
                    Dia = x.Dia,
                    HoraInicio = x.HoraInicio,
                    HoraFinal = x.HoraFinal,
                    Aula = x.Aula
                }).ToList();
            }));
        }


        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbMontoMat,
                    MetodoValidacion = (out string errorMsg) => !tbMontoMat.ValidarEntero(out errorMsg) && !tbMontoMat.ValidarRequerido(out errorMsg)
                },
                new Validador
                {
                    Control = tbReferencia,
                    MetodoValidacion = (out string errorMsg) => !tbReferencia.ValidarRequerido(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }
        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
        }
    }
}
