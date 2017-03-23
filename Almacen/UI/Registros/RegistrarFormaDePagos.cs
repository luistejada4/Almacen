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
    public partial class RegistrarFormaDePagos : Form
    {
        public RegistrarFormaDePagos()
        {
            InitializeComponent();
        }

        private void LlenarFormulario(FormaDePago formaDePago)
        {
            if (formaDePago != null)
            {
                maskedTextBoxId.Text = formaDePago.FormaDePagoId.ToString();
                textBoxDescripcion.Text = formaDePago.Descripcion;   
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {

                int id = int.Parse(maskedTextBoxId.Text);
                FormasDePagosBLL.Buscar(x => x.FormaDePagoId == id);
                LlenarFormulario(FormasDePagosBLL.formaDePagoReturned);
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos incorrectos o invalidos.";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                if (FormasDePagosBLL.Buscar(x => x.FormaDePagoId == id))
                {
                    if (FormasDePagosBLL.Eliminar(FormasDePagosBLL.formaDePagoReturned))
                    {
                        toolStripLabelHaciendo.Text = "Cliente eliminado!";
                        UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxDescripcion }, new List<MaskedTextBox> { maskedTextBoxId }, null);
                    }
                }
                else
                {
                    toolStripLabelHaciendo.Text = "Cliente no encontrado!";
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos incorrectos o invalidos.";
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(new List<TextBox> { textBoxDescripcion}, null, null))
            {
                int id = 0;
                int.TryParse(maskedTextBoxId.Text, out id);

                FormaDePago formaDePago = new FormaDePago(id, textBoxDescripcion.Text);

                if (!FormasDePagosBLL.Buscar(x => x.FormaDePagoId == id))
                {

                    if (FormasDePagosBLL.Guardar(formaDePago))
                    {
                        LlenarFormulario(FormasDePagosBLL.formaDePagoReturned);
                    }
                }
                else
                {
                    if (FormasDePagosBLL.Modificar(formaDePago))
                    {
                        LlenarFormulario(FormasDePagosBLL.formaDePagoReturned);
                    }
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos incorrectos o invalidos.";
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxDescripcion }, new List<MaskedTextBox> { maskedTextBoxId }, null);
        }

        private void RegistrarFormaDePagos_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonBuscar, "Haga click para buscar.");
            toolTip.SetToolTip(buttonNuevo, "Haga click para crear una nueva ruta.");
            toolTip.SetToolTip(buttonGuardar, "Haga click para guardar una nueva ruta.");
            toolTip.SetToolTip(buttonEliminar, "Haga click para eliminar una ruta");
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
        private void backgroundWorkerGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorkerGuardar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorkerGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
        private void backgroundWorkerBuscar_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorkerBuscar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorkerBuscar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            

        }
        private void backgroundWorkerEliminar_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorkerEliminar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void backgroundWorkerEliminar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
