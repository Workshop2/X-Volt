using System.Collections.Generic;
using Xvolt.Domain.Models;

namespace Xvolt.Domain.Repositories
{
    public interface IUserRepository
    {
        User Get(int id);
        IEnumerable<User> List();
        void Save(User user);
        void Delete(User user);
    }
}