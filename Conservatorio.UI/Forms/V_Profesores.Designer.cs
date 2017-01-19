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
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.btnAgregarProfesores = new System.Windows.Forms.Button();
            this.tbxBuscarProfesor = new System.Windows.Forms.TextBox();
            this.lblBuscarProfesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
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
            this.btnAgregarProfesores.Location = new System.Drawing.Point(330, 408);
            this.btnAgregarProfesores.Name = "btnAgregarProfesores";
            this.btnAgregarProfesores.Size = new System.Drawing.Size(121, 29);
            this.btnAgregarProfesores.TabIndex = 2;
            this.btnAgregarProfesores.Text = "Agregar";
            this.btnAgregarProfesores.UseVisualStyleBackColor = true;
            // 
            // tbxBuscarProfesor
            // 
            this.tbxBuscarProfesor.Location = new System.Drawing.Point(126, 28);
            this.tbxBuscarProfesor.Name = "tbxBuscarProfesor";
            this.tbxBuscarProfesor.Size = new System.Drawing.Size(192, 20);
            this.tbxBuscarProfesor.TabIndex = 5;
            // 
            // lblBuscarProfesor
            // 
            this.lblBuscarProfesor.AutoSize = true;
            this.lblBuscarProfesor.Location = new System.Drawing.Point(36, 31);
            this.lblBuscarProfesor.Name = "lblBuscarProfesor";
            this.lblBuscarProfesor.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarProfesor.TabIndex = 4;
            this.lblBuscarProfesor.Text = "Buscar:";
            // 
            // V_Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 468);
            this.Controls.Add(this.tbxBuscarProfesor);
            this.Controls.Add(this.lblBuscarProfesor);
            this.Controls.Add(this.btnAgregarProfesores);
            this.Controls.Add(this.dgvProfesores);
            this.Name = "V_Profesores";
            this.Text = "V_Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btnAgregarProfesores;
        private System.Windows.Forms.TextBox tbxBuscarProfesor;
        private System.Windows.Forms.Label lblBuscarProfesor;
    }
}