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

namespace Almacen.UI.Registros
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
               if(UsuariosBLL.Buscar(x=> x.UsuarioId == id, false))
                {
                    textBoxUserName.Text = UsuariosBLL.usuarioReturned.UserName;
                    textBoxPassword.Text = UsuariosBLL.usuarioReturned.Password;
                    textBoxRepeatPassword.Text = UsuariosBLL.usuarioReturned.Password;
                }
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxPassword, textBoxRepeatPassword }, new List<MaskedTextBox>{ maskedTextBoxId}, null);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(new List<TextBox> { textBoxPassword, textBoxRepeatPassword}, null, null))
            {
                int id = 0;
                int.TryParse(maskedTextBoxId.Text, out id);
                Usuario usuario = new Usuario(id, textBoxUserName.Text, textBoxPassword.Text);

                if(!UsuariosBLL.Buscar(x => x.UsuarioId == id, false))
                {
                    if (UsuariosBLL.Guardar(usuario))
                    {
                        maskedTextBoxId.Text = usuario.UsuarioId.ToString();
                    }
                }
                else
                {
                    UsuariosBLL.Modificar(usuario);
                }
               
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(UtilidadesFormularios.Validar(maskedTextBoxId))
            {
                int id = int.Parse(maskedTextBoxId.Text);
                if (UsuariosBLL.Buscar(x=> x.UsuarioId == id, false))
                {
                    UsuariosBLL.Eliminar(UsuariosBLL.usuarioReturned);
                    UtilidadesFormularios.Limpiar(new List<TextBox> { textBoxPassword, textBoxUserName, textBoxRepeatPassword }, new List<MaskedTextBox> { maskedTextBoxId }, null);
                }
            }
        }
    }
}
