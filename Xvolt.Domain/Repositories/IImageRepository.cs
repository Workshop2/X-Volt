using System.Collections.Generic;
using Xvolt.Domain.Entities;

namespace Xvolt.Domain.Repositories
{
    public interface IImageRepository : IRepository<Image>
    {
        IEnumerable<Image> ListForNewsArticle(int newsArticleId);
    }
}