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
    public class ProductosFacturasBLL
    {
        public static ProductoFactura productoFacturaReturned = null;
        public static List<ProductoFactura> productoFacturaReturnedList = null;

        public static bool Guardar(ProductoFactura productoFactura)
        {
            using (var db = new Repositorio<ProductoFactura>())
            {
                if ((productoFacturaReturned = db.Guardar(productoFactura)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(ProductoFactura productoFactura)
        {
            using (var db = new Repositorio<ProductoFactura>())
            {
                if ((productoFacturaReturned = db.Modificar(productoFactura)) != null) return true;
                return false;
            }
        }
        public static bool Buscar(Expression<Func<ProductoFactura, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<ProductoFactura>())
            {
                if ((productoFacturaReturned = db.Buscar(criterio)) != null)
                {
                    FacturasBLL.Buscar(x => x.FacturaId == productoFacturaReturned.FacturaId, true);
                    productoFacturaReturned.Factura = FacturasBLL.facturaReturned;

                    ProductosBLL.Buscar(x => x.ProductoId == productoFacturaReturned.ProductoId, true);
                    productoFacturaReturned.Producto = ProductosFacturasBLL.productoFacturaReturned.Producto;

                    return true;
                }
                return false;
            }
        }
        public static bool Eliminar(ProductoFactura productoFactura)
        {
            using (var db = new Repositorio<ProductoFactura>())
            {
                if (db.Eliminar(productoFactura)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<ProductoFactura, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<ProductoFactura>())
            {
                if ((productoFacturaReturnedList = db.GetList(criterio)) != null)
                {
                    if (relaciones)
                    {
                        foreach (var productoFactura in productoFacturaReturnedList)
                        {
                            FacturasBLL.Buscar(x => x.FacturaId == productoFactura.FacturaId, true);
                            productoFactura.Factura = FacturasBLL.facturaReturned;
                            ProductosBLL.Buscar(x => x.ProductoId == productoFactura.ProductoId, true);
                            productoFactura.Producto = ProductosBLL.productoReturned;
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
