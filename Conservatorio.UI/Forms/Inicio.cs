using Conservatorio.UI.Forms;
using System;
using System.Windows.Forms;
using Conservatorio.BL.Clases;
using Conservatorio.DATOS;

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
            var instrumentoBL = new InstrumentoBL();

            var instrumento = new Instrumento
            {
                NombreInstrumento = "Guitarra"
            };
            instrumentoBL.CrearInstrumento(instrumento);
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
    }
}
