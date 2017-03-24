using AlmacenLT.Utilidades;
using BLL;
using DAL;
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
    public partial class RegistrarRuta : Form
    {
        public RegistrarRuta()
        {
            InitializeComponent();
        }

        private void LlenarFormulario(Ruta ruta)
        {
            if (ruta != null)
            {
                maskedTextBoxId.Text = ruta.RutaId.ToString();
                textBoxLugar.Text = ruta.Lugar;
                comboBoxDias.SelectedIndex = ruta.Dia;          
            }
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            UtilidadesFormularios.Limpiar(new List<TextBox>() { textBoxLugar }, new List<MaskedTextBox>() { maskedTextBoxId }, new List<ComboBox>(){comboBoxDias});
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                if(RutasBLL.Buscar(x=> x.RutaId == id, false))
                {
                    LlenarFormulario(RutasBLL.rutaReturned);
                }
                else
                {
                    toolStripLabelHaciendo.Text = "Esta ruta no existe";
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos incorrectos";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                if (RutasBLL.Eliminar(new Ruta(int.Parse(maskedTextBoxId.Text), textBoxLugar.Text, comboBoxDias.SelectedIndex)))
                {
                    toolStripLabelHaciendo.Text = "Ruta eliminada!";
                    UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxLugar }, new List<MaskedTextBox> { maskedTextBoxId }, new List<ComboBox> { comboBoxDias });
                }
                else
                {
                    toolStripLabelHaciendo.Text = "Esta ruta no existe!";
                }
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos incorrectos";
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(new List<TextBox>() {textBoxLugar}, null, new List<ComboBox>() { comboBoxDias}))
            {
                int id = 0;
                int.TryParse(maskedTextBoxId.Text, out id);
                Ruta ruta = new Ruta(id, textBoxLugar.Text, comboBoxDias.SelectedIndex);

                using (var db = new Repositorio<Ruta>())
                {
                   if(RutasBLL.Guardar(ruta))
                    {
                        LlenarFormulario(RutasBLL.rutaReturned);
                    }
                }  
            }
            else
            {
                toolStripLabelHaciendo.Text = "Datos incorrectos";
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

        private void RegistrarRuta_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonBuscar, "Haga click para buscar.");
            toolTip.SetToolTip(buttonNuevo, "Haga click para crear una nueva ruta.");
            toolTip.SetToolTip(buttonGuardar, "Haga click para guardar una nueva ruta.");
            toolTip.SetToolTip(buttonEliminar, "Haga click para eliminar una ruta");
        }
    }
}
