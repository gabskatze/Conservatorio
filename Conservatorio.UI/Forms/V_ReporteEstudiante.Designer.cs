namespace Conservatorio.UI.Forms
{
    partial class V_ReporteEstudiante
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportesDataSet = new Conservatorio.UI.Reportes.ReportesDataSet();
            this.obtenerReporteEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerReporteEstudianteTableAdapter = new Conservatorio.UI.Reportes.ReportesDataSetTableAdapters.ObtenerReporteEstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteEstudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReporteEstudianteDataSet";
            reportDataSource1.Value = this.obtenerReporteEstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Conservatorio.UI.Reportes.ReporteEstudiante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(707, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerReporteEstudianteBindingSource
            // 
            this.obtenerReporteEstudianteBindingSource.DataMember = "ObtenerReporteEstudiante";
            this.obtenerReporteEstudianteBindingSource.DataSource = this.reportesDataSet;
            // 
            // obtenerReporteEstudianteTableAdapter
            // 
            this.obtenerReporteEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // V_ReporteEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "V_ReporteEstudiante";
            this.Text = "V_ReporteEstudiante";
            this.Load += new System.EventHandler(this.V_ReporteEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteEstudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obtenerReporteEstudianteBindingSource;
        private Reportes.ReportesDataSet reportesDataSet;
        private Reportes.ReportesDataSetTableAdapters.ObtenerReporteEstudianteTableAdapter obtenerReporteEstudianteTableAdapter;
    }
}