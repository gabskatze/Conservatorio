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

        }

        private void miInstrumentos_Click(object sender, EventArgs e)
        {
            Form f = new V_Instrumentos();
            f.MdiParent = this;
            f.Show();
        }
    }
}
