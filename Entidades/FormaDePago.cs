using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FormaDePago
    {
        [Key]
        public int FormaDePagoId { get; set; }

        public string Descripcion { get; set; }

        public virtual List<Factura> Facturas {get; set;}


        public FormaDePago()
        {

        }

        public FormaDePago(int id, string descripcion)
        {
            this.FormaDePagoId = id;
            this.Descripcion = descripcion;
        }
    }
}
