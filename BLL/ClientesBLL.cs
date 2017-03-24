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
    public class ClientesBLL
    {
        public static Cliente clienteReturned = null;
        public static List<Cliente> clienteReturnedList = null;

        public static bool Guardar(Cliente cliente)
        {
            using (var db = new Repositorio<Cliente>())
            {
                if ((clienteReturned = db.Guardar(cliente)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(Cliente cliente)
        {
            using (var db = new Repositorio<Cliente>())
            {
                if ((clienteReturned = db.Modificar(cliente)) != null) return true;
                return false;
            }
        }
        public static bool Buscar(Expression<Func<Cliente, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Cliente>())
            {
                if ((clienteReturned = db.Buscar(criterio)) != null)
                {
                    if (relaciones) clienteReturned.Facturas.Count();
                    return true;
                }
                return false;
            }
        }
        public static bool Eliminar(Cliente cliente)
        {
            using (var db = new Repositorio<Cliente>())
            {
                if (db.Eliminar(cliente)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<Cliente, bool>> criterio, bool relaciones)
        {
            using (var db = new Repositorio<Cliente>())
            {
                if ((clienteReturnedList = db.GetList(criterio)) != null)
                {
                    if (relaciones)
                    {
                        foreach (var cliente in clienteReturnedList)
                        {
                            cliente.Facturas.Count();
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
