using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private Database Context = null;

        public DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }

        public Repositorio()
        {
            Context = new Database();
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> criterio)
        {
            try
            {
                return EntitySet.Where(criterio).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
            }
        }

        public bool Eliminar(TEntity entidad)
        {
            bool result = false;
            try
            {
                Context.Entry<TEntity>(entidad).State = EntityState.Deleted;
                Context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterio)
        {
            List<TEntity> result = null;
            try
            {
                result = EntitySet.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public TEntity Guardar(TEntity entidad)
        {
            TEntity result = null;
            try
            {
                   Context.Entry<TEntity>(entidad).State = EntityState.Added;
                   Context.SaveChanges();
                   result = entidad;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        public TEntity Modificar(TEntity entidad)
        {
            TEntity result;
            try
            {
                Context.Entry<TEntity>(entidad).State = EntityState.Modified;
                Context.SaveChanges();
                result = entidad;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
