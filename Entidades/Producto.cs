using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
    
        public string Nombre { get; set; }
     
        public float Costo { get; set; }

        public float Precio { get; set; }
       
        public int Cantidad { get; set; }

        public virtual List<ProductoFactura> Facturas { get; set; }

        public Producto()
        {
            Facturas = new List<ProductoFactura>();
        }
        public Producto(int productoId, string nombre, float costo, float precio, int cantidad)
        {
            this.ProductoId = productoId;
            this.Nombre = nombre;
            this.Costo = costo;
            this.Precio = precio;
            this.Cantidad = cantidad;

            Facturas = new List<ProductoFactura>();
        }
    }
}
