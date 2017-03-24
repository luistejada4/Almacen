using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmacenLT.Utilidades;
using Entidades;
using BLL;
using DAL;
using System.Data.Entity;

namespace AlmacenLT.UI.Registros
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }
        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            maskedTextBoxId.Focus();
            

            toolTip.SetToolTip(buttonBuscar, "Haga click para buscar un cliente.");
            toolTip.SetToolTip(buttonNuevo, "Haga click para limpiar datos y crear un nuevo cliente.");
            toolTip.SetToolTip(buttonGuardar, "Haga click para guardar un cliente.");
            toolTip.SetToolTip(buttonEliminar, "Haga click para eliminar un cliente.");

            RutasBLL.GetList(x => x.RutaId > 0, false);
            comboBoxRutas.DataSource = RutasBLL.rutaReturnedList;
            comboBoxRutas.DisplayMember = "Lugar";
            comboBoxRutas.ValueMember = "RutaId";
        }

        private void LlenarFormulario(Cliente cliente)
        {
            if (cliente != null)
            {
                maskedTextBoxId.Text = cliente.ClienteId.ToString();
                textBoxNombre.Text = cliente.Nombres;
                comboBoxRutas.SelectedValue = cliente.RutaId;
                maskedTextBoxTelefono.Text = cliente.Telefono;
                textBoxDireccion.Text = cliente.Direccion;
                maskedTextBoxCedula.Text = cliente.Cedula;
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            UtilidadesFormularios.Limpiar(new List<TextBox>() { textBoxNombre, textBoxDireccion },
                new List<MaskedTextBox>() { maskedTextBoxId, maskedTextBoxTelefono, maskedTextBoxCedula },
                new List<ComboBox>() { comboBoxRutas });
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(new List<TextBox>() { textBoxNombre, textBoxDireccion },
                new List<MaskedTextBox>() { maskedTextBoxTelefono, maskedTextBoxCedula },
                new List<ComboBox> { comboBoxRutas }))
            {
                int id = 0;
                int.TryParse(maskedTextBoxId.Text, out id);
                int rutaId = Convert.ToInt32(comboBoxRutas.SelectedValue);
                Cliente cliente = new Cliente(id, textBoxNombre.Text, textBoxDireccion.Text, maskedTextBoxTelefono.Text, maskedTextBoxCedula.Text, DateTime.Now, rutaId);

                if (!ClientesBLL.Buscar(x => x.ClienteId == id, false))
                {

                    if (ClientesBLL.Guardar(cliente))
                    {
                        LlenarFormulario(ClientesBLL.clienteReturned);
                    }
                }
                else
                {
                    if (ClientesBLL.Modificar(cliente))
                    {
                        LlenarFormulario(ClientesBLL.clienteReturned);
                    }
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos vacios o incorrectos!";
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
      
                int id = int.Parse(maskedTextBoxId.Text);
                ClientesBLL.Buscar(x => x.ClienteId == id, false);
                LlenarFormulario(ClientesBLL.clienteReturned);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                if (ClientesBLL.Buscar(x=> x.ClienteId == id, false))
                {
                    if(ClientesBLL.Eliminar(ClientesBLL.clienteReturned))
                    {
                        toolStripLabelHaciendo.Text = "Cliente eliminado!";

                        UtilidadesFormularios.Limpiar(new List<TextBox>() { textBoxNombre, textBoxDireccion },
                new List<MaskedTextBox>() { maskedTextBoxId, maskedTextBoxTelefono, maskedTextBoxCedula },
                new List<ComboBox>() { comboBoxRutas });

                    }
                }
                else
                {
                    toolStripLabelHaciendo.Text = "Cliente no encontrado!";
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Id vacio o incorrecto";
            }
        }
    }
}
