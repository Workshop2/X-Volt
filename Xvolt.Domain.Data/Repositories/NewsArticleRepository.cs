using System;
using System.Collections.Generic;
using System.Linq;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Repositories;

namespace Xvolt.Domain.Data.Repositories
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        public NewsArticle Get(int id)
        {
            return List().First(x => x.Id == id);
        }

        public IEnumerable<NewsArticle> List()
        {
            return new List<NewsArticle>
            {
                new NewsArticle
                {
                    Title = "News Item 1",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Id = 1,
                },
                new NewsArticle
                {
                    Title = "News Item 2",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Id = 2,
                },
                new NewsArticle
                {
                    Title = "News Item 3",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Id = 3,
                }
            };
        }

        public void Save(NewsArticle entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(NewsArticle entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}