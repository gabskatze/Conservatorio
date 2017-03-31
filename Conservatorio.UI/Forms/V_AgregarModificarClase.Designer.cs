namespace Conservatorio.UI.Forms
{
    partial class V_AgregarModificarClase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarModificarClase));
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.cbxProfesores = new System.Windows.Forms.ComboBox();
            this.cbxDias = new System.Windows.Forms.ComboBox();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.cbxInstrumento = new System.Windows.Forms.ComboBox();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAula = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(382, 45);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(46, 16);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(15, 107);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(62, 16);
            this.lblProfesor.TabIndex = 1;
            this.lblProfesor.Text = "Profesor:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(382, 107);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(32, 16);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Día:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(12, 176);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(94, 16);
            this.lblHoraInicio.TabIndex = 3;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // cbxCursos
            // 
            this.cbxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(515, 42);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(144, 24);
            this.cbxCursos.TabIndex = 2;
            // 
            // cbxProfesores
            // 
            this.cbxProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfesores.FormattingEnabled = true;
            this.cbxProfesores.Location = new System.Drawing.Point(94, 104);
            this.cbxProfesores.Name = "cbxProfesores";
            this.cbxProfesores.Size = new System.Drawing.Size(176, 24);
            this.cbxProfesores.TabIndex = 3;
            // 
            // cbxDias
            // 
            this.cbxDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDias.FormattingEnabled = true;
            this.cbxDias.Location = new System.Drawing.Point(515, 104);
            this.cbxDias.Name = "cbxDias";
            this.cbxDias.Size = new System.Drawing.Size(144, 24);
            this.cbxDias.TabIndex = 4;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "hh:mm tt";
            this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(120, 171);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(150, 22);
            this.dtpHoraInicio.TabIndex = 5;
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dtpHoraInicio_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(342, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.Location = new System.Drawing.Point(15, 48);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(79, 16);
            this.lblInstrumento.TabIndex = 13;
            this.lblInstrumento.Text = "Instrumento:";
            // 
            // cbxInstrumento
            // 
            this.cbxInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInstrumento.FormattingEnabled = true;
            this.cbxInstrumento.Location = new System.Drawing.Point(100, 45);
            this.cbxInstrumento.Name = "cbxInstrumento";
            this.cbxInstrumento.Size = new System.Drawing.Size(170, 24);
            this.cbxInstrumento.TabIndex = 1;
            this.cbxInstrumento.SelectedIndexChanged += new System.EventHandler(this.cbxInstrumento_SelectedIndexChanged);
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.CustomFormat = "hh:mm tt";
            this.dtpHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal.Location = new System.Drawing.Point(515, 170);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(144, 22);
            this.dtpHoraFinal.TabIndex = 6;
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFinal.Location = new System.Drawing.Point(383, 176);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(68, 16);
            this.lblHoraFinal.TabIndex = 14;
            this.lblHoraFinal.Text = "Hora final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aula:";
            // 
            // tbxAula
            // 
            this.tbxAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAula.Location = new System.Drawing.Point(94, 227);
            this.tbxAula.Name = "tbxAula";
            this.tbxAula.Size = new System.Drawing.Size(51, 22);
            this.tbxAula.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(383, 230);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(59, 16);
            this.lblPeriodo.TabIndex = 17;
            this.lblPeriodo.Text = "Período:";
            // 
            // tbxAno
            // 
            this.tbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(581, 227);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(78, 22);
            this.tbxAno.TabIndex = 18;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(540, 230);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 16);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Año:";
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(448, 227);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(56, 24);
            this.cbxPeriodo.TabIndex = 20;
            // 
            // V_AgregarModificarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(751, 393);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.tbxAula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.cbxInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.cbxDias);
            this.Controls.Add(this.cbxProfesores);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_AgregarModificarClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Clase";
            this.Load += new System.EventHandler(this.V_AgregarModificarClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.ComboBox cbxProfesores;
        private System.Windows.Forms.ComboBox cbxDias;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.ComboBox cbxInstrumento;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAula;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cbxPeriodo;
    }
}