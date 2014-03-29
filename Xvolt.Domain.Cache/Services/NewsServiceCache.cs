using System.Collections.Generic;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Services.Interfaces; 

namespace Xvolt.Domain.Cache.Services
{
    public class NewsServiceCache : INewsService
    {
        private readonly INewsService _child;

        public NewsServiceCache(INewsService child)
        {
            _child = child;
        }

        private IEnumerable<NewsArticle> _newsArticleCache; 
        public IEnumerable<NewsArticle> GetNewsArticles()
        {
            return _newsArticleCache ?? (_newsArticleCache = _child.GetNewsArticles());
        }

        public void Dispose()
        {
            if (_child != null)
            {
                _child.Dispose();
            }
        }
    }
}