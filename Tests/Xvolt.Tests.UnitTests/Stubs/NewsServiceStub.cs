using System.Collections.Generic;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Services.Interfaces;

namespace Xvolt.Tests.UnitTests.Stubs
{
    public class NewsServiceStub : INewsService
    {
        public IEnumerable<NewsArticle> GetNewsArticlesValues { get; set; }
        public int GetNewsArticlesCallCount { get; private set; }
        public IEnumerable<NewsArticle> GetNewsArticles()
        {
            GetNewsArticlesCallCount++;
            return GetNewsArticlesValues;
        }

        public bool Disposed { get; private set; }
        public void Dispose()
        {
            Disposed = true;
        }
    }
}