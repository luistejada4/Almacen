using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual List<Factura> Facturas { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string userName, string password)
        {
            this.UsuarioId = id;
            this.UserName = userName;
            this.Password = password;
        }
    }
}
