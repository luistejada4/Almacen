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
            using (var context = new Database())
            {
                context.Entry(factura).State = System.Data.Entity.EntityState.Modified;

                foreach (var producto in factura.Productos)
                {
                   
                    context.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
                return true;
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
                        facturaReturned.Pagos.Count();
                        ClientesBLL.Buscar(x => x.ClienteId == facturaReturned.ClienteId, false);
                        FormasDePagosBLL.Buscar(x => x.FormaDePagoId == facturaReturned.FormaDePagoId);
                        facturaReturned.FormaDePago = FormasDePagosBLL.formaDePagoReturned;
                        facturaReturned.Cliente = ClientesBLL.clienteReturned;

                        foreach (var producto in facturaReturned.Productos)
                        {
                            int id = producto.ProductoId;
                            ProductosBLL.Buscar(x => x.ProductoId == id, true);
                            producto.Producto = ProductosBLL.productoReturned;
                        }
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
                            ClientesBLL.Buscar(x => x.ClienteId == factura.ClienteId, false);
                            FormasDePagosBLL.Buscar(x => x.FormaDePagoId == factura.FormaDePagoId);
                            factura.FormaDePago = FormasDePagosBLL.formaDePagoReturned;
                            factura.Cliente = ClientesBLL.clienteReturned;
                            factura.Productos.Count();
                            facturaReturned.Pagos.Count();

                            foreach (var producto in factura.Productos)
                            {
                                int id = producto.ProductoId;
                                ProductosBLL.Buscar(x => x.ProductoId == id, true);
                                producto.Producto = ProductosBLL.productoReturned;
                            }
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
