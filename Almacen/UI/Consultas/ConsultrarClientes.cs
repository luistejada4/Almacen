using AlmacenLT.Utilidades;
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


        private void ConsultrarCliente_Load(object sender, EventArgs e)
        {
            dataGridView.Rows[0].Cells[2].Value = new Button().Text = "Ver";
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void backgroundWorkerConsultarClientes_DoWork(object sender, DoWorkEventArgs e)
        {
            

        }

        private void backgroundWorkerConsultarClientes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
