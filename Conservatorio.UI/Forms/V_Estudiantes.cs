using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;

namespace Conservatorio.UI.Forms
{
    public partial class V_Estudiantes : Form
    {
        private readonly IEstudianteBL estudianteBL;
        private List<Estudiante> listaEstudiantes;

        public V_Estudiantes()
        {
            InitializeComponent();
            estudianteBL = CapaLogica.EstudianteBl;
        }
        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                var keyword = tbxBuscar.Text;
                listaEstudiantes = estudianteBL.ObtenerEstudiantes(keyword);
                dgvEstudiantes.DataSource = listaEstudiantes.Select(x => new EstudianteModel
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
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        #region Action Methods

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new V_AgregarModificarEstudiante(this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var estudiante = ObtenerEstudianteSeleccionado();
                if (estudiante == null)
                {
                    return;
                }

                Form f = new V_AgregarModificarEstudiante(this, estudiante);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var estudiante = ObtenerEstudianteSeleccionado();
                if (estudiante == null)
                {
                    return;
                }

                estudianteBL.EliminarEstudiante(estudiante);
                RefrescarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void V_Estudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        #endregion
    }
}
