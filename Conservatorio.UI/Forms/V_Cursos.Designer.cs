namespace Conservatorio.UI.Forms
{
    partial class V_Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Cursos));
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.cbxInstrumento = new System.Windows.Forms.ComboBox();
            this.lbxCursos = new System.Windows.Forms.ListBox();
            this.lblCursos = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.Location = new System.Drawing.Point(32, 25);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(79, 16);
            this.lblInstrumento.TabIndex = 0;
            this.lblInstrumento.Text = "Instrumento:";
            // 
            // cbxInstrumento
            // 
            this.cbxInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInstrumento.FormattingEnabled = true;
            this.cbxInstrumento.Location = new System.Drawing.Point(117, 17);
            this.cbxInstrumento.Name = "cbxInstrumento";
            this.cbxInstrumento.Size = new System.Drawing.Size(274, 24);
            this.cbxInstrumento.TabIndex = 1;
            this.cbxInstrumento.SelectedIndexChanged += new System.EventHandler(this.cbxInstrumento_SelectedIndexChanged);
            // 
            // lbxCursos
            // 
            this.lbxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCursos.FormattingEnabled = true;
            this.lbxCursos.ItemHeight = 16;
            this.lbxCursos.Location = new System.Drawing.Point(117, 76);
            this.lbxCursos.Name = "lbxCursos";
            this.lbxCursos.Size = new System.Drawing.Size(274, 244);
            this.lbxCursos.TabIndex = 2;
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.Location = new System.Drawing.Point(32, 76);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(53, 16);
            this.lblCursos.TabIndex = 3;
            this.lblCursos.Text = "Cursos:";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(229, 348);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(55, 55);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(117, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 55);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(336, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 55);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // V_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.lbxCursos);
            this.Controls.Add(this.cbxInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.V_Cursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.ComboBox cbxInstrumento;
        private System.Windows.Forms.ListBox lbxCursos;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}