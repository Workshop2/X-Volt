using System.Collections.Generic;
using Xvolt.Domain.Models;

namespace Xvolt.Domain.Repositories
{
    public interface INewsContentRepository
    {
        NewsContent Get(int id);
        IEnumerable<NewsContent> List();
        void Save(NewsContent user);
        void Delete(NewsContent user);
    }
}