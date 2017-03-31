using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormValidation;
using Emgu.CV;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarProfesor : Form
    {
        private readonly IProfesorBL profesorBL;
        private readonly IInstrumentoBL instrumentoBL;
        private readonly V_Profesores vProfesor;
        private Profesor profesor;

        private Capture _capture;
        private Capture CameraCapture
        {
            get
            {
                return _capture ?? (_capture = new Capture());
            }
            set { _capture = value; }
        } 

        private bool CaptureInProgress { get; set; }

        public V_AgregarModificarProfesor(V_Profesores vProfesor, Profesor profesor = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            this.vProfesor = vProfesor;
            this.profesor = profesor;
            profesorBL = CapaLogica.ProfesorBl;
            instrumentoBL = CapaLogica.InstrumentoBl;

            CargarInstrumentos();
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CargarInstrumentos()
        {
            try
            {
                clbInstrumentos.DataSource = instrumentoBL.ObtenerInstrumentos();
                clbInstrumentos.DisplayMember = "NombreInstrumento";
                clbInstrumentos.ValueMember = "IdInstrumento";
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void ConfigurarValidacion()
        {
            try
            {
                    var validadores = new[]
                {
                    new Validador
                    {
                        Control = tbxNombre,
                        MetodoValidacion = (out string errorMsg) => !tbxNombre.ValidarRequerido(out errorMsg)
                    },
                    new Validador
                    {
                        Control = tbxCedula,
                        MetodoValidacion = (out string errorMsg) => !tbxCedula.ValidarRequerido(out errorMsg) || !tbxCedula.ValidarEntero(out errorMsg)
                    },
                    new Validador
                    {
                        Control = tbxOcupacion,
                        MetodoValidacion = (out string errorMsg) => !tbxOcupacion.ValidarRequerido(out errorMsg)
                    },
                    new Validador
                    {
                        Control = tbxEmail,
                        MetodoValidacion = (out string errorMsg) => !tbxEmail.ValidarRequerido(out errorMsg) || !tbxEmail.ValidarEmail(out errorMsg)
                    },
                    new Validador
                    {
                        Control = tbxTelefono1,
                        MetodoValidacion = (out string errorMsg) => !tbxTelefono1.ValidarRequerido(out errorMsg) || !tbxTelefono1.ValidarEntero(out errorMsg) || !tbxTelefono1.ValidarLargo(8, out errorMsg)
                    },
                    new Validador
                    {
                        Control = tbxTelefono2,
                        MetodoValidacion = (out string errorMsg) => !tbxTelefono2.ValidarEntero(out errorMsg) || !tbxTelefono2.ValidarLargo(8, out errorMsg)
                    },
                    new Validador
                    {
                        Control = tbxTelefono3,
                        MetodoValidacion = (out string errorMsg) => !tbxTelefono3.ValidarEntero(out errorMsg) || !tbxTelefono3.ValidarLargo(8, out errorMsg)
                    }
                };

                    Validation.Config(errorProvider, validadores);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        #region Action Methods

        private void V_AgregarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                Text = profesor == null ? "Agregar Profesor" : "Modificar Profesor";

                if (profesor == null)
                {
                    return;
                }

                tbxNombre.Text = profesor.Nombre;
                tbxCedula.Text = profesor.Cedula.ToString();
                tbxDireccion.Text = profesor.Direccion;
                tbxOcupacion.Text = profesor.Ocupacion;
                dtpFechaNacimiento.Value = profesor.FechaNacimiento.Value;
                tbxEmail.Text = profesor.Email;
                tbxTelefono1.Text = profesor.Telefono1.ToString();
                tbxTelefono2.Text = profesor.Telefono2.ToString();
                tbxTelefono3.Text = profesor.Telefono3.ToString();

                if (!string.IsNullOrEmpty(profesor.Imagen))
                {
                    var bytes = File.ReadAllBytes(ConfigurationManager.AppSettings["imagesFolder"] + profesor.Imagen);
                    var ms = new MemoryStream(bytes);
                    pbxFoto.Image = Image.FromStream(ms);
                }

                var idsInstrumentos = profesor.Instrumentos.Select(x => x.IdInstrumento).ToList();
                for (var i = 0; i < clbInstrumentos.Items.Count; i++)
                {
                    var instrumento = (Instrumento)clbInstrumentos.Items[i];
                    if (idsInstrumentos.Contains(instrumento.IdInstrumento))
                    {
                        clbInstrumentos.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void btnAgregarProf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                if (profesor == null)
                {
                    profesor = new Profesor
                    {
                        Estado = true
                    };
                }

                if (string.IsNullOrEmpty(profesor.Imagen))
                {
                    profesor.Imagen = Guid.NewGuid() + ".png";
                }

                profesor.Cedula = int.Parse(tbxCedula.Text);
                profesor.Direccion = tbxDireccion.Text;
                profesor.Email = tbxEmail.Text;
                profesor.FechaNacimiento = dtpFechaNacimiento.Value;
                profesor.Nombre = tbxNombre.Text;
                profesor.Ocupacion = tbxOcupacion.Text;
                profesor.Telefono1 = int.Parse(tbxTelefono1.Text);
                profesor.Telefono2 = string.IsNullOrEmpty(tbxTelefono2.Text) ? (int?)null : int.Parse(tbxTelefono2.Text);
                profesor.Telefono3 = string.IsNullOrEmpty(tbxTelefono3.Text) ? (int?)null : int.Parse(tbxTelefono3.Text);
                profesor.Instrumentos = clbInstrumentos.CheckedItems.Cast<Instrumento>().ToList();

                if (profesor.IdPersona == 0)
                {
                    profesorBL.CrearProfesor(profesor);
                }
                else
                {
                    profesorBL.ModificarProfesor(profesor);
                }

                // Guardar la imagen
                var foto = pbxFoto.Image;
                if (foto != null)
                {
                    foto.Save(ConfigurationManager.AppSettings["imagesFolder"] + profesor.Imagen, ImageFormat.Png);
                }

                Close();
                vProfesor.RefrescarProfesores();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    pbxFoto.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                var image = CameraCapture.QueryFrame().Bitmap;
                pbxFoto.Image = image;
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaptureInProgress)
                {
                    Application.Idle -= ProcessFrame;
                    CameraCapture.Dispose();
                    CameraCapture = null;
                }
                else
                {
                    Application.Idle += ProcessFrame;
                }

                CaptureInProgress = !CaptureInProgress;
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
            
        }

        #endregion

    }
}
