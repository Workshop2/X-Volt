using StructureMap;
using Xvolt.Domain.Data.Repositories;
using Xvolt.Domain.Repositories;

namespace Xvolt.Web.DependencyResolution
{
    public static class Ioc
    {
        public static void Setup()
        {
            ObjectFactory.Initialize(x =>
            {
                x.For<INewsArticleRepository>().Use<NewsArticleRepository>();
                x.For<IUserRepository>().Use<UserRepository>();
            });
        }
    }
}