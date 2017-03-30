using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosBLL
    {
        public static Usuario usuarioReturned = null;
        public static List<Usuario> usuarioReturnedList = null;

        public static bool Guardar(Usuario usuario)
        {
            using (var db = new Repositorio<Usuario>())
            {
                if ((usuarioReturned = db.Guardar(usuario)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(Usuario usuario)
        {
            using (var db = new Repositorio<Usuario>())
            {
                if ((usuarioReturned = db.Modificar(usuario)) != null)
                {
                   
                    return true;
                }
                return false;
            }
        }
        public static bool Buscar(Expression<Func<Usuario, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Usuario>())
            {
                if ((usuarioReturned = db.Buscar(criterio)) != null)
                {

                    return true;
                }
                return false;
            }
        }
        public static bool Eliminar(Usuario usuario)
        {
            using (var db = new Repositorio<Usuario>())
            {
                if (db.Eliminar(usuario)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<Usuario, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Usuario>())
            {
                if ((usuarioReturnedList = db.GetList(criterio)) != null)
                {
                    
                    return true;
                }
                return false;
            }
        }
    }
}
