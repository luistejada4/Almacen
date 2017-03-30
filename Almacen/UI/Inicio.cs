using Almacen.UI;
using Almacen.UI.Facturacion;
using Almacen.UI.Registros;
using AlmacenLT.UI.Consultas;
using AlmacenLT.UI.Registros;
using AlmacenLT.Utilidades;
using BLL;
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

namespace AlmacenLT
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarCliente().ShowDialog(this);
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarRuta().ShowDialog(this);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarProductos().ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new RegistrarCliente().ShowDialog(this);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new RegistrarProductos().ShowDialog(this);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultrarClientes().ShowDialog(this);
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultarProductos().ShowDialog(this);
        }

        private void rutasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultarRutas().ShowDialog(this);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAlmacenDataSet.Productos' table. You can move, or remove it, as needed
            
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion().ShowDialog(this);
        }
    }
}
