using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoFactura
    {
        [Key, Column(Order = 0)]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Key, Column(Order = 1)]
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public ProductoFactura()
        {

        }
        public ProductoFactura(int productoId, int facturaId)
        {
            this.ProductoId = productoId;
            this.FacturaId = facturaId;
        }
    }
}
