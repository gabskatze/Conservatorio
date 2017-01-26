namespace Conservatorio.UI.Forms
{
    partial class V_AgregarInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarInstrumento));
            this.btnAgregarInst = new System.Windows.Forms.Button();
            this.lblNombreInst = new System.Windows.Forms.Label();
            this.tbxNombreInst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarInst
            // 
            this.btnAgregarInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInst.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInst.Image")));
            this.btnAgregarInst.Location = new System.Drawing.Point(182, 144);
            this.btnAgregarInst.Name = "btnAgregarInst";
            this.btnAgregarInst.Size = new System.Drawing.Size(72, 69);
            this.btnAgregarInst.TabIndex = 1;
            this.btnAgregarInst.UseVisualStyleBackColor = true;
            this.btnAgregarInst.Click += new System.EventHandler(this.btnAgregarInst_Click);
            // 
            // lblNombreInst
            // 
            this.lblNombreInst.AutoSize = true;
            this.lblNombreInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInst.Location = new System.Drawing.Point(61, 86);
            this.lblNombreInst.Name = "lblNombreInst";
            this.lblNombreInst.Size = new System.Drawing.Size(69, 20);
            this.lblNombreInst.TabIndex = 2;
            this.lblNombreInst.Text = "Nombre:";
            // 
            // tbxNombreInst
            // 
            this.tbxNombreInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombreInst.Location = new System.Drawing.Point(136, 86);
            this.tbxNombreInst.Name = "tbxNombreInst";
            this.tbxNombreInst.Size = new System.Drawing.Size(198, 26);
            this.tbxNombreInst.TabIndex = 0;
            // 
            // V_AgregarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 280);
            this.Controls.Add(this.tbxNombreInst);
            this.Controls.Add(this.lblNombreInst);
            this.Controls.Add(this.btnAgregarInst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_AgregarInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarInst;
        private System.Windows.Forms.Label lblNombreInst;
        private System.Windows.Forms.TextBox tbxNombreInst;
    }
}