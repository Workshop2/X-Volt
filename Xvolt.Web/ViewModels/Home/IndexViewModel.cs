using System.Collections.Generic;
using Xvolt.Domain.Entities;

namespace Xvolt.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<NewsArticle> NewsArticles { get; set; }
    }
}