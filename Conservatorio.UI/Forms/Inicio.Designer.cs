namespace Conservatorio.UI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstrumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.miCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.miClases = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensualidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEstudiantes,
            this.miProfesores,
            this.miInstrumentos,
            this.miCursos,
            this.miClases});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // miEstudiantes
            // 
            this.miEstudiantes.Name = "miEstudiantes";
            this.miEstudiantes.Size = new System.Drawing.Size(172, 26);
            this.miEstudiantes.Text = "Estudiantes";
            this.miEstudiantes.Click += new System.EventHandler(this.miEstudiantes_Click);
            // 
            // miProfesores
            // 
            this.miProfesores.Name = "miProfesores";
            this.miProfesores.Size = new System.Drawing.Size(172, 26);
            this.miProfesores.Text = "Profesores";
            this.miProfesores.Click += new System.EventHandler(this.miProfesores_Click);
            // 
            // miInstrumentos
            // 
            this.miInstrumentos.Name = "miInstrumentos";
            this.miInstrumentos.Size = new System.Drawing.Size(172, 26);
            this.miInstrumentos.Text = "Instrumentos";
            this.miInstrumentos.Click += new System.EventHandler(this.miInstrumentos_Click);
            // 
            // miCursos
            // 
            this.miCursos.Name = "miCursos";
            this.miCursos.Size = new System.Drawing.Size(172, 26);
            this.miCursos.Text = "Cursos";
            this.miCursos.Click += new System.EventHandler(this.miCursos_Click);
            // 
            // miClases
            // 
            this.miClases.Name = "miClases";
            this.miClases.Size = new System.Drawing.Size(172, 26);
            this.miClases.Text = "Clases";
            this.miClases.Click += new System.EventHandler(this.miClases_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.mensualidadToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // mensualidadToolStripMenuItem
            // 
            this.mensualidadToolStripMenuItem.Name = "mensualidadToolStripMenuItem";
            this.mensualidadToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.mensualidadToolStripMenuItem.Text = "Mensualidad";
            this.mensualidadToolStripMenuItem.Click += new System.EventHandler(this.mensualidadToolStripMenuItem_Click);
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            this.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 619);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem miProfesores;
        private System.Windows.Forms.ToolStripMenuItem miInstrumentos;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensualidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCursos;
        private System.Windows.Forms.ToolStripMenuItem miClases;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
    }
}