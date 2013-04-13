using System.Collections.Generic;
using Xvolt.Domain.Models;

namespace Xvolt.Domain.Repositories
{
    public interface INewsArticleRepository
    {
        NewsArticle Get(int id);
        IEnumerable<NewsArticle> List();
        void Save(NewsArticle user);
        void Delete(NewsArticle user);
    }
}