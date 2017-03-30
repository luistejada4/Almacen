using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        [Key]
        public int PagoId { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public Pago()
        {

        }
        public Pago(int id, double monto, DateTime fecha, int facturaId)
        {
            this.FacturaId = id;
            this.Monto = monto;
            this.Fecha = fecha;
            this.FacturaId = facturaId;
        }
    }
}
