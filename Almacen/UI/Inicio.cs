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
        private void VerFacturacion(bool ver)
        {
            groupBoxFactura.Visible = ver;
            groupBoxBotones.Visible = ver;
            groupBoxTotal.Visible = ver;
            if (ver)
            {
                if (ClientesBLL.GetList(x => x.ClienteId > 0, true))
                {
                    foreach (var cliente in ClientesBLL.clienteReturnedList)
                    {
                        textBoxNombre.AutoCompleteCustomSource.Add(cliente.Nombres);
                    }
                }
                if (ProductosBLL.GetList(x => x.ProductoId > 0, false))
                {
                    comboBoxProductos.DataSource = ProductosBLL.productoReturnedList;
                    comboBoxProductos.DisplayMember = "Nombre";
                    comboBoxProductos.ValueMember = "ProductoId";
                }
                if (FormasDePagosBLL.GetList(x => x.FormaDePagoId > 0))
                {
                    comboBoxFormaDePago.DataSource = FormasDePagosBLL.formaDePagoReturnedList;
                    comboBoxFormaDePago.DisplayMember = "Descripcion";
                    comboBoxFormaDePago.ValueMember = "FormaDePagoId";
                }
            }
            else
            {
                textBoxNombre.AutoCompleteCustomSource.Clear();
            }
        }
        private void CalcularFactura()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Value);
            }
            labelTotal.Text = total.ToString();
            labelSubTotal.Text = total.ToString();
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
            CalcularFactura();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells[4].Value = Convert.ToDouble(dataGridView.Rows[e.RowIndex].Cells[2].Value) * Convert.ToDouble(dataGridView.Rows[e.RowIndex].Cells[3].Value);

            CalcularFactura();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
            Producto producto = (Producto)comboBoxProductos.SelectedItem;
            row.Cells[0].Value = producto.ProductoId;
            row.Cells[1].Value = producto.Nombre;
            row.Cells[2].Value = numericUpDownCantidad.Value;
            row.Cells[3].Value = producto.Precio;
            row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
            dataGridView.Rows.Add(row);


        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ClientesBLL.Buscar(x => x.Nombres == textBoxNombre.Text, false))
            {
                int id = 0;
                int.TryParse(maskedTextBoxId.Text, out id);
                Factura factura = new Factura(id, ClientesBLL.clienteReturned.ClienteId, ((FormaDePago)comboBoxFormaDePago.SelectedItem).FormaDePagoId, DateTime.Now, float.Parse(labelSubTotal.Text), float.Parse(labelTotal.Text));

               

                if (!FacturasBLL.Buscar(x => x.FacturaId == factura.FacturaId, true))
                {
                    foreach (DataGridViewRow producto in dataGridView.Rows)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(producto.Cells[0].Value)) && !string.IsNullOrWhiteSpace(Convert.ToString(producto.Cells[0].Value)))
                        {
                            int productoId = Convert.ToInt32(producto.Cells[0].Value);
                            ProductosBLL.Buscar(x => x.ProductoId == productoId, false);
                            factura.Productos.Add(new ProductoFactura(ProductosBLL.productoReturned.ProductoId, factura.FacturaId));
                        }
                    }
                    if (FacturasBLL.Guardar(factura))
                    {
                        maskedTextBoxId.Text = FacturasBLL.facturaReturned.FacturaId.ToString();
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(dataGridView.Rows[i].Cells[0].Value)) && !string.IsNullOrWhiteSpace(Convert.ToString(dataGridView.Rows[i].Cells[0].Value)))
                        {
                            int productoId = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
                            factura.Productos.Add(new ProductoFactura(productoId, factura.FacturaId));                                      
                            
                        }
                    }

                    if(FacturasBLL.Modificar(factura))
                    {
                        maskedTextBoxId.Text = FacturasBLL.facturaReturned.FacturaId.ToString();
                    }
                }
            }
            else
            {
      
            }
        }
    }
}
