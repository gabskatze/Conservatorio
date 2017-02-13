using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;

namespace Conservatorio.UI.Forms
{
    public partial class V_Profesores : Form
    {
        private List<Profesor> listaProfesores;
        private IProfesor profesoresBL;

        public V_Profesores()
        {
            InitializeComponent();
            profesoresBL = new ProfesorBL();
        }

        private void RefrescarProfesores()
        {
            var keyword = tbxBuscarProfesor.Text;
            listaProfesores = profesoresBL.ObtenerProfesores(keyword);
            dgvProfesores.DataSource = listaProfesores;
        }

        private void tbxBuscarProfesor_TextChanged(object sender, EventArgs e)
        {
            RefrescarProfesores();
        }

        private void btnAgregarProfesores_Click(object sender, EventArgs e)
        {
            Form f = new V_AgregarProfesor(this);
            f.ShowDialog();
        }

        private void btnModProfesor_Click(object sender, EventArgs e)
        {
            Form f = new V_ModificarProfesor(this);
            f.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            RefrescarProfesores();
        }
    }
}
