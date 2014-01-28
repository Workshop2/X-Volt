using System.Collections.Generic;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Repositories;
using Xvolt.Domain.Services.Interfaces;

namespace Xvolt.Domain.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsArticleRepository _newsArticleRepository;
        private readonly INewsContentRepository _newsContentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IImageRepository _imageRepository;

        public NewsService(INewsArticleRepository newsArticleRepository, INewsContentRepository newsContentRepository, IUserRepository userRepository, IImageRepository imageRepository)
        {
            _newsArticleRepository = newsArticleRepository;
            _newsContentRepository = newsContentRepository;
            _userRepository = userRepository;
            _imageRepository = imageRepository;
        }

        public IEnumerable<NewsArticle> GetNewsArticles()
        {
            IEnumerable<NewsArticle> newsArticles = _newsArticleRepository.List();

            foreach (NewsArticle newsArticle in newsArticles)
            {
                newsArticle.Author = _userRepository.Get(newsArticle.Id);
                newsArticle.Content = _newsContentRepository.Get(newsArticle.Id);
                newsArticle.Images = _imageRepository.ListForNewsArticle(newsArticle.Id);

                yield return newsArticle;
            }
        }

        public void Dispose()
        {
            if (_newsArticleRepository != null)
            {
                _newsArticleRepository.Dispose();
            }

            if (_newsContentRepository != null)
            {
                _newsContentRepository.Dispose();
            }

            if (_userRepository != null)
            {
                _userRepository.Dispose();
            }

            if (_imageRepository != null)
            {
                _imageRepository.Dispose();
            }
        }
    }
}