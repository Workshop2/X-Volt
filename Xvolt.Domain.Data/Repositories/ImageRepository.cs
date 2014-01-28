using System.Collections.Generic;
using System.Linq;
using Xvolt.Domain.Entities;
using Xvolt.Domain.Repositories;

namespace Xvolt.Domain.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        public Image Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Image> List()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Image> ListForNewsArticle(int newsArticleId)
        {
            return new List<Image> { new Image { Filename = "~/Images/DummyImages/putio_tile.png" } };
        }

        public void Save(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}