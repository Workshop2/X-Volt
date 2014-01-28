using System;
using System.Collections.Generic;

namespace Xvolt.Domain.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Get(int id);
        IEnumerable<T> List();
        void Save(T entity);
        void Delete(T entity);
    }
}