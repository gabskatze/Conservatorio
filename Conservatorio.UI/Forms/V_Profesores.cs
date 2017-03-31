using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormModels;

namespace Conservatorio.UI.Forms
{
    public partial class V_Profesores : Form
    {
        private readonly IProfesorBL profesorBL;
        private List<Profesor> listaProfesores;

        public V_Profesores()
        {
            InitializeComponent();
            profesorBL = new ProfesorBL();
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void RefrescarProfesores()
        {
            try
            {
                var keyword = tbxBuscar.Text;
                listaProfesores = profesorBL.ObtenerProfesores(keyword);
                dgvProfesores.DataSource = listaProfesores.Select(x => new ProfesorModel
                {
                    IdProfesor = x.IdPersona,
                    Nombre = x.Nombre,
                    Cedula = x.Cedula.Value,
                    Direccion = x.Direccion,
                    Ocupacion = x.Ocupacion,
                    Email = x.Email,
                    Estado = x.Estado ? "Activo" : "Inactivo",
                    FechaNacimiento = x.FechaNacimiento.Value.ToShortDateString(),
                    Telefono1 = x.Telefono1,
                    Telefono2 = x.Telefono2,
                    Telefono3 = x.Telefono3
                }).ToList();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private Profesor ObtenerProfesorSeleccionado()
        {
            if (dgvProfesores.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvProfesores.SelectedRows[0].Index;
            return listaProfesores[selectedIndex];
        }

        #region Action Methods

        private void V_Profesores_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarProfesores();
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
                RefrescarProfesores();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new V_AgregarModificarProfesor(this);
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
                var profesor = ObtenerProfesorSeleccionado();
                if (profesor == null)
                {
                    return;
                }

                Form f = new V_AgregarModificarProfesor(this, profesor);
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
                var profesor = ObtenerProfesorSeleccionado();
                if (profesor == null)
                {
                    return;
                }

                profesorBL.EliminarProfesor(profesor);
                RefrescarProfesores();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        #endregion
    }
}
