using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Almacen.UI
{
    public partial class ReporteFactura : Form
    {
        public List<Producto> lista { get; set; }
        public Cliente cliente { get; set; }
        public Factura Factura { get; set; }
        public ReporteFactura()
        {
            InitializeComponent();
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            foreach (var prod in lista)
            {
                ProductoBindingSource.Add(prod);
            }
            FacturaBindingSource.Add(Factura);
            ClienteBindingSource.Add(cliente);
            this.reportViewer1.RefreshReport();
        }
    }
}
