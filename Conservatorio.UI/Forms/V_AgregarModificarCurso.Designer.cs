namespace Conservatorio.UI.Forms
{
    partial class V_AgregarModificarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarModificarCurso));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRequisito = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.cbxRequisito = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.tbxInstrumento = new System.Windows.Forms.TextBox();
            this.tbxNivel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(133, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 67);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRequisito
            // 
            this.lblRequisito.AutoSize = true;
            this.lblRequisito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisito.Location = new System.Drawing.Point(12, 110);
            this.lblRequisito.Name = "lblRequisito";
            this.lblRequisito.Size = new System.Drawing.Size(80, 20);
            this.lblRequisito.TabIndex = 41;
            this.lblRequisito.Text = "Requisito:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(87, 12);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(235, 26);
            this.tbxNombre.TabIndex = 42;
            // 
            // cbxRequisito
            // 
            this.cbxRequisito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRequisito.FormattingEnabled = true;
            this.cbxRequisito.Location = new System.Drawing.Point(99, 107);
            this.cbxRequisito.Name = "cbxRequisito";
            this.cbxRequisito.Size = new System.Drawing.Size(223, 28);
            this.cbxRequisito.TabIndex = 43;
            this.cbxRequisito.SelectedIndexChanged += new System.EventHandler(this.cbxRequisito_SelectedIndexChanged);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(12, 158);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(46, 20);
            this.lblNivel.TabIndex = 44;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.Location = new System.Drawing.Point(12, 62);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(99, 20);
            this.lblInstrumento.TabIndex = 45;
            this.lblInstrumento.Text = "Instrumento:";
            // 
            // tbxInstrumento
            // 
            this.tbxInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInstrumento.Location = new System.Drawing.Point(117, 59);
            this.tbxInstrumento.Name = "tbxInstrumento";
            this.tbxInstrumento.ReadOnly = true;
            this.tbxInstrumento.Size = new System.Drawing.Size(205, 26);
            this.tbxInstrumento.TabIndex = 46;
            // 
            // tbxNivel
            // 
            this.tbxNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNivel.Location = new System.Drawing.Point(64, 155);
            this.tbxNivel.Name = "tbxNivel";
            this.tbxNivel.Size = new System.Drawing.Size(74, 26);
            this.tbxNivel.TabIndex = 47;
            // 
            // V_AgregarModificarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 299);
            this.Controls.Add(this.tbxNivel);
            this.Controls.Add(this.tbxInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cbxRequisito);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblRequisito);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.Name = "V_AgregarModificarCurso";
            this.Text = "V_AgregarModificarCurso";
            this.Load += new System.EventHandler(this.V_AgregarModificarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRequisito;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ComboBox cbxRequisito;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.TextBox tbxInstrumento;
        private System.Windows.Forms.TextBox tbxNivel;
    }
}