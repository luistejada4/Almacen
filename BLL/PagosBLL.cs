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
    public class PagosBLL
    {
        public static Pago pagoReturned = null;
        public static List<Pago> pagoReturnedList = null;

        public static bool Guardar(Pago pago)
        {
            using (var db = new Repositorio<Pago>())
            {
                if ((pagoReturned = db.Guardar(pago)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(Pago pago)
        {
            using (var db = new Repositorio<Pago>())
            {
                if ((pagoReturned = db.Modificar(pago)) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool Buscar(Expression<Func<Pago, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Pago>())
            {
                if ((pagoReturned = db.Buscar(criterio)) != null)
                {
                    if (relaciones)
                    {
                        FacturasBLL.Buscar(x => x.FacturaId == pagoReturned.FacturaId, true);
                        pagoReturned.Factura = FacturasBLL.facturaReturned;

                    }

                    return true;
                }
                return false;
            }
        }
        public static bool Eliminar(Pago pago)
        {
            using (var db = new Repositorio<Pago>())
            {
                if (db.Eliminar(pago)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<Pago, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Pago>())
            {
                if ((pagoReturnedList = db.GetList(criterio)) != null)
                {
                    if (relaciones)
                    {
                        foreach (var pago in pagoReturnedList)
                        {
                            FacturasBLL.Buscar(x => x.FacturaId == pago.FacturaId, true);
                            pago.Factura = FacturasBLL.facturaReturned;
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
