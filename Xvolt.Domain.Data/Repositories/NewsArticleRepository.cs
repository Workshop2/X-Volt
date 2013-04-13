using System;
using System.Collections.Generic;
using System.Linq;
using Xvolt.Domain.Models;
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
            var userRepo = new UserRepository();
            var contentRepo = new NewsContentRepository();

            return new List<NewsArticle>
            {
                new NewsArticle
                {
                    Author = userRepo.Get(1),
                    Title = "News Item 1",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Content = contentRepo.Get(1)
                },
                new NewsArticle
                {
                    Author = userRepo.Get(2),
                    Title = "News Item 2",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Content = contentRepo.Get(2)
                },
                new NewsArticle
                {
                    Author = userRepo.Get(3),
                    Title = "News Item 3",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Content = contentRepo.Get(3)
                }
            };
        }

        public void Save(NewsArticle user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(NewsArticle user)
        {
            throw new System.NotImplementedException();
        }
    }
}