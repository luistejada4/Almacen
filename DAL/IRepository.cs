using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Guardar(TEntity entidad);
        bool Eliminar(TEntity entidad);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterio);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> criterio);
    }
}
