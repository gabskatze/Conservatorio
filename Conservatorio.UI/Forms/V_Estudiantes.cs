using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.DATOS;

namespace Conservatorio.UI.Forms
{
    public partial class V_Estudiantes : Form
    {
        private IEstudiante miEstudiante;
        private List<Estudiante> listaEstudiantes;

        public V_Estudiantes()
        {
            InitializeComponent();
            miEstudiante = new EstudianteBL();
        }

        private Estudiante ObtenerEstudianteSeleccionado()
        {
            if (dgvEstudiantes.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvEstudiantes.SelectedRows[0].Index;
            return listaEstudiantes[selectedIndex];
        }

        public void RefrescarEstudiantes()
        {
            var keyword = tbxBuscarEstudiante.Text;
            listaEstudiantes = miEstudiante.ObtenerEstudiantes(keyword);
            dgvEstudiantes.DataSource = listaEstudiantes.Select(x => new EstudianteModel {
                IdEstudiante = x.IdPersona,
                Nombre = x.Nombre,
                Cedula = x.Cedula,
                Direccion = x.Direccion,
                Ocupacion = x.Ocupacion,
                Email = x.Email,
                Estado = x.Estado ? "Activo": "Inactivo",
                FechaNacimiento = x.FechaNacimiento,
                Telefono1 = x.Telefono1,
                Telefono2 = x.Telefono2,
                Telefono3 = x.Telefono3,
                NombreEncargado = x.Encargado == null ? string.Empty : x.Encargado.Nombre,
                Parentesco = x.Encargado == null ? string.Empty : x.Encargado.Parentesco,
                Telefono1Encargado = x.Encargado == null ? (int?)null : x.Encargado.Telefono1,
                Telefono2Encargado = x.Encargado == null ?  null : x.Encargado.Telefono2,
                Telefono3Encargado = x.Encargado == null ? null : x.Encargado.Telefono3,
                EmailEncargado = x.Encargado == null ? string.Empty : x.Encargado.Email
            }).ToList();
        }

        private void btnAgregarV_Est_Click(object sender, EventArgs e)
        {
            Form f = new V_AgregarEstudiante(this);
            f.ShowDialog();
        }

        private void V_Estudiantes_Load(object sender, EventArgs e)
        {
            RefrescarEstudiantes();
        }

        private void tbxBuscarEstudiante_TextChanged(object sender, EventArgs e)
        {
            RefrescarEstudiantes();
        }

        private void btnBorrarEst_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedIndex = dgvEstudiantes.SelectedRows[0].Index;
            var estudiantes = dgvEstudiantes.DataSource as List<EstudianteModel>;
            var estudianteSeleccionado = estudiantes[selectedIndex];
            //miEstudiante.EliminarEstudiante(estudianteSeleccionado.IdEstudiante);

            RefrescarEstudiantes();
        }

        private void btnModificarV_Est_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = ObtenerEstudianteSeleccionado();
            if (estudiante == null)
            {
                return;
            }

            Form f = new V_ModificarEstudiante(this, estudiante);
            f.ShowDialog();
        }
    }
}
