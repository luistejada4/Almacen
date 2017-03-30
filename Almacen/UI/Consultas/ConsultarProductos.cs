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

namespace AlmacenLT.UI.Consultas
{
    public partial class ConsultarProductos : Form
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void LlenarGrid(List<Producto> productos)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            foreach (var producto in productos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = producto.ProductoId;
                row.Cells[1].Value = producto.Nombre;

                row.Cells[3].Value = producto.Costo;
                row.Cells[4].Value = producto.Precio;
                dataGridView.Rows.Add(row);
            }
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            if (checkBoxNombre.Checked)
            {
                if (!string.IsNullOrEmpty(toolStripTextBoxSearch.Text) || !string.IsNullOrWhiteSpace(toolStripTextBoxSearch.Text))
                {

                    if (ProductosBLL.GetList(x => x.Nombre.Contains(toolStripTextBoxSearch.Text), false))
                    {
                        LlenarGrid(ProductosBLL.productoReturnedList);
                    }
                }              
            }
            else
            {
                if (ProductosBLL.GetList(x => x.ProductoId > 0, false))
                {
                    LlenarGrid(ProductosBLL.productoReturnedList);
                }
            }
        }

        private void checkBoxNombre_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNombre.Checked) toolStripTextBoxSearch.Enabled = true;
            else toolStripTextBoxSearch.Enabled = false;
        }

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Enabled = false;
            checkBoxNombre.Checked = false;
        }
    }
}
