using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarProfesor : Form
    {
        private V_Profesores vProfesor;

        public V_AgregarProfesor(V_Profesores vProfesor)
        {
            InitializeComponent();

            this.vProfesor = vProfesor;
        }
    }
}
