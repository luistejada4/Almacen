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

namespace AlmacenLT.UI.Consultas
{
    public partial class ConsultarRutas : Form
    {
        public ConsultarRutas()
        {
            InitializeComponent();
        }

        private void comboBoxRutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarRutas_Load(object sender, EventArgs e)
        {
            if(BLL.RutasBLL.GetList(x => x.RutaId > 0, false))
            {
                comboBoxRutas.DataSource = RutasBLL.rutaReturnedList;
                comboBoxRutas.DisplayMember = "Lugar";
                comboBoxRutas.ValueMember = "RutaId";
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            RutasBLL.Buscar(x => x.RutaId == 2, false);
            
            foreach (var cliente in RutasBLL.rutaReturned.Clientes)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = cliente.Nombres;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
