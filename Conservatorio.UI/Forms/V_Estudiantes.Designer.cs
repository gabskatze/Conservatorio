namespace Conservatorio.UI.Forms
{
    partial class V_Estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Estudiantes));
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnAgregarV_Est = new System.Windows.Forms.Button();
            this.lblBuscarEstudiante = new System.Windows.Forms.Label();
            this.tbxBuscarEstudiante = new System.Windows.Forms.TextBox();
            this.btnModificarV_Est = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(29, 64);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(731, 324);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // btnAgregarV_Est
            // 
            this.btnAgregarV_Est.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarV_Est.Location = new System.Drawing.Point(163, 408);
            this.btnAgregarV_Est.Name = "btnAgregarV_Est";
            this.btnAgregarV_Est.Size = new System.Drawing.Size(121, 29);
            this.btnAgregarV_Est.TabIndex = 1;
            this.btnAgregarV_Est.Text = "Agregar";
            this.btnAgregarV_Est.UseVisualStyleBackColor = true;
            this.btnAgregarV_Est.Click += new System.EventHandler(this.btnAgregarV_Est_Click);
            // 
            // lblBuscarEstudiante
            // 
            this.lblBuscarEstudiante.AutoSize = true;
            this.lblBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEstudiante.Location = new System.Drawing.Point(26, 30);
            this.lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            this.lblBuscarEstudiante.Size = new System.Drawing.Size(63, 20);
            this.lblBuscarEstudiante.TabIndex = 2;
            this.lblBuscarEstudiante.Text = "Buscar:";
            // 
            // tbxBuscarEstudiante
            // 
            this.tbxBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarEstudiante.Location = new System.Drawing.Point(116, 27);
            this.tbxBuscarEstudiante.Name = "tbxBuscarEstudiante";
            this.tbxBuscarEstudiante.Size = new System.Drawing.Size(232, 26);
            this.tbxBuscarEstudiante.TabIndex = 3;
            // 
            // btnModificarV_Est
            // 
            this.btnModificarV_Est.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarV_Est.Location = new System.Drawing.Point(489, 408);
            this.btnModificarV_Est.Name = "btnModificarV_Est";
            this.btnModificarV_Est.Size = new System.Drawing.Size(121, 29);
            this.btnModificarV_Est.TabIndex = 4;
            this.btnModificarV_Est.Text = "Modificar";
            this.btnModificarV_Est.UseVisualStyleBackColor = true;
            // 
            // V_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 468);
            this.Controls.Add(this.btnModificarV_Est);
            this.Controls.Add(this.tbxBuscarEstudiante);
            this.Controls.Add(this.lblBuscarEstudiante);
            this.Controls.Add(this.btnAgregarV_Est);
            this.Controls.Add(this.dgvEstudiantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Estudiantes";
            this.Load += new System.EventHandler(this.V_Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnAgregarV_Est;
        private System.Windows.Forms.Label lblBuscarEstudiante;
        private System.Windows.Forms.TextBox tbxBuscarEstudiante;
        private System.Windows.Forms.Button btnModificarV_Est;
    }
}