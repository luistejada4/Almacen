using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosInFacturas
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Monto { get; set; }

        public ProductosInFacturas(string nombre, int cantidad, double monto)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Monto = monto;
        }
    }
}
