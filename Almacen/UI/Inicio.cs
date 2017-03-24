using AlmacenLT.UI.Consultas;
using AlmacenLT.UI.Registros;
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
        private void VerFacturacion(bool ver)
        {
            groupBoxFactura.Visible = ver;
            groupBoxBotones.Visible = ver;
            groupBoxTotal.Visible = ver;
            if(ver)
            {
                if (ClientesBLL.GetList(x => x.ClienteId > 0, false))
                {
                    foreach (var cliente in ClientesBLL.clienteReturnedList)
                    {
                        textBoxNombre.AutoCompleteCustomSource.Add(cliente.Nombres);
                    }
                }
                if(ProductosBLL.GetList(x=> x.ProductoId > 0, false))
                {
                    comboBoxProductos.DataSource = ProductosBLL.productoReturnedList;
                    comboBoxProductos.DisplayMember = "Nombre";
                    comboBoxProductos.ValueMember = "ProductoId";
                }
            }
            else
            {
                textBoxNombre.AutoCompleteCustomSource.Clear();
            }
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

        private void tiposDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarFormaDePagos().ShowDialog(this);
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
            // TODO: This line of code loads data into the 'databaseAlmacenDataSet.Productos' table. You can move, or remove it, as needed.

            VerFacturacion(false);                     

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerFacturacion(true);   
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
            Producto producto = (Producto)comboBoxProductos.SelectedItem;
            row.Cells[0].Value = producto.Nombre;
            row.Cells[1].Value = 1;
            row.Cells[2].Value = producto.Precio;
            dataGridView.Rows.Add(row);

            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(ClientesBLL.Buscar(x => x.Nombres == textBoxNombre.Text, false))
            {                           
                
            }
        }
    }
}
