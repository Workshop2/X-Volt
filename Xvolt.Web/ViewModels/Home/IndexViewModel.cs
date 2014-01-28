using System.Collections.Generic;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Repositories;

namespace Xvolt.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<NewsArticle> NewsItems { get { return ResolveNews(); } }
        private INewsArticleRepository NewsArticleRepository { get; set; }

        public IndexViewModel(INewsArticleRepository newsArticleRepository)
        {
            NewsArticleRepository = newsArticleRepository;
        }

        private IEnumerable<NewsArticle> ResolveNews()
        {
            return NewsArticleRepository.List();
        }
    }
}