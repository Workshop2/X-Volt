using System.Web.Mvc;
using StructureMap;
using Xvolt.Domain.Cache.Services;
using Xvolt.Domain.Data.Repositories;
using Xvolt.Domain.Repositories;
using Xvolt.Domain.Services;
using Xvolt.Domain.Services.Interfaces;
using Xvolt.Web.DependencyResolution;

namespace Xvolt.Web.App_Start
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());

            ObjectFactory.Initialize(x =>
            {
                x.Scan(y =>
                {
                    y.TheCallingAssembly();
                    y.AssembliesFromApplicationBaseDirectory();
                    y.WithDefaultConventions();

                    //y.AssemblyContainingType<NewsServiceWithDifferentName>();
                    //y.AssemblyContainingType<NewsServiceCache>();
                    //y.AssemblyContainingType<ImageRepository>();
                });

                //x.For<INewsService>()
                // .Use<NewsServiceCache>()
                // .EnrichWith((ctx, r) =>
                //                 {
                //                     return new NewsServiceWithDifferentName(ctx.GetInstance<INewsArticleRepository>(),
                //                                                             ctx.GetInstance<INewsContentRepository>(),
                //                                                             ctx.GetInstance<IUserRepository>(),
                //                                                             ctx.GetInstance<IImageRepository>());
                //                 });

                x.For<INewsService>()
                    .Use<NewsServiceCache>()
                        .Decorate()
                        .With<NewsService>();
            });

            return ObjectFactory.Container;
        }
    }
}