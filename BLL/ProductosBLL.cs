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
    public class ProductosBLL
    {
        public static Producto productoReturned = null;
        public static List<Producto> productoReturnedList = null;

        public static bool Guardar(Producto producto)
        {
            using (var db = new Repositorio<Producto>())
            {
                if ((productoReturned = db.Guardar(producto)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(Producto producto)
        {
            using (var db = new Repositorio<Producto>())
            {
                if ((productoReturned = db.Modificar(producto)) != null) return true;
                return false;
            }
        }
        public static bool Buscar(Expression<Func<Producto, bool>> criterio)
        {
            using (var db = new Repositorio<Producto>())
            {
                if ((productoReturned = db.Buscar(criterio)) != null) return true;
                return false;
            }
        }
        public static bool Eliminar(Producto producto)
        {
            using (var db = new Repositorio<Producto>())
            {
                if (db.Eliminar(producto)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<Producto, bool>> criterio)
        {
            using (var db = new Repositorio<Producto>())
            {
                if ((productoReturnedList = db.GetList(criterio)) != null) return true;
                return false;
            }
        }
    }
}
