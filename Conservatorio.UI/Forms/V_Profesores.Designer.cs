namespace Conservatorio.UI.Forms
{
    partial class V_Profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Profesores));
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.btnAgregarProfesores = new System.Windows.Forms.Button();
            this.tbxBuscarProfesor = new System.Windows.Forms.TextBox();
            this.btnModProfesor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(27, 61);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(731, 324);
            this.dgvProfesores.TabIndex = 1;
            // 
            // btnAgregarProfesores
            // 
            this.btnAgregarProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesores.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProfesores.Image")));
            this.btnAgregarProfesores.Location = new System.Drawing.Point(210, 410);
            this.btnAgregarProfesores.Name = "btnAgregarProfesores";
            this.btnAgregarProfesores.Size = new System.Drawing.Size(67, 65);
            this.btnAgregarProfesores.TabIndex = 2;
            this.btnAgregarProfesores.UseVisualStyleBackColor = true;
            // 
            // tbxBuscarProfesor
            // 
            this.tbxBuscarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarProfesor.Location = new System.Drawing.Point(126, 28);
            this.tbxBuscarProfesor.Name = "tbxBuscarProfesor";
            this.tbxBuscarProfesor.Size = new System.Drawing.Size(209, 26);
            this.tbxBuscarProfesor.TabIndex = 5;
            // 
            // btnModProfesor
            // 
            this.btnModProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnModProfesor.Image")));
            this.btnModProfesor.Location = new System.Drawing.Point(336, 410);
            this.btnModProfesor.Name = "btnModProfesor";
            this.btnModProfesor.Size = new System.Drawing.Size(69, 65);
            this.btnModProfesor.TabIndex = 6;
            this.btnModProfesor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(463, 410);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(68, 65);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // V_Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 499);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModProfesor);
            this.Controls.Add(this.tbxBuscarProfesor);
            this.Controls.Add(this.btnAgregarProfesores);
            this.Controls.Add(this.dgvProfesores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Profesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btnAgregarProfesores;
        private System.Windows.Forms.TextBox tbxBuscarProfesor;
        private System.Windows.Forms.Button btnModProfesor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBorrar;
    }
}