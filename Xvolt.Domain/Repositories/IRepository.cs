using System;
using System.Collections.Generic;
using System.Linq;

namespace Xvolt.Domain.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Get(int id);
        IQueryable<T> List();
        void Save(T user);
        void Delete(T user);
        bool SaveChanges();
    }
}