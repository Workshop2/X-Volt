using System.Collections.Generic;
using Xvolt.Domain.Models;

namespace Xvolt.Domain.Repositories
{
    public interface IImageRepository
    {
        Image Get(int id);
        IEnumerable<Image> List();
        void Save(Image user);
        void Delete(Image user);
    }
}