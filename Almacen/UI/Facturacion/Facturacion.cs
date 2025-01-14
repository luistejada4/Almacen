﻿using Almacen.UI;
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
    public partial class Facturacion : Form
    {

        public Facturacion()
        {
            InitializeComponent();
        }
        
        private bool ValidarFactura()
        {
            if(UtilidadesFormularios.Validar(null, null, new List<ComboBox> { comboBoxCliente, comboBoxFormaDePago, comboBoxProductos}))
            {
                if(!string.IsNullOrEmpty(Convert.ToString(dataGridView.Rows[0].Cells[0].Value)))
                {
                    return true;
                }
            }
            return false;
        }
        

        private void LimpiarFactura()
        {
            UtilidadesFormularios.Limpiar(null , new List<MaskedTextBox> { maskedTextBoxId }, new List<ComboBox> { comboBoxFormaDePago, comboBoxProductos, comboBoxCliente });
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            labelEstado.Text = "";
        }
        private void VerificarPagos(Factura factura)
        {
            double total = 0;

            foreach (var pago in factura.Pagos)
            {
                total += pago.Monto;
            }
            if(total < factura.Total)
            {
                labelEstado.Text = "Debe: " + (factura.Total - total).ToString();
                labelEstado.ForeColor = Color.Red;
            }
            else
            {
                labelEstado.Text = "Pagada";
                labelEstado.ForeColor = Color.Green;
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

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAlmacenDataSet.Productos' table. You can move, or remove it, as needed.
            
            if (ClientesBLL.GetList(x => x.ClienteId > 0, true))
            {
                comboBoxCliente.DataSource = ClientesBLL.clienteReturnedList;
                comboBoxCliente.DisplayMember = "Nombres";
                comboBoxCliente.ValueMember = "ClienteId";
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
            if (string.IsNullOrWhiteSpace(maskedTextBoxId.Text))
            {
                if (dataGridView.Rows.Count == 0)
                {
                    dataGridView.Rows.Add();
                    DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0];
                    Producto producto = (Producto)comboBoxProductos.SelectedItem;
                    row.Cells[0].Value = producto.ProductoId;
                    row.Cells[1].Value = producto.Nombre;
                    row.Cells[2].Value = numericUpDownCantidad.Value;
                    row.Cells[3].Value = producto.Precio;
                    row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);

                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                    Producto producto = (Producto)comboBoxProductos.SelectedItem;

                    bool inRow = false;
                    foreach (DataGridViewRow productoRow in dataGridView.Rows)
                    {
                        if (Convert.ToInt32(productoRow.Cells[0].Value) == producto.ProductoId)
                        {
                            productoRow.Cells[2].Value = Convert.ToInt32(productoRow.Cells[2].Value) + numericUpDownCantidad.Value;
                            inRow = true;
                        }
                    }
                    if (!inRow)
                    {
                        row.Cells[0].Value = producto.ProductoId;
                        row.Cells[1].Value = producto.Nombre;
                        row.Cells[2].Value = numericUpDownCantidad.Value;
                        row.Cells[3].Value = producto.Precio;
                        row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                        dataGridView.Rows.Add(row);
                    }
                }
                CalcularFactura();
            }
            else
            {
                MessageBox.Show("No puede agregar productos a una factura ya guardada");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFactura())
            {
                int id = Convert.ToInt32(comboBoxCliente.SelectedValue);
                if (ClientesBLL.Buscar(x => x.ClienteId == id, false))
                {
                    id = 0;
                    int.TryParse(maskedTextBoxId.Text, out id);
                    Factura factura = new Factura(id, ClientesBLL.clienteReturned.ClienteId, ((FormaDePago)comboBoxFormaDePago.SelectedItem).FormaDePagoId, DateTime.Now, float.Parse(labelTotal.Text), 1);



                    if (!FacturasBLL.Buscar(x => x.FacturaId == factura.FacturaId, true))
                    {
                        foreach (DataGridViewRow producto in dataGridView.Rows)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(producto.Cells[0].Value)) && !string.IsNullOrWhiteSpace(Convert.ToString(producto.Cells[0].Value)))
                            {
                                int productoId = Convert.ToInt32(producto.Cells[0].Value);
                                ProductosBLL.Buscar(x => x.ProductoId == productoId, false);
                                factura.Productos.Add(new ProductoFactura(ProductosBLL.productoReturned.ProductoId, factura.FacturaId, Convert.ToInt32(producto.Cells[2].Value), Convert.ToInt32(producto.Cells[3].Value)));
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
                                int productoCantidad = Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                                factura.Productos.Add(new ProductoFactura(productoId, factura.FacturaId, productoCantidad, Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value)));

                            }
                        }
                        factura.Pagos = null;
                        
                        if (FacturasBLL.Modificar(factura))
                        {
                            maskedTextBoxId.Text = FacturasBLL.facturaReturned.FacturaId.ToString();
                            CalcularFactura();
                        }
                    }
                    FacturasBLL.Buscar(x => x.FacturaId == factura.FacturaId, true);
                    VerificarPagos(FacturasBLL.facturaReturned);
                }
                else
                {

                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                
                if(FacturasBLL.Buscar(x=> x.FacturaId == id, true))
                {
                    dataGridView.Rows.Clear();
                    dataGridView.Refresh();
                    Factura factura = FacturasBLL.facturaReturned;
                    comboBoxCliente.Text = factura.Cliente.Nombres;
                    dateTimePicker1.Value = factura.Fecha;
                    comboBoxFormaDePago.SelectedValue = factura.FormaDePagoId;

                    foreach (var producto in factura.Productos)
                    {
                        if (dataGridView.Rows.Count == 0)
                        {
                            dataGridView.Rows.Add();
                            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0];
                            row.Cells[0].Value = producto.ProductoId;
                            row.Cells[1].Value = producto.Producto.Nombre;
                            row.Cells[2].Value = producto.Cantidad;
                            row.Cells[3].Value = producto.Precio;
                            row.Cells[4].Value = row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);

                        }
                        else
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                            row.Cells[0].Value = producto.ProductoId;
                            row.Cells[1].Value = producto.Producto.Nombre;
                            row.Cells[2].Value = producto.Cantidad;
                            row.Cells[3].Value = producto.Precio;
                            row.Cells[4].Value = row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                            dataGridView.Rows.Add(row);
                        }
                    }


                    CalcularFactura();
                    VerificarPagos(factura);
                }
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                if(FacturasBLL.Buscar(x=> x.FacturaId == id, false))
                {
                    FacturasBLL.Eliminar(FacturasBLL.facturaReturned);
                    LimpiarFactura();
                }
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFactura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarUsuario().ShowDialog(this);
        }

        private void comboBoxFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).SelectedIndex == 0)
            {
                groupBoxInicial.Visible = true;
            }
            else
            {
                groupBoxInicial.Visible = false;
            }
        }

        private void groupBoxTotal_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                new PagarFactura(id).ShowDialog(this);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int facturaId = int.Parse(maskedTextBoxId.Text);
                FacturasBLL.Buscar(x => x.FacturaId == facturaId, true);
                
                List<ProductosInFacturas> productos = new List<ProductosInFacturas>();
                ProductosFacturasBLL.GetList(x => x.FacturaId == facturaId, true);
                foreach (var producto in ProductosFacturasBLL.productoFacturaReturnedList)
                {
                    productos.Add(new ProductosInFacturas(producto.Producto.Nombre, producto.Cantidad, producto.Precio));
                }

                new ReporteFactura(FacturasBLL.facturaReturned, productos).Show();           
            }
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }
    }
}
