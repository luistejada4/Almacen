using BLL;
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

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(toolStripTextBoxSearch.Text) || !string.IsNullOrWhiteSpace(toolStripTextBoxSearch.Text))
            {


                if (ProductosBLL.GetList(x => x.Nombre.Contains(toolStripTextBoxSearch.Text), false))
                {
                    foreach (var producto in ProductosBLL.productoReturnedList)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                        row.Cells[0].Value = producto.ProductoId;
                        row.Cells[1].Value = producto.Nombre;
                        row.Cells[2].Value = producto.Cantidad;
                        row.Cells[3].Value = producto.Costo;
                        row.Cells[4].Value = producto.Precio;
                        dataGridView.Rows.Add(row);
                    }
                }
            }
            else
            {
                if (ProductosBLL.GetList(x => x.ProductoId > 0 , false))
                {
                    foreach (var producto in ProductosBLL.productoReturnedList)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                        row.Cells[0].Value = producto.ProductoId;
                        row.Cells[1].Value = producto.Nombre;
                        row.Cells[2].Value = producto.Cantidad;
                        row.Cells[3].Value = producto.Costo;
                        row.Cells[4].Value = producto.Precio;
                        dataGridView.Rows.Add(row);
                    }
                }
            }
        }
    }
}
