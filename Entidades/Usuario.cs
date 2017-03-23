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
        public int UserId { get; set; }
        [Required, MaxLength(30)]
        public string UserName { get; set; }
        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        public Usuario()
        {

        }
        public Usuario(string userName, string nombre, int nivelId)
        {
            this.UserName = userName;
            this.Nombre = nombre;
        }
    }
}
