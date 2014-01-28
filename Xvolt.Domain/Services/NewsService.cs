using System.Collections.Generic;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Repositories;
using Xvolt.Domain.Services.Interfaces;

namespace Xvolt.Domain.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsArticleRepository _newsArticleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IImageRepository _imageRepository;

        public NewsService(INewsArticleRepository newsArticleRepository, IUserRepository userRepository, IImageRepository imageRepository)
        {
            _newsArticleRepository = newsArticleRepository;
            _userRepository = userRepository;
            _imageRepository = imageRepository;
        }

        public IEnumerable<NewsArticle> GetNewsArticles()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            if (_newsArticleRepository != null)
            {
                _newsArticleRepository.Dispose();
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