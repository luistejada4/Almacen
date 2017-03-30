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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Factura";
            reportDataSource1.Value = this.FacturaBindingSource;
            reportDataSource2.Name = "Productos";
            reportDataSource2.Value = this.ProductoBindingSource;
            reportDataSource3.Name = "Cliente";
            reportDataSource3.Value = this.ClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.Reportes.FacturaProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(641, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataSource = typeof(Entidades.Factura);
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(Entidades.Producto);
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataSource = typeof(Entidades.Cliente);
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura";
            this.Text = "ReporteFactura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
    }
}