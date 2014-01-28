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
            var userRepo = new UserRepository();
            var contentRepo = new NewsContentRepository();
            var imageRepo = new ImageRepository();

            return new List<NewsArticle>
            {
                new NewsArticle
                {
                    Author = userRepo.Get(1),
                    Title = "News Item 1",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Content = contentRepo.Get(1),
                    Id = 1,
                    Images = imageRepo.ListForNewsArticle(1)
                },
                new NewsArticle
                {
                    Author = userRepo.Get(2),
                    Title = "News Item 2",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Content = contentRepo.Get(2),
                    Id = 2,
                    Images = imageRepo.ListForNewsArticle(2)
                },
                new NewsArticle
                {
                    Author = userRepo.Get(3),
                    Title = "News Item 3",
                    OriginalPublishDate = DateTime.Now,
                    Visible = true,
                    Content = contentRepo.Get(3),
                    Id = 3,
                    Images = imageRepo.ListForNewsArticle(3)
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
            throw new NotImplementedException();
        }
    }
}