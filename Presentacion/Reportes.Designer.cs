
namespace Presentacion
{
    partial class Reportes
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
            this.VKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VILLAEJEMPLODataSet = new Presentacion.VILLAEJEMPLODataSet();
            this.AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VKardexTableAdapter = new Presentacion.VILLAEJEMPLODataSetTableAdapters.VKardexTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VILLAEJEMPLODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VKardexBindingSource
            // 
            this.VKardexBindingSource.DataMember = "VKardex";
            this.VKardexBindingSource.DataSource = this.VILLAEJEMPLODataSet;
            // 
            // VILLAEJEMPLODataSet
            // 
            this.VILLAEJEMPLODataSet.DataSetName = "VILLAEJEMPLODataSet";
            this.VILLAEJEMPLODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlumnoBindingSource
            // 
            this.AlumnoBindingSource.DataMember = "Alumno";
            this.AlumnoBindingSource.DataSource = this.VILLAEJEMPLODataSet;
            // 
            // VKardexTableAdapter
            // 
            this.VKardexTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VKardexBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(97, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VILLAEJEMPLODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource AlumnoBindingSource;
        private System.Windows.Forms.BindingSource VKardexBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Presentacion.VILLAEJEMPLODataSet VILLAEJEMPLODataSet;
        private Presentacion.VILLAEJEMPLODataSetTableAdapters.VKardexTableAdapter VKardexTableAdapter;
    }
}