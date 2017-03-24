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
    public class FacturasBLL
    {
        public static Factura facturaReturned = null;
        public static List<Factura> facturaReturnedList = null;

        public static bool Guardar(Factura factura)
        {
            using (var db = new Repositorio<Factura>())
            {
                if ((facturaReturned = db.Guardar(factura)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(Factura factura)
        {
            using (var db = new Repositorio<Factura>())
            {
                if ((facturaReturned = db.Modificar(factura)) != null) return true;
                return false;
            }
        }
        public static bool Buscar(Expression<Func<Factura, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Factura>())
            {
                if ((facturaReturned = db.Buscar(criterio)) != null)
                {
                    if(relaciones)
                    {
                        facturaReturned.Productos.Count();
                    }
                    return true;
                }
                return false;
            }
        }
        public static bool Eliminar(Factura factura)
        {
            using (var db = new Repositorio<Factura>())
            {
                if (db.Eliminar(factura)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<Factura, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Factura>())
            {
                if ((facturaReturnedList = db.GetList(criterio)) != null)
                {
                    if(relaciones)
                    {
                        foreach (var factura in facturaReturnedList)
                        {
                            factura.Productos.Count();
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
