namespace Almacen.UI
{
    partial class ReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosInFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosInFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataSource = typeof(Entidades.Cliente);
            // 
            // RutaBindingSource
            // 
            this.RutaBindingSource.DataSource = typeof(Entidades.Ruta);
            // 
            // ProductosInFacturasBindingSource
            // 
            this.ProductosInFacturasBindingSource.DataSource = typeof(Entidades.ProductosInFacturas);
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataSource = typeof(Entidades.Factura);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cliente";
            reportDataSource1.Value = this.ClienteBindingSource;
            reportDataSource2.Name = "Ruta";
            reportDataSource2.Value = this.RutaBindingSource;
            reportDataSource3.Name = "productos";
            reportDataSource3.Value = this.ProductosInFacturasBindingSource;
            reportDataSource4.Name = "Factura";
            reportDataSource4.Value = this.FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.Reportes.factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(528, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura";
            this.Text = "ReporteFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosInFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private System.Windows.Forms.BindingSource RutaBindingSource;
        private System.Windows.Forms.BindingSource ProductosInFacturasBindingSource;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
    }
}