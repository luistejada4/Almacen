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

namespace Almacen.UI.Facturacion
{
    public partial class PagarFactura : Form
    {
        private Factura factura;
        public PagarFactura(int facturaId)
        {
            InitializeComponent();
            maskedTextBoxId.Text = facturaId.ToString();
        }

        private void PagarFactura_Load(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);
            FacturasBLL.Buscar(x => x.FacturaId == id, true);

            factura = FacturasBLL.facturaReturned;

            double totalPagos = 0;
            foreach(var pago in factura.Pagos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = pago.PagoId;
                row.Cells[1].Value = pago.Fecha;
                row.Cells[2].Value = pago.Monto;
                dataGridView1.Rows.Add(row);
                totalPagos += pago.Monto;
            }

            if (totalPagos > factura.Total)
            {
                labelEstado.Text = "Pagada";
                labelEstado.ForeColor = Color.Green;
            }
            else
            {
                labelEstado.Text = "Debe";
                labelEstado.ForeColor = Color.Red;
            }

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            UtilidadesFormularios.Limpiar(null, new List<MaskedTextBox> { maskedTextBoxMonto }, null);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxMonto))
            {
                int id = 0;
                int.TryParse(maskedTextBoxPagoId.Text, out id);
                Pago pago = new Pago(id, double.Parse(maskedTextBoxMonto.Text), dateTimePicker1.Value, int.Parse(maskedTextBoxId.Text));

                if(PagosBLL.Guardar(pago))
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = PagosBLL.pagoReturned.PagoId;
                    row.Cells[1].Value = PagosBLL.pagoReturned.Fecha;
                    row.Cells[2].Value = PagosBLL.pagoReturned.Monto;
                    dataGridView1.Rows.Add(row);
                    maskedTextBoxPagoId.Text = PagosBLL.pagoReturned.PagoId.ToString() ;
                }
            }
        }
    }
}
