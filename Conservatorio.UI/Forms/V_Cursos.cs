using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;

namespace Conservatorio.UI.Forms
{
    public partial class V_Cursos : Form
    {
        private readonly ICursoBL cursoBL;

        private List<Instrumento> listaInstrumentos;
        private List<Curso> listaCursos;

        public V_Cursos()
        {
            InitializeComponent();

            cursoBL = new CursoBL();
        }

        private Instrumento ObtenerInstrumentoSeleccionado()
        {
            var instrumentoIndex = cbxInstrumento.SelectedIndex;
            if (instrumentoIndex < 0)
            {
                return null;
            }

            return listaInstrumentos[instrumentoIndex];
        }

        private Curso ObtenerCursoSeleccionado()
        {
            return lbxCursos.SelectedItem as Curso;
        }

        #region Action Methods

        private void V_Cursos_Load(object sender, EventArgs e)
        {
            listaCursos = cursoBL.ObtenerCursos();
            listaInstrumentos = listaCursos.Select(x => x.Instrumento).Distinct().ToList();

            cbxInstrumento.DataSource = listaInstrumentos;
            cbxInstrumento.DisplayMember = "NombreInstrumento";
            cbxInstrumento.ValueMember = "IdInstrumento";
        }

        private void cbxInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var instrumentoSeleccionado = ObtenerInstrumentoSeleccionado();
            if (instrumentoSeleccionado == null)
            {
                return;
            }

            lbxCursos.DataSource = listaCursos
                .Where(x => x.Instrumento.IdInstrumento == instrumentoSeleccionado.IdInstrumento)
                .OrderBy(x => x.Nivel)
                .ToList();
            lbxCursos.DisplayMember = "NombreCurso";
            lbxCursos.ValueMember = "IdCurso";
        }

        #endregion
    }
}
