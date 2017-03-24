using Conservatorio.UI.Forms;
using System;
using System.Windows.Forms;

namespace Conservatorio.UI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void miEstudiantes_Click(object sender, EventArgs e)
        {
            Form f = new V_Estudiantes();
            f.MdiParent = this;
            f.Show();
        }

        private void miProfesores_Click(object sender, EventArgs e)
        {
            Form f = new V_Profesores();
            f.MdiParent = this;
            f.Show();
        }

        private void miInstrumentos_Click(object sender, EventArgs e)
        {
            Form f = new V_Instrumentos();
            f.MdiParent = this;
            f.Show();
        }

        private void miCursos_Click(object sender, EventArgs e)
        {
            Form f = new V_Cursos();
            f.MdiParent = this;
            f.Show();
        }

        private void miClases_Click(object sender, EventArgs e)
        {
            Form f = new V_Clases();
            f.MdiParent = this;
            f.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new V_Matricula();
            f.MdiParent = this;
            f.Show();
        }

        private void mensualidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new V_Mensualidad();
            f.MdiParent = this;
            f.Show();
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new V_Notificaciones();
            f.MdiParent = this;
            f.Show();
        }

        private void registroDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new V_RegistroNota();
            f.MdiParent = this;
            f.Show();
        }
    }
}
