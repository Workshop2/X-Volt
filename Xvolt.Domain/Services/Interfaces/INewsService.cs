using System;
using System.Collections.Generic;
using Xvolt.Domain.Entities;

namespace Xvolt.Domain.Services.Interfaces
{
    public interface INewsService : IDisposable
    {
        IEnumerable<NewsArticle> GetNewsArticles();
    }
}