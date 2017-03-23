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
    public class FormasDePagosBLL
    {
        public static FormaDePago formaDePagoReturned = null;
        public static List<FormaDePago> formaDePagoReturnedList = null;
         
        public static bool Guardar(FormaDePago formaDePago)
        {
            using (var db = new Repositorio<FormaDePago>())
            {
                if ((formaDePagoReturned = db.Guardar(formaDePago)) != null) return true;
                return false;
            }
        }
        public static bool Modificar(FormaDePago formaDePago)
        {
            using (var db = new Repositorio<FormaDePago>())
            {
                if ((formaDePagoReturned = db.Modificar(formaDePago)) != null) return true;
                return false;
            }
        } 
        public static bool Buscar(Expression<Func<FormaDePago, bool>> criterio)
        {
            using (var db = new Repositorio<FormaDePago>())
            {
                if ((formaDePagoReturned = db.Buscar(criterio)) != null) return true;
                return false;
            }
        }
        public static bool Eliminar(FormaDePago formaDePago)
        {
            using (var db = new Repositorio<FormaDePago>())
            {
                if (db.Eliminar(formaDePago)) return true;
                return false;
            }
        }
        public static bool GetList(Expression<Func<FormaDePago, bool>> criterio)
        {
            using (var db = new Repositorio<FormaDePago>())
            {
                if ((formaDePagoReturnedList = db.GetList(criterio)) != null) return true;
                return false;
            }
        }
    }
}
