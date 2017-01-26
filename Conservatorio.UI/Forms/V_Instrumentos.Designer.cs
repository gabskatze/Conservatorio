namespace Conservatorio.UI.Forms
{
    partial class V_Instrumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Instrumentos));
            this.tbxBuscarInstrumento = new System.Windows.Forms.TextBox();
            this.btnAgregarInstrumento = new System.Windows.Forms.Button();
            this.dgvInstrumentos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscarInstrumento
            // 
            this.tbxBuscarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarInstrumento.Location = new System.Drawing.Point(86, 30);
            this.tbxBuscarInstrumento.Name = "tbxBuscarInstrumento";
            this.tbxBuscarInstrumento.Size = new System.Drawing.Size(192, 26);
            this.tbxBuscarInstrumento.TabIndex = 9;
            this.tbxBuscarInstrumento.TextChanged += new System.EventHandler(this.tbxBuscarInstrumento_TextChanged);
            // 
            // btnAgregarInstrumento
            // 
            this.btnAgregarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInstrumento.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInstrumento.Image")));
            this.btnAgregarInstrumento.Location = new System.Drawing.Point(343, 366);
            this.btnAgregarInstrumento.Name = "btnAgregarInstrumento";
            this.btnAgregarInstrumento.Size = new System.Drawing.Size(73, 73);
            this.btnAgregarInstrumento.TabIndex = 7;
            this.btnAgregarInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarInstrumento.Click += new System.EventHandler(this.btnAgregarInstrumento_Click);
            // 
            // dgvInstrumentos
            // 
            this.dgvInstrumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInstrumentos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvInstrumentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentos.Location = new System.Drawing.Point(227, 56);
            this.dgvInstrumentos.Name = "dgvInstrumentos";
            this.dgvInstrumentos.Size = new System.Drawing.Size(292, 283);
            this.dgvInstrumentos.TabIndex = 6;
            this.dgvInstrumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrumentos_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // V_Instrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxBuscarInstrumento);
            this.Controls.Add(this.btnAgregarInstrumento);
            this.Controls.Add(this.dgvInstrumentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Instrumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrumentos";
            this.Load += new System.EventHandler(this.V_Instrumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBuscarInstrumento;
        private System.Windows.Forms.Button btnAgregarInstrumento;
        private System.Windows.Forms.DataGridView dgvInstrumentos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}