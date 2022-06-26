using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _0_Framework.Domain
{
    public interface IRepository<Tkey, T> where T : class
    {
        void Create(T entity);
        T Get(Tkey id);
        List<T> Get();
        bool Exists(Expression<Func<T, bool>> expression);
        void SaveChanges();
    }
}
