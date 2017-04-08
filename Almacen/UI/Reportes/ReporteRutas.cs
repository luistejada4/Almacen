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

namespace Almacen.UI.Reportes
{
    public partial class ReporteRutas : Form
    {
        public Ruta Rutas { get; set; }
        public List<Cliente> Clientes { get; set; }
        public ReporteRutas(List<Cliente> clientes, Ruta ruta)
        {
            InitializeComponent();
            Clientes = clientes;
            Rutas = ruta;
        }

        private void ReporteRutas_Load(object sender, EventArgs e)
        {
            RutaBindingSource.DataSource = Rutas;
            ClienteBindingSource.DataSource = Clientes;
            this.reportViewer1.RefreshReport();
        }
    }
}
