namespace Conservatorio.UI.Forms
{
    partial class V_Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Matricula));
            this.tbxBuscarEst_Matric = new System.Windows.Forms.TextBox();
            this.dgvEst_Matric = new System.Windows.Forms.DataGridView();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.btnSalvarMatricula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clbInstrumentos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Clase_Mat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.tbMontoMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.pb_Est = new System.Windows.Forms.PictureBox();
            this.lblTipoEstudiante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst_Matric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clase_Mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Est)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscarEst_Matric
            // 
            this.tbxBuscarEst_Matric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarEst_Matric.Location = new System.Drawing.Point(47, 12);
            this.tbxBuscarEst_Matric.Name = "tbxBuscarEst_Matric";
            this.tbxBuscarEst_Matric.Size = new System.Drawing.Size(217, 26);
            this.tbxBuscarEst_Matric.TabIndex = 1;
            this.tbxBuscarEst_Matric.TextChanged += new System.EventHandler(this.tbxBuscarEst_Matric_TextChanged);
            // 
            // dgvEst_Matric
            // 
            this.dgvEst_Matric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst_Matric.Location = new System.Drawing.Point(11, 47);
            this.dgvEst_Matric.Name = "dgvEst_Matric";
            this.dgvEst_Matric.Size = new System.Drawing.Size(406, 135);
            this.dgvEst_Matric.TabIndex = 2;
            this.dgvEst_Matric.DoubleClick += new System.EventHandler(this.dgvEst_Matric_DoubleClick);
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstudiante.Location = new System.Drawing.Point(430, 21);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(71, 20);
            this.lblNombreEstudiante.TabIndex = 3;
            this.lblNombreEstudiante.Text = "Nombre";
            // 
            // btnSalvarMatricula
            // 
            this.btnSalvarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarMatricula.Image")));
            this.btnSalvarMatricula.Location = new System.Drawing.Point(737, 441);
            this.btnSalvarMatricula.Name = "btnSalvarMatricula";
            this.btnSalvarMatricula.Size = new System.Drawing.Size(76, 74);
            this.btnSalvarMatricula.TabIndex = 8;
            this.btnSalvarMatricula.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // clbInstrumentos
            // 
            this.clbInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbInstrumentos.FormattingEnabled = true;
            this.clbInstrumentos.Location = new System.Drawing.Point(11, 220);
            this.clbInstrumentos.Name = "clbInstrumentos";
            this.clbInstrumentos.Size = new System.Drawing.Size(264, 130);
            this.clbInstrumentos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Instrumentos";
            // 
            // dgv_Clase_Mat
            // 
            this.dgv_Clase_Mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clase_Mat.Location = new System.Drawing.Point(345, 220);
            this.dgv_Clase_Mat.Name = "dgv_Clase_Mat";
            this.dgv_Clase_Mat.Size = new System.Drawing.Size(498, 124);
            this.dgv_Clase_Mat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Clases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Monto";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(132, 372);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(121, 28);
            this.cbTipoPago.TabIndex = 5;
            // 
            // tbMontoMat
            // 
            this.tbMontoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontoMat.Location = new System.Drawing.Point(406, 374);
            this.tbMontoMat.Name = "tbMontoMat";
            this.tbMontoMat.Size = new System.Drawing.Size(122, 26);
            this.tbMontoMat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Comentarios";
            // 
            // tbComentario
            // 
            this.tbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComentario.Location = new System.Drawing.Point(16, 446);
            this.tbComentario.Multiline = true;
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.Size = new System.Drawing.Size(430, 69);
            this.tbComentario.TabIndex = 7;
            // 
            // pb_Est
            // 
            this.pb_Est.Location = new System.Drawing.Point(706, 21);
            this.pb_Est.Name = "pb_Est";
            this.pb_Est.Size = new System.Drawing.Size(120, 137);
            this.pb_Est.TabIndex = 28;
            this.pb_Est.TabStop = false;
            // 
            // lblTipoEstudiante
            // 
            this.lblTipoEstudiante.AutoSize = true;
            this.lblTipoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEstudiante.Location = new System.Drawing.Point(430, 71);
            this.lblTipoEstudiante.Name = "lblTipoEstudiante";
            this.lblTipoEstudiante.Size = new System.Drawing.Size(43, 20);
            this.lblTipoEstudiante.TabIndex = 29;
            this.lblTipoEstudiante.Text = "Tipo";
            // 
            // V_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.lblTipoEstudiante);
            this.Controls.Add(this.pb_Est);
            this.Controls.Add(this.tbComentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMontoMat);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Clase_Mat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbInstrumentos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvarMatricula);
            this.Controls.Add(this.lblNombreEstudiante);
            this.Controls.Add(this.dgvEst_Matric);
            this.Controls.Add(this.tbxBuscarEst_Matric);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.V_Matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst_Matric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clase_Mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Est)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxBuscarEst_Matric;
        private System.Windows.Forms.DataGridView dgvEst_Matric;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Button btnSalvarMatricula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox clbInstrumentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Clase_Mat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.TextBox tbMontoMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComentario;
        private System.Windows.Forms.PictureBox pb_Est;
        private System.Windows.Forms.Label lblTipoEstudiante;
    }
}