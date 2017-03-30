using AlmacenLT;
using AlmacenLT.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen.UI
{
    public partial class Login : Form
    {
        ErrorProvider error = new ErrorProvider();
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (UtilidadesFormularios.Validar(new List<TextBox> { textBoxPassword, textBoxUserName }))
            {
                string user = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                using (var db = new DAL.Database())
                {
                   if(db.Usuarios.Where(x=> x.UserName == user && x.Password == password).FirstOrDefault() != null)
                    {
                       
                        this.Hide();
                        new Inicio().Show();

                    }
                   else
                    {
                        error.SetError(textBoxUserName, "Usuario o password o incorrecto!");
                        error.SetError(textBoxPassword, "Usuario o password o incorrecto!");
                    }
                }
            }
        }
    }
}
