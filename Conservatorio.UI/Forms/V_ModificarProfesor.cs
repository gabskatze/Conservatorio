using System.Windows.Forms;
using Conservatorio.DATOS;

namespace Conservatorio.UI.Forms
{
    public partial class V_ModificarProfesor : Form
    {
        private V_Profesores vProfesor;
        private Profesor profesor;

        public V_ModificarProfesor(V_Profesores vProfesor, Profesor profesor)
        {
            InitializeComponent();

            this.vProfesor = vProfesor;
            this.profesor = profesor;
        }
    }
}
