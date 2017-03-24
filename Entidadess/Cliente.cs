using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set;} 
    
        public string Nombres { get; set; }
      
        public string Direccion { get; set; }
       
        public string Telefono { get; set; }
 
        public string Cedula { get; set; }
 
        public DateTime Fecha { get; set; }

        public int FacturaId { get; set; }
        public virtual List<Factura> Facturas { get; set; }

        public int RutaId { get; set; }
        public Ruta Ruta { get; set; }

        public Cliente()
        {

        }

        public Cliente(int clienteId, string nombres, string direccion, string telefono, string cedula, DateTime fecha, int rutaId)
        {
            this.ClienteId = clienteId;
            this.Nombres = nombres;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Cedula = cedula;
            this.Fecha = fecha;
            this.RutaId = rutaId;
      
        }
    }
}
