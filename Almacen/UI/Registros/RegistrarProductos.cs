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

namespace AlmacenLT.UI.Registros
{
    public partial class RegistrarProductos : Form
    {
        public RegistrarProductos()
        {
            InitializeComponent();
        }

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonBuscar, "Haga click para buscar.");
            toolTip.SetToolTip(buttonNuevo, "Haga click para crear una nueva ruta.");
            toolTip.SetToolTip(buttonGuardar, "Haga click para guardar una nueva ruta.");
            toolTip.SetToolTip(buttonEliminar, "Haga click para eliminar una ruta");
        }

        private void LlenarFormulario(Producto producto)
        {
            if (producto != null)
            {
                maskedTextBoxId.Text = producto.ProductoId.ToString();
                maskedTextBoxCantidad.Text = producto.Cantidad.ToString();
                textBoxNombre.Text = producto.Nombre;
                maskedTextBoxCosto.Text = producto.Costo.ToString();
                maskedTextBoxPrecio.Text = producto.Precio.ToString();
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {

            timerEscribiendo.Dispose();
            timerEscribiendo.Interval = 300;
            timerEscribiendo.Enabled = true;

            toolStripLabelHaciendo.Text = "Escribiendo";
        }

        private void timer_TerminoDeEscribir(object sender, EventArgs e)
        {
            toolStripLabelHaciendo.Text = "Ninguno";
            timerEscribiendo.Enabled = false;
            timerEscribiendo.Stop();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                ProductosBLL.Buscar(x => x.ProductoId == id);
                LlenarFormulario(ProductosBLL.productoReturned);
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos invalidos o incorrectos.";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                if (ProductosBLL.Buscar(x => x.ProductoId == id))
                {
                    if (ProductosBLL.Eliminar(ProductosBLL.productoReturned))
                    {
                        toolStripLabelHaciendo.Text = "Cliente eliminado!";
                        UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxNombre }, new List<MaskedTextBox> { maskedTextBoxId, maskedTextBoxCosto, maskedTextBoxCantidad, maskedTextBoxPrecio }, null);

                    }
                }
                else
                {
                    toolStripLabelHaciendo.Text = "Cliente no encontrado!";
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos invalidos o incorrectos.";
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxNombre }, new List<MaskedTextBox> { maskedTextBoxId, maskedTextBoxCosto, maskedTextBoxCantidad, maskedTextBoxPrecio }, null);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(textBoxNombre) && UtilidadesFormularios.Validar(new List<MaskedTextBox> { maskedTextBoxCantidad, maskedTextBoxCosto, maskedTextBoxPrecio }))
            {
                int id = 0;
                int.TryParse(maskedTextBoxId.Text, out id);

                Producto producto = new Producto(id, textBoxNombre.Text, int.Parse(maskedTextBoxCosto.Text), int.Parse(maskedTextBoxPrecio.Text), int.Parse(maskedTextBoxCantidad.Text));

                if (!ProductosBLL.Buscar(x => x.ProductoId == id))
                {

                    if (ProductosBLL.Guardar(producto))
                    {
                        LlenarFormulario(ProductosBLL.productoReturned);
                    }
                }
                else
                {
                    if (ProductosBLL.Modificar(producto))
                    {
                        LlenarFormulario(ProductosBLL.productoReturned);
                    }
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos invalidos o incorrectos.";
            }
        }
    }
}
