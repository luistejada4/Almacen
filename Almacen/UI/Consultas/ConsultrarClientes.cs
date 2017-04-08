using Almacen.UI.Reportes;
using AlmacenLT.Utilidades;
using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenLT.UI.Consultas
{
    public partial class ConsultrarClientes : Form
    {
        public ConsultrarClientes()
        {
            InitializeComponent();
        }

        private void LlenarGrid(List<Cliente> clientes)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            foreach (var cliente in clientes)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = cliente.ClienteId;
                row.Cells[1].Value = cliente.Nombres;
                row.Cells[2].Value = cliente.Ruta.Lugar;
                dataGridView.Rows.Add(row);
            }
        }


        private void ConsultrarCliente_Load(object sender, EventArgs e)
        {
            checkBoxNombre.Checked = false;
            toolStripTextBoxSearch.Enabled = false;
            RutasBLL.GetList(x => x.RutaId > 0, false);
            comboBox1.DataSource = RutasBLL.rutaReturnedList;
            comboBox1.DisplayMember = "Lugar";
            comboBox1.ValueMember = "RutaId";
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            int rutaId = Convert.ToInt32(comboBox1.SelectedValue);
            if (checkBoxNombre.Checked && checkBoxRuta.Checked)
            {
                if (!string.IsNullOrEmpty(toolStripTextBoxSearch.Text) || !string.IsNullOrWhiteSpace(toolStripTextBoxSearch.Text))
                {

                    if (ClientesBLL.GetList(x => x.Nombres.Contains(toolStripTextBoxSearch.Text) && x.RutaId == rutaId, true))
                    {
                        LlenarGrid(ClientesBLL.clienteReturnedList);
                    }
                }
            }
            else
            {
                if (checkBoxNombre.Checked)
                {
                    if (ClientesBLL.GetList(x => x.Nombres.Contains(toolStripTextBoxSearch.Text), true))
                    {
                        LlenarGrid(ClientesBLL.clienteReturnedList);
                    }
                }
                else if(checkBoxRuta.Checked)
                {
                    if (ClientesBLL.GetList(x => x.RutaId == rutaId, true))
                    {
                        LlenarGrid(ClientesBLL.clienteReturnedList);
                    }
                }
                else
                {
                    if (ClientesBLL.GetList(x => x.RutaId > 0, true))
                    {
                        LlenarGrid(ClientesBLL.clienteReturnedList);
                    }
                }
            }
   

        }

        private void checkBoxNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNombre.Checked) toolStripTextBoxSearch.Enabled = true;
            else toolStripTextBoxSearch.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            new ReporteClientes(ClientesBLL.clienteReturnedList).ShowDialog(this);
        }
    }
}
