using System.Collections.Generic;
using Xvolt.Domain.Models;

namespace Xvolt.Domain.Repositories
{
    public interface IImageRepository : IRepository<Image>
    {
        IEnumerable<Image> ListForNewsArticle(int newsArticleId);
    }
}