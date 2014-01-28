using System.Collections.Generic;
using Xvolt.Domain.Entities;

namespace Xvolt.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserForNewsArticle(int articleId);
    }
}