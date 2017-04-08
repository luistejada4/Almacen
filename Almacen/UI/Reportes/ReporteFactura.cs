using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen.UI
{
    public partial class ReporteFactura : Form
    {
        public Factura Factura { get; set; }
        public List<ProductosInFacturas> Productos { get; set; }
        public ReporteFactura(Factura factura, List<ProductosInFacturas> productos)
        {
            InitializeComponent();
            this.Factura = factura;
            this.Productos = productos;
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            FacturaBindingSource.DataSource = this.Factura;
            ClienteBindingSource.DataSource = this.Factura.Cliente;
            RutaBindingSource.DataSource = this.Factura.Cliente.Ruta;
            ProductosInFacturasBindingSource.DataSource = this.Productos;
       
            this.reportViewer1.RefreshReport();

        }
    }
}
