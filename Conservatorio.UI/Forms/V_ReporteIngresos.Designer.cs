namespace Conservatorio.UI.Forms
{
    partial class V_ReporteIngresos
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
            this.obtenerReporteIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerReporteIngresosTableAdapter = new Conservatorio.UI.Reportes.ReportesDataSetTableAdapters.ObtenerReporteIngresosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteIngresosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReporteIngresosDataSet";
            reportDataSource1.Value = this.obtenerReporteIngresosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Conservatorio.UI.Reportes.ReporteIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerReporteIngresosBindingSource
            // 
            this.obtenerReporteIngresosBindingSource.DataMember = "ObtenerReporteIngresos";
            this.obtenerReporteIngresosBindingSource.DataSource = this.reportesDataSet;
            // 
            // obtenerReporteIngresosTableAdapter
            // 
            this.obtenerReporteIngresosTableAdapter.ClearBeforeFill = true;
            // 
            // V_ReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "V_ReporteIngresos";
            this.Text = "V_ReporteIngresos";
            this.Load += new System.EventHandler(this.V_ReporteIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteIngresosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obtenerReporteIngresosBindingSource;
        private Reportes.ReportesDataSet reportesDataSet;
        private Reportes.ReportesDataSetTableAdapters.ObtenerReporteIngresosTableAdapter obtenerReporteIngresosTableAdapter;
    }
}