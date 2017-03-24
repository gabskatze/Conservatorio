namespace Conservatorio.UI.Forms
{
    partial class V_RegistroNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RegistroNota));
            this.lblTipoEstudiante = new System.Windows.Forms.Label();
            this.pb_Est = new System.Windows.Forms.PictureBox();
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMontoMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbInstrumentos = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvarMatricula = new System.Windows.Forms.Button();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Est)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoEstudiante
            // 
            this.lblTipoEstudiante.AutoSize = true;
            this.lblTipoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEstudiante.Location = new System.Drawing.Point(498, 64);
            this.lblTipoEstudiante.Name = "lblTipoEstudiante";
            this.lblTipoEstudiante.Size = new System.Drawing.Size(43, 20);
            this.lblTipoEstudiante.TabIndex = 48;
            this.lblTipoEstudiante.Text = "Tipo";
            // 
            // pb_Est
            // 
            this.pb_Est.Location = new System.Drawing.Point(774, 14);
            this.pb_Est.Name = "pb_Est";
            this.pb_Est.Size = new System.Drawing.Size(120, 137);
            this.pb_Est.TabIndex = 47;
            this.pb_Est.TabStop = false;
            // 
            // tbComentario
            // 
            this.tbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComentario.Location = new System.Drawing.Point(84, 439);
            this.tbComentario.Multiline = true;
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.Size = new System.Drawing.Size(430, 69);
            this.tbComentario.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Comentarios";
            // 
            // tbMontoMat
            // 
            this.tbMontoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontoMat.Location = new System.Drawing.Point(524, 221);
            this.tbMontoMat.Name = "tbMontoMat";
            this.tbMontoMat.Size = new System.Drawing.Size(42, 22);
            this.tbMontoMat.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Asistencia 20%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Instrumentos";
            // 
            // clbInstrumentos
            // 
            this.clbInstrumentos.CheckOnClick = true;
            this.clbInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbInstrumentos.FormattingEnabled = true;
            this.clbInstrumentos.Location = new System.Drawing.Point(79, 213);
            this.clbInstrumentos.Name = "clbInstrumentos";
            this.clbInstrumentos.Size = new System.Drawing.Size(264, 123);
            this.clbInstrumentos.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvarMatricula
            // 
            this.btnSalvarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarMatricula.Image")));
            this.btnSalvarMatricula.Location = new System.Drawing.Point(805, 434);
            this.btnSalvarMatricula.Name = "btnSalvarMatricula";
            this.btnSalvarMatricula.Size = new System.Drawing.Size(70, 70);
            this.btnSalvarMatricula.TabIndex = 40;
            this.btnSalvarMatricula.Text = "Salvar";
            this.btnSalvarMatricula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarMatricula.UseVisualStyleBackColor = true;
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstudiante.Location = new System.Drawing.Point(498, 14);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(71, 20);
            this.lblNombreEstudiante.TabIndex = 34;
            this.lblNombreEstudiante.Text = "Nombre";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(79, 52);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(406, 135);
            this.dgvEstudiantes.TabIndex = 33;
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(128, 18);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(231, 22);
            this.tbxBuscar.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Programa 50%";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(598, 306);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(79, 16);
            this.lblFinal.TabIndex = 52;
            this.lblFinal.Text = "Nota Final";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(524, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 22);
            this.textBox2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Examen 30%";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(524, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 22);
            this.textBox3.TabIndex = 55;
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinal.Location = new System.Drawing.Point(675, 299);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(106, 25);
            this.lblNotaFinal.TabIndex = 56;
            this.lblNotaFinal.Text = "notalFinal";
            // 
            // V_RegistroNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 528);
            this.Controls.Add(this.lblNotaFinal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipoEstudiante);
            this.Controls.Add(this.pb_Est);
            this.Controls.Add(this.tbComentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMontoMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbInstrumentos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvarMatricula);
            this.Controls.Add(this.lblNombreEstudiante);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.tbxBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_RegistroNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Notas";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Est)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoEstudiante;
        private System.Windows.Forms.PictureBox pb_Est;
        private System.Windows.Forms.TextBox tbComentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMontoMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbInstrumentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvarMatricula;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNotaFinal;
    }
}