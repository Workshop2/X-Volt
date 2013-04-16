using System.Collections.Generic;
using System.Linq;
using Xvolt.Domain.Enums;
using Xvolt.Domain.Models;
using Xvolt.Domain.Repositories;

namespace Xvolt.Domain.Data.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public User Get(int id)
        {
            return List().First(x => x.Id == id);
        }

        public IQueryable<User> List()
        {
            return new List<User>
            {
                new User
                {
                    Admin = UserType.Admin,
                    Email = "test1@test.com",
                    FirstName = "Test1",
                    LastName = "User1",
                    Id = 1,
                    Username = "TestUser1"
                },
                new User
                {
                    Admin = UserType.Publisher,
                    Email = "test2@test.com",
                    FirstName = "Test2",
                    LastName = "User2",
                    Id = 2,
                    Username = "TestUser2"
                },
                new User
                {
                    Admin = UserType.Commenter,
                    Email = "test3@test.com",
                    FirstName = "Test3",
                    LastName = "User3",
                    Id = 3,
                    Username = "TestUser3"
                }
            }.AsQueryable();
        }

        public void Save(User user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}