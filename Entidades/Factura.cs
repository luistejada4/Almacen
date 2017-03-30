using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {

        [Key]
        public int FacturaId { get; set; }

        public DateTime Fecha { get; set; }

        public float Total { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int FormaDePagoId { get; set; }
        public FormaDePago FormaDePago { get; set; }

        public virtual List<ProductoFactura> Productos { get; set; }

        public virtual List<Pago> Pagos { get; set;}



        public Factura()
        {
            Productos = new List<ProductoFactura>();
        }

        public Factura(int facturaId, int clienteId, int formaDePagoId, DateTime fecha, float total, int usuarioId)
        {

            this.FacturaId = facturaId;
            this.ClienteId = clienteId;
            this.FormaDePagoId = formaDePagoId;
            this.Fecha = fecha;
            this.Total = total;
           // this.UsuarioId = usuarioId;
            Productos = new List<ProductoFactura>();

        }
    }
}
