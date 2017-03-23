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
    public class RutasBLL
    {
        public static Ruta rutaReturned = null;
        public static List<Ruta> rutaReturnedList = null;

        public static bool Guardar(Ruta ruta)
        {
            using (var db = new Repositorio<Ruta>())
            {
                if ((rutaReturned = db.Guardar(ruta)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(Ruta ruta)
        {
            using (var db = new Repositorio<Ruta>())
            {
                if ((rutaReturned = db.Modificar(ruta)) != null) return true;
                return false;
            }
        }
        public static bool Buscar(Expression<Func<Ruta, bool>> criterio)
        {
            using (var db = new Repositorio<Ruta>())
            {
                if ((rutaReturned = db.Buscar(criterio)) != null) return true;
                return false;
            }
        }
        public static bool Eliminar(Ruta ruta)
        {
            using (var db = new Repositorio<Ruta>())
            {
                if (db.Eliminar(ruta)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<Ruta, bool>> criterio)
        {
            using (var db = new Repositorio<Ruta>())
            {
                if ((rutaReturnedList = db.GetList(criterio)) != null) return true;
                return false;
            }
        }
    }
}
