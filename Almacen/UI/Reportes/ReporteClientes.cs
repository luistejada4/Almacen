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
    
    public partial class ReporteClientes : Form
    {
        public List<Cliente> Clientes{ get; set; }
        public ReporteClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            this.Clientes = clientes;
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            ClienteBindingSource.DataSource = this.Clientes;
            this.reportViewer1.RefreshReport();
        }
    }
}
