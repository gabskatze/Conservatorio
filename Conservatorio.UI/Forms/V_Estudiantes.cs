using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.UI.FormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_Estudiantes : Form
    {
        private IEstudiante miEstudiante;
        public V_Estudiantes()
        {
            InitializeComponent();
            miEstudiante = new EstudianteBL();
        }


    public void RefrescarEstudiantes()
        {
            var keyword = tbxBuscarEstudiante.Text;
            var list = miEstudiante.ObtenerEstudiantes(keyword);
            dgvEstudiantes.DataSource = list.Select(x => new EstudianteModel {
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
                NombreEncargado = x.Encargado.Nombre,
                Parentesco = x.Encargado.Parentesco,
                Telefono1Encargado = x.Encargado.Telefono1,
                Telefono2Encargado = x.Encargado.Telefono2,
                Telefono3Encargado = x.Encargado.Telefono3,
                EmailEncargado = x.Encargado.Email
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

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
