using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ruta
    {
        [Key]
        public int RutaId { get; set; }
  
        public string Lugar { get; set; }

        public int Dia { get; set; }

        public virtual List<Cliente> Clientes { get; set; }

        public Ruta()
        {
           
        }

        public Ruta(int rutaId, string lugar, int dia)
        {
            this.RutaId = rutaId;
            this.Lugar = lugar;
            this.Dia = dia;
            
        }
    }
}
